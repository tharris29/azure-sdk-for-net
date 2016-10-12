// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Resource link filter.
    /// </summary>
    public partial class ResourceLinkFilter
    {
        /// <summary>
        /// Initializes a new instance of the ResourceLinkFilter class.
        /// </summary>
        public ResourceLinkFilter() { }

        /// <summary>
        /// Initializes a new instance of the ResourceLinkFilter class.
        /// </summary>
        /// <param name="targetId">The target Id of the resource.</param>
        public ResourceLinkFilter(string targetId = default(string))
        {
            TargetId = targetId;
        }

        /// <summary>
        /// Gets or sets the target Id of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }

    }
}
