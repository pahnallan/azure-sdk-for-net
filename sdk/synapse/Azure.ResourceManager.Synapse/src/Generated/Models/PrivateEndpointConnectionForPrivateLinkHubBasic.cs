// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The PrivateEndpointConnectionForPrivateLinkHubBasic. </summary>
    public partial class PrivateEndpointConnectionForPrivateLinkHubBasic
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionForPrivateLinkHubBasic. </summary>
        internal PrivateEndpointConnectionForPrivateLinkHubBasic()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionForPrivateLinkHubBasic. </summary>
        /// <param name="id"></param>
        /// <param name="properties"> Properties of a private endpoint connection. </param>
        internal PrivateEndpointConnectionForPrivateLinkHubBasic(string id, PrivateEndpointConnectionProperties properties)
        {
            Id = id;
            Properties = properties;
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Properties of a private endpoint connection. </summary>
        public PrivateEndpointConnectionProperties Properties { get; }
    }
}
