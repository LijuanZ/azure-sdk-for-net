// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Fabric.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Storage operation result description.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StorageOperationResult : Resource
    {
        /// <summary>
        /// Initializes a new instance of the StorageOperationResult class.
        /// </summary>
        public StorageOperationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageOperationResult class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">The region where the resource is
        /// located.</param>
        /// <param name="tags">List of key-value pairs.</param>
        /// <param name="instances">List of operation result instances.</param>
        /// <param name="provisioningState">Success or failure of
        /// operation.</param>
        public StorageOperationResult(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<string> instances = default(IList<string>), string provisioningState = default(string))
            : base(id, name, type, location, tags)
        {
            Instances = instances;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of operation result instances.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instances")]
        public IList<string> Instances { get; set; }

        /// <summary>
        /// Gets or sets success or failure of operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

    }
}