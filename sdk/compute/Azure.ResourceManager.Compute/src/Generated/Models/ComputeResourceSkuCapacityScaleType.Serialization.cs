// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    internal static partial class ComputeResourceSkuCapacityScaleTypeExtensions
    {
        public static string ToSerialString(this ComputeResourceSkuCapacityScaleType value) => value switch
        {
            ComputeResourceSkuCapacityScaleType.None => "None",
            ComputeResourceSkuCapacityScaleType.Automatic => "Automatic",
            ComputeResourceSkuCapacityScaleType.Manual => "Manual",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ComputeResourceSkuCapacityScaleType value.")
        };

        public static ComputeResourceSkuCapacityScaleType ToComputeResourceSkuCapacityScaleType(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return ComputeResourceSkuCapacityScaleType.None;
            if (string.Equals(value, "Automatic", StringComparison.InvariantCultureIgnoreCase)) return ComputeResourceSkuCapacityScaleType.Automatic;
            if (string.Equals(value, "Manual", StringComparison.InvariantCultureIgnoreCase)) return ComputeResourceSkuCapacityScaleType.Manual;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ComputeResourceSkuCapacityScaleType value.");
        }
    }
}
