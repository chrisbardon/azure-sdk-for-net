// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> A collection of Fhir services. </summary>
    internal partial class FhirServiceCollection
    {
        /// <summary> Initializes a new instance of <see cref="FhirServiceCollection"/>. </summary>
        internal FhirServiceCollection()
        {
            Value = new ChangeTrackingList<FhirServiceData>();
        }

        /// <summary> Initializes a new instance of <see cref="FhirServiceCollection"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of Fhir Services. </param>
        /// <param name="value"> The list of Fhir Services. </param>
        internal FhirServiceCollection(string nextLink, IReadOnlyList<FhirServiceData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of Fhir Services. </summary>
        public string NextLink { get; }
        /// <summary> The list of Fhir Services. </summary>
        public IReadOnlyList<FhirServiceData> Value { get; }
    }
}
