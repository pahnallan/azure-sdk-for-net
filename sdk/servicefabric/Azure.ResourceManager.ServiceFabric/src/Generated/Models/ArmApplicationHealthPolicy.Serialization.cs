// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ArmApplicationHealthPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ConsiderWarningAsError))
            {
                writer.WritePropertyName("considerWarningAsError");
                writer.WriteBooleanValue(ConsiderWarningAsError.Value);
            }
            if (Optional.IsDefined(MaxPercentUnhealthyDeployedApplications))
            {
                writer.WritePropertyName("maxPercentUnhealthyDeployedApplications");
                writer.WriteNumberValue(MaxPercentUnhealthyDeployedApplications.Value);
            }
            if (Optional.IsDefined(DefaultServiceTypeHealthPolicy))
            {
                writer.WritePropertyName("defaultServiceTypeHealthPolicy");
                writer.WriteObjectValue(DefaultServiceTypeHealthPolicy);
            }
            if (Optional.IsCollectionDefined(ServiceTypeHealthPolicyMap))
            {
                writer.WritePropertyName("serviceTypeHealthPolicyMap");
                writer.WriteStartObject();
                foreach (var item in ServiceTypeHealthPolicyMap)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ArmApplicationHealthPolicy DeserializeArmApplicationHealthPolicy(JsonElement element)
        {
            Optional<bool> considerWarningAsError = default;
            Optional<int> maxPercentUnhealthyDeployedApplications = default;
            Optional<ArmServiceTypeHealthPolicy> defaultServiceTypeHealthPolicy = default;
            Optional<IDictionary<string, ArmServiceTypeHealthPolicy>> serviceTypeHealthPolicyMap = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("considerWarningAsError"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    considerWarningAsError = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxPercentUnhealthyDeployedApplications"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxPercentUnhealthyDeployedApplications = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("defaultServiceTypeHealthPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defaultServiceTypeHealthPolicy = ArmServiceTypeHealthPolicy.DeserializeArmServiceTypeHealthPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("serviceTypeHealthPolicyMap"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, ArmServiceTypeHealthPolicy> dictionary = new Dictionary<string, ArmServiceTypeHealthPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ArmServiceTypeHealthPolicy.DeserializeArmServiceTypeHealthPolicy(property0.Value));
                    }
                    serviceTypeHealthPolicyMap = dictionary;
                    continue;
                }
            }
            return new ArmApplicationHealthPolicy(Optional.ToNullable(considerWarningAsError), Optional.ToNullable(maxPercentUnhealthyDeployedApplications), defaultServiceTypeHealthPolicy.Value, Optional.ToDictionary(serviceTypeHealthPolicyMap));
        }
    }
}
