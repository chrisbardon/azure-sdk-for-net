// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> NSX DHCP Server. </summary>
    public partial class WorkloadNetworkDhcpServer : WorkloadNetworkDhcpEntity
    {
        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkDhcpServer"/>. </summary>
        public WorkloadNetworkDhcpServer()
        {
            DhcpType = DhcpTypeEnum.Server;
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkDhcpServer"/>. </summary>
        /// <param name="dhcpType"> Type of DHCP: SERVER or RELAY. </param>
        /// <param name="displayName"> Display name of the DHCP entity. </param>
        /// <param name="segments"> NSX Segments consuming DHCP. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="revision"> NSX revision number. </param>
        /// <param name="serverAddress"> DHCP Server Address. </param>
        /// <param name="leaseTime"> DHCP Server Lease Time. </param>
        internal WorkloadNetworkDhcpServer(DhcpTypeEnum dhcpType, string displayName, IReadOnlyList<string> segments, WorkloadNetworkDhcpProvisioningState? provisioningState, long? revision, string serverAddress, long? leaseTime) : base(dhcpType, displayName, segments, provisioningState, revision)
        {
            ServerAddress = serverAddress;
            LeaseTime = leaseTime;
            DhcpType = dhcpType;
        }

        /// <summary> DHCP Server Address. </summary>
        public string ServerAddress { get; set; }
        /// <summary> DHCP Server Lease Time. </summary>
        public long? LeaseTime { get; set; }
    }
}
