// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.Compute.Version_2018_04.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Operation status response
    /// </summary>
    public partial class OperationStatusResponse
    {
        /// <summary>
        /// Initializes a new instance of the OperationStatusResponse class.
        /// </summary>
        public OperationStatusResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationStatusResponse class.
        /// </summary>
        /// <param name="name">Operation ID</param>
        /// <param name="status">Operation status</param>
        /// <param name="startTime">Start time of the operation</param>
        /// <param name="endTime">End time of the operation</param>
        /// <param name="error">Api error</param>
        public OperationStatusResponse(string name = default(string), string status = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), ApiError error = default(ApiError))
        {
            Name = name;
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets operation ID
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets operation status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets start time of the operation
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets end time of the operation
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets api error
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ApiError Error { get; private set; }

    }
}
