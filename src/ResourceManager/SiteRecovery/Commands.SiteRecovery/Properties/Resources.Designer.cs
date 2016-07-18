﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.SiteRecovery.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.SiteRecovery.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please provide required VM properties to update.
        /// </summary>
        internal static string ArgumentsMissingForUpdateVmProperties {
            get {
                return ResourceManager.GetString("ArgumentsMissingForUpdateVmProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AzureVMNetwork {0} is not associated with the Subscription {1}.
        /// </summary>
        internal static string AzureVMNetworkIsNotAssociatedWithTheSubscription {
            get {
                return ResourceManager.GetString("AzureVMNetworkIsNotAssociatedWithTheSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation Failed.
        ///.
        /// </summary>
        internal static string CloudExceptionDetails {
            get {
                return ResourceManager.GetString("CloudExceptionDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cloud is not paired.
        /// </summary>
        internal static string CloudNotPaired {
            get {
                return ResourceManager.GetString("CloudNotPaired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cloud Service name mentioned is either null or empty.
        /// </summary>
        internal static string CloudServiceNameNullOrEmpty {
            get {
                return ResourceManager.GetString("CloudServiceNameNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory {0} Not Found.
        /// </summary>
        internal static string DirectoryNotFound {
            get {
                return ResourceManager.GetString("DirectoryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure want to disable protection on {0}.
        /// </summary>
        internal static string DisableProtectionWarning {
            get {
                return ResourceManager.GetString("DisableProtectionWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}s protection.
        /// </summary>
        internal static string DisableProtectionWhatIfMessage {
            get {
                return ResourceManager.GetString("DisableProtectionWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File &quot;{0}&quot; already exists. Specify a different name or path..
        /// </summary>
        internal static string FileAlreadyExists {
            get {
                return ResourceManager.GetString("FileAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} Not Found.
        /// </summary>
        internal static string FileNotFound {
            get {
                return ResourceManager.GetString("FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Group &quot;{0}&quot; not found for recovery plan &quot;{1}&quot;.
        /// </summary>
        internal static string GroupNotFoundInRecoveryPlan {
            get {
                return ResourceManager.GetString("GroupNotFoundInRecoveryPlan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calls using ID based parameter {0} will not be supported from next release. Please use its corresponding full object parameter instead..
        /// </summary>
        internal static string IDBasedParamUsageNotSupportedFromNextRelease {
            get {
                return ResourceManager.GetString("IDBasedParamUsageNotSupportedFromNextRelease", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please pass a valid Hyper-V server object if you have set CreateVmIfNotFound to &apos;Yes&apos; while doing failback in hyper-V to Azure scenario. .
        /// </summary>
        internal static string ImproperServerObjectPassedForHyperVFailback {
            get {
                return ResourceManager.GetString("ImproperServerObjectPassedForHyperVFailback", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replication Provider {0} entered invalid for the current set of parameters..
        /// </summary>
        internal static string IncorrectReplicationProvider {
            get {
                return ResourceManager.GetString("IncorrectReplicationProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vault information (Name: {0}, Location: {1}) is not correct.
        /// </summary>
        internal static string InCorrectVaultInformation {
            get {
                return ResourceManager.GetString("InCorrectVaultInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation failed.
        ///{0}.
        /// </summary>
        internal static string InvalidCloudExceptionErrorMessage {
            get {
                return ResourceManager.GetString("InvalidCloudExceptionErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid parameter set used. Please call the cmdlet with a valid parameter set..
        /// </summary>
        internal static string InvalidParameterSet {
            get {
                return ResourceManager.GetString("InvalidParameterSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replication Frequency {0} is invalid.
        /// </summary>
        internal static string InvalidReplicationFrequency {
            get {
                return ResourceManager.GetString("InvalidReplicationFrequency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource is not associted with the selected Resource group.
        /// </summary>
        internal static string InvalidResource {
            get {
                return ResourceManager.GetString("InvalidResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource Group is not associated with the selected Subscription.
        /// </summary>
        internal static string InvalidResourceGroup {
            get {
                return ResourceManager.GetString("InvalidResourceGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Server Type.
        /// </summary>
        internal static string InvalidServerType {
            get {
                return ResourceManager.GetString("InvalidServerType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported vault object is passed. Please pass Claasic or ARM vault object..
        /// </summary>
        internal static string InvalidVaultObject {
            get {
                return ResourceManager.GetString("InvalidVaultObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to XML is malformed or file is empty, exception details: {0}.
        /// </summary>
        internal static string InvalidXml {
            get {
                return ResourceManager.GetString("InvalidXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} will be a mandatory paramter from next release..
        /// </summary>
        internal static string MandatoryParamFromNextRelease {
            get {
                return ResourceManager.GetString("MandatoryParamFromNextRelease", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vault Key value is missing. Please import Vault Settings and verify the same.
        /// </summary>
        internal static string MissingChannelIntergrityKey {
            get {
                return ResourceManager.GetString("MissingChannelIntergrityKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vault Settings are missing. Please import Vault Settings and verify the same.
        /// </summary>
        internal static string MissingVaultSettings {
            get {
                return ResourceManager.GetString("MissingVaultSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please provide both Source Nic and Recovery Target to update.
        /// </summary>
        internal static string NetworkArgumentsMissingForUpdateVmProperties {
            get {
                return ResourceManager.GetString("NetworkArgumentsMissingForUpdateVmProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creates a new in-memory Policy association object..
        /// </summary>
        internal static string NewPolicyObjectWhatIfMessage {
            get {
                return ResourceManager.GetString("NewPolicyObjectWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nic not found in VM.
        /// </summary>
        internal static string NicNotFoundInVMForUpdateVmProperties {
            get {
                return ResourceManager.GetString("NicNotFoundInVMForUpdateVmProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RecoveryServices client is null, please check Resource, Cloud Service information in Vault Settings.
        /// </summary>
        internal static string NullRecoveryServicesClient {
            get {
                return ResourceManager.GetString("NullRecoveryServicesClient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter(s) &quot;{0}&quot; will be deprecated soon. Please use use parameter(s) &quot;{1}&quot; instead..
        /// </summary>
        internal static string ParameterWillBeDeprecatedSoon {
            get {
                return ResourceManager.GetString("ParameterWillBeDeprecatedSoon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passing policy is mandatory for enabling protection..
        /// </summary>
        internal static string PassingPolicyMandatoryForEnablingDR {
            get {
                return ResourceManager.GetString("PassingPolicyMandatoryForEnablingDR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passing Azure storage account is mandatory for enabling protection in Enterprise to Azure and Hoster to Azure scenarios..
        /// </summary>
        internal static string PassingStorageMandatoryForEnablingDRInAzureScenarios {
            get {
                return ResourceManager.GetString("PassingStorageMandatoryForEnablingDRInAzureScenarios", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Policy {0} is not associated with the Vault {1}.
        /// </summary>
        internal static string PolicyNotFound {
            get {
                return ResourceManager.GetString("PolicyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protection Container {0} is not associated with the Vault {1}.
        /// </summary>
        internal static string ProtectionContainerNotFound {
            get {
                return ResourceManager.GetString("ProtectionContainerNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protection entity {0} is already disabled.
        /// </summary>
        internal static string ProtectionEntityAlreadyDisabled {
            get {
                return ResourceManager.GetString("ProtectionEntityAlreadyDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protection entity {0} is already enabled.
        /// </summary>
        internal static string ProtectionEntityAlreadyEnabled {
            get {
                return ResourceManager.GetString("ProtectionEntityAlreadyEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protection Entity {0} is not associated with Protection Container {1}.
        /// </summary>
        internal static string ProtectionEntityNotFound {
            get {
                return ResourceManager.GetString("ProtectionEntityNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protection Entity {0} is not protected..
        /// </summary>
        internal static string ProtectionEntityNotProtected {
            get {
                return ResourceManager.GetString("ProtectionEntityNotProtected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protection is not enabled for VM.
        /// </summary>
        internal static string ProtectionIsNotEnabledForVM {
            get {
                return ResourceManager.GetString("ProtectionIsNotEnabledForVM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RecoveryPlan  {0} is not associated with the Vault {1}.
        /// </summary>
        internal static string RecoveryPlanNotFound {
            get {
                return ResourceManager.GetString("RecoveryPlanNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure want to remove Recovery Plan {0}.
        /// </summary>
        internal static string RemoveRPWarning {
            get {
                return ResourceManager.GetString("RemoveRPWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Recovery Plan.
        /// </summary>
        internal static string RemoveRPWhatIfMessage {
            get {
                return ResourceManager.GetString("RemoveRPWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove Site {0}.
        /// </summary>
        internal static string RemoveSiteWarning {
            get {
                return ResourceManager.GetString("RemoveSiteWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removes Site.
        /// </summary>
        internal static string RemoveSiteWhatIfMessage {
            get {
                return ResourceManager.GetString("RemoveSiteWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove Vault {0}.
        /// </summary>
        internal static string RemoveVaultWarning {
            get {
                return ResourceManager.GetString("RemoveVaultWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removes Vault.
        /// </summary>
        internal static string RemoveVaultWhatIfMessage {
            get {
                return ResourceManager.GetString("RemoveVaultWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replication Start Time span value cannot be greater then 24 hours..
        /// </summary>
        internal static string ReplicationStartTimeInvalid {
            get {
                return ResourceManager.GetString("ReplicationStartTimeInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource name mentioned is either null or empty.
        /// </summary>
        internal static string ResourceNameNullOrEmpty {
            get {
                return ResourceManager.GetString("ResourceNameNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generated JSON for Recovery Plan {0} at {1}.
        /// </summary>
        internal static string RPJSONPath {
            get {
                return ResourceManager.GetString("RPJSONPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server {0} is not associated with the Vault {1}.
        /// </summary>
        internal static string ServerNotFound {
            get {
                return ResourceManager.GetString("ServerNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Site name {0} is not valid. Please try again with the correct site details..
        /// </summary>
        internal static string SiteDetailsNotValid {
            get {
                return ResourceManager.GetString("SiteDetailsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Site {0} is not associated with the Vault {1}.
        /// </summary>
        internal static string SiteNotFound {
            get {
                return ResourceManager.GetString("SiteNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SiteRecovery vault type will be deprecated soon. Please use RecoveryServices vault type instead..
        /// </summary>
        internal static string SiteRecoveryVaultTypeWillBeDeprecatedSoon {
            get {
                return ResourceManager.GetString("SiteRecoveryVaultTypeWillBeDeprecatedSoon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Some hyper-V hosts are registered to this site. Cannot remove the site..
        /// </summary>
        internal static string SiteRemovalWithRegisteredHyperVHostsError {
            get {
                return ResourceManager.GetString("SiteRemovalWithRegisteredHyperVHostsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter the storage account name details in the Policy..
        /// </summary>
        internal static string StorageAccountNameIsNotValid {
            get {
                return ResourceManager.GetString("StorageAccountNameIsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Subscription or Storage account couldn’t be validated. For failovers to be successful, the Subscription should belong to your account, the Storage account to the Subscription and Storage account location must be the same as location of your Vault..
        /// </summary>
        internal static string StorageAccountValidationUnsuccessful {
            get {
                return ResourceManager.GetString("StorageAccountValidationUnsuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Storage account given is in a different location as compared to the current vault.
        ///Please provide a storage account with the same location as that of the vault..
        /// </summary>
        internal static string StorageIsNotInTheSameLocationAsVault {
            get {
                return ResourceManager.GetString("StorageIsNotInTheSameLocationAsVault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter the subscription ID details..
        /// </summary>
        internal static string SubscriptionIdIsNotValid {
            get {
                return ResourceManager.GetString("SubscriptionIdIsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription {0} is not associated with the account.
        /// </summary>
        internal static string SubscriptionIsNotAssociatedWithTheAccount {
            get {
                return ResourceManager.GetString("SubscriptionIsNotAssociatedWithTheAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported direction for TFO.
        /// </summary>
        internal static string UnsupportedDirectionForTFO {
            get {
                return ResourceManager.GetString("UnsupportedDirectionForTFO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported replication provider for set VM properties.
        /// </summary>
        internal static string UnsupportedReplicationProvidedForUpdateVmProperties {
            get {
                return ResourceManager.GetString("UnsupportedReplicationProvidedForUpdateVmProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not validate the storage account and subscription given.
        ///Are you sure you want to continue {0}?.
        /// </summary>
        internal static string ValidationUnsuccessfulWarning {
            get {
                return ResourceManager.GetString("ValidationUnsuccessfulWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vault {0} cannot be deleted as it contains registered servers. Unregister them and then retry the operation..
        /// </summary>
        internal static string VaultCannotBeDeleted {
            get {
                return ResourceManager.GetString("VaultCannotBeDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vault has been created.
        /// </summary>
        internal static string VaultCreationSuccessMessage {
            get {
                return ResourceManager.GetString("VaultCreationSuccessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vault has been deleted.
        /// </summary>
        internal static string VaultDeletionSuccessMessage {
            get {
                return ResourceManager.GetString("VaultDeletionSuccessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vault {0} is not associated with the given subscription..
        /// </summary>
        internal static string VaultNotFound {
            get {
                return ResourceManager.GetString("VaultNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vault settings file not found, please pass the file downloaded from portal.
        /// </summary>
        internal static string VaultSettingFileNotFound {
            get {
                return ResourceManager.GetString("VaultSettingFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot generate vault settings file for this vault. Download it from the Azure Portal..
        /// </summary>
        internal static string VaultSettingsGenerationUnSupported {
            get {
                return ResourceManager.GetString("VaultSettingsGenerationUnSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual Machine Group {0} is not associated with Protection Container {1}.
        /// </summary>
        internal static string VirtualMachineGroupNotFound {
            get {
                return ResourceManager.GetString("VirtualMachineGroupNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual Machine {0} is not associated with Protection Container {1}.
        /// </summary>
        internal static string VirtualMachineNotFound {
            get {
                return ResourceManager.GetString("VirtualMachineNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual Machine &quot;{0}&quot; is already part of Group &quot;{1}&quot; for recovery plan &quot;{2}&quot;.
        /// </summary>
        internal static string VMAlreadyPartOfGroup {
            get {
                return ResourceManager.GetString("VMAlreadyPartOfGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual Machine &quot;{0}&quot; not found in Group &quot;{1}&quot; for recovery plan &quot;{2}&quot;.
        /// </summary>
        internal static string VMNotFoundInGroup {
            get {
                return ResourceManager.GetString("VMNotFoundInGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for completion.
        /// </summary>
        internal static string WaitingForCompletion {
            get {
                return ResourceManager.GetString("WaitingForCompletion", resourceCulture);
            }
        }
    }
}
