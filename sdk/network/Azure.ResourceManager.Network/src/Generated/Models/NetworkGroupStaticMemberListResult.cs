// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Result of the request to list StaticMember. It contains a list of groups and a URL link to get the next set of results. </summary>
    internal partial class NetworkGroupStaticMemberListResult
    {
        /// <summary> Initializes a new instance of <see cref="NetworkGroupStaticMemberListResult"/>. </summary>
        internal NetworkGroupStaticMemberListResult()
        {
            Value = new ChangeTrackingList<NetworkGroupStaticMemberData>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkGroupStaticMemberListResult"/>. </summary>
        /// <param name="value"> Gets a page of StaticMember. </param>
        /// <param name="nextLink"> Gets the URL to get the next set of results. </param>
        internal NetworkGroupStaticMemberListResult(IReadOnlyList<NetworkGroupStaticMemberData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets a page of StaticMember. </summary>
        public IReadOnlyList<NetworkGroupStaticMemberData> Value { get; }
        /// <summary> Gets the URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
