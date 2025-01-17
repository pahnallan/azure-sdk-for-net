// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryWebhookEventContent
    {
        internal static ContainerRegistryWebhookEventContent DeserializeContainerRegistryWebhookEventContent(JsonElement element)
        {
            Optional<Guid> id = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> action = default;
            Optional<ContainerRegistryWebhookEventTarget> target = default;
            Optional<ContainerRegistryWebhookEventRequestContent> request = default;
            Optional<ContainerRegistryWebhookEventActor> actor = default;
            Optional<ContainerRegistryWebhookEventSource> source = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("timestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("action"))
                {
                    action = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    target = ContainerRegistryWebhookEventTarget.DeserializeContainerRegistryWebhookEventTarget(property.Value);
                    continue;
                }
                if (property.NameEquals("request"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    request = ContainerRegistryWebhookEventRequestContent.DeserializeContainerRegistryWebhookEventRequestContent(property.Value);
                    continue;
                }
                if (property.NameEquals("actor"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    actor = ContainerRegistryWebhookEventActor.DeserializeContainerRegistryWebhookEventActor(property.Value);
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    source = ContainerRegistryWebhookEventSource.DeserializeContainerRegistryWebhookEventSource(property.Value);
                    continue;
                }
            }
            return new ContainerRegistryWebhookEventContent(Optional.ToNullable(id), Optional.ToNullable(timestamp), action.Value, target.Value, request.Value, actor.Value, source.Value);
        }
    }
}
