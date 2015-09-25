﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using AutoMapper;
using Microsoft.Azure.Commands.Compute.Common;
using Microsoft.Azure.Commands.Compute.Models;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Management.Automation;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Azure.Commands.Management.Storage;
using Microsoft.Azure.Commands.ResourceManager.Common;
using Microsoft.Azure.Common.Authentication;
using Microsoft.Azure.Common.Authentication.Models;
using Microsoft.Azure.Management.Storage;
using Microsoft.Azure.Management.Storage.Models;

namespace Microsoft.Azure.Commands.Compute
{
    [Cmdlet(VerbsCommon.New, ProfileNouns.VirtualMachine)]
    [OutputType(typeof(PSComputeLongRunningOperation))]
    public class NewAzureVMCommand : VirtualMachineBaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string Location { get; set; }

        [Alias("VMProfile")]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public PSVirtualMachine VM { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public Hashtable[] Tags { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            if (this.VM.DiagnosticsProfile == null)
            {
                this.VM.DiagnosticsProfile = new DiagnosticsProfile
                {
                    BootDiagnostics = new BootDiagnostics
                    {
                        Enabled = true,
                        StorageUri = GetStorageAccountForBootDiagnostics()
                    }
                };
            }

            ExecuteClientAction(() =>
            {
                var parameters = new VirtualMachine
                {
                    DiagnosticsProfile       = this.VM.DiagnosticsProfile,
                    HardwareProfile          = this.VM.HardwareProfile,
                    StorageProfile           = this.VM.StorageProfile,
                    NetworkProfile           = this.VM.NetworkProfile,
                    OSProfile                = this.VM.OSProfile,
                    Plan                     = this.VM.Plan,
                    AvailabilitySetReference = this.VM.AvailabilitySetReference,
                    Location                 = !string.IsNullOrEmpty(this.Location) ? this.Location : this.VM.Location,
                    Name                     = this.VM.Name,
                    Tags                     = this.Tags != null ? this.Tags.ToDictionary() : this.VM.Tags
                };

                var op = this.VirtualMachineClient.CreateOrUpdate(this.ResourceGroupName, parameters);
                var result = Mapper.Map<PSComputeLongRunningOperation>(op);
                WriteObject(result);
            });
        }

        private Uri GetStorageAccountForBootDiagnostics()
        {                        
            var storageAccountName = GetStorageAccountNameFromStorageProfile();
            var storageClient =
                    AzureSession.ClientFactory.CreateClient<StorageManagementClient>(DefaultProfile.Context,
                        AzureEnvironment.Endpoint.ResourceManager);

            if (! string.IsNullOrEmpty(storageAccountName))
            {
                var storageAccountResponse = storageClient.StorageAccounts.GetProperties(this.ResourceGroupName, storageAccountName);

                if (! storageAccountResponse.StorageAccount.AccountType.Equals(AccountType.PremiumLRS))
                {
                    return storageAccountResponse.StorageAccount.PrimaryEndpoints.Blob;
                }
            }

            var storageAccount = TryToChooseExistingStandardStorageAccount(storageClient);

            return (storageAccount == null)
                ? CreateStandardStorageAccount(storageClient)
                : storageAccount.PrimaryEndpoints.Blob;
        }

        private string GetStorageAccountNameFromStorageProfile()
        {
            if (this.VM == null
                || this.VM.StorageProfile == null
                || this.VM.StorageProfile.OSDisk == null
                || this.VM.StorageProfile.OSDisk.VirtualHardDisk == null
                || this.VM.StorageProfile.OSDisk.VirtualHardDisk.Uri == null)
            {
                return null;
            }

            return GetStorageAccountNameFromUriString(this.VM.StorageProfile.OSDisk.VirtualHardDisk.Uri);
        }

        private StorageAccount TryToChooseExistingStandardStorageAccount(StorageManagementClient client)
        {
            var storageAccountList = client.StorageAccounts.ListByResourceGroup(this.ResourceGroupName);
            if (storageAccountList == null)
            {
                return null;
            }

            try
            {
                return storageAccountList.StorageAccounts.First(
                e => e.AccountType.HasValue && !e.AccountType.Value.Equals(AccountType.PremiumLRS));
            }
            catch (InvalidOperationException e)
            {
                if (e.Message.Contains("Sequence contains no matching element"))
                {
                    return null;
                }
                throw;
            }
        }
        
        private Uri CreateStandardStorageAccount(StorageManagementClient client)
        {
            string storageAccountName;

            do
            {
                storageAccountName = GetRandomStorageAccountName();
                
            }
            while (! client.StorageAccounts.CheckNameAvailability(storageAccountName).NameAvailable);


            StorageAccountCreateParameters storaeAccountParameter = new StorageAccountCreateParameters
            {
                AccountType = AccountType.StandardGRS,
                Location = this.Location ?? this.VM.Location,
            };

            client.StorageAccounts.Create(this.ResourceGroupName, storageAccountName, storaeAccountParameter);

            var getresponse = client.StorageAccounts.GetProperties(this.ResourceGroupName, storageAccountName);

            return getresponse.StorageAccount.PrimaryEndpoints.Blob;
        }

        private string GetRandomStorageAccountName()
        {
            var subscriptionAccount = this.ComputeClient.ComputeManagementClient.Credentials.SubscriptionId;
            var resourcename = this.ResourceGroupName;
            var guidstring = Guid.NewGuid().ToString("N");
            var datetimestr = DateTime.Now.ToString(CultureInfo.InvariantCulture);

            string inputstr = guidstring + datetimestr + subscriptionAccount + resourcename;

            HashAlgorithm algorithm = MD5.Create();
            var outputbyte =  algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputstr));
            var output = Convert.ToBase64String(outputbyte);

            output = new string((from c in output where char.IsLetterOrDigit(c) select c).ToArray());

            return (output.Length > 24)
                ? output.Substring(0, 24).ToLowerInvariant()
                : output.ToLowerInvariant();
        }

        private string GetStorageAccountNameFromUriString(string uriStr)
        {
            Uri uri;

            if (!Uri.TryCreate(uriStr, UriKind.RelativeOrAbsolute, out uri))
            {
                return null;
            }

            var storageUri = uri.Authority;
            var index = storageUri.IndexOf('.');
            return storageUri.Substring(0, index);
        }
    }
}
