// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The request for reservation merge. </summary>
    public partial class MergeContent
    {
        /// <summary> Initializes a new instance of <see cref="MergeContent"/>. </summary>
        public MergeContent()
        {
            Sources = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MergeContent"/>. </summary>
        /// <param name="sources"> Format of the resource id should be /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </param>
        internal MergeContent(IList<string> sources)
        {
            Sources = sources;
        }

        /// <summary> Format of the resource id should be /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </summary>
        public IList<string> Sources { get; }
    }
}
