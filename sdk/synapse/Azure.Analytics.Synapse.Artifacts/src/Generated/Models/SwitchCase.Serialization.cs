// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SwitchCaseConverter))]
    public partial class SwitchCase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Optional.IsCollectionDefined(Activities))
            {
                writer.WritePropertyName("activities"u8);
                writer.WriteStartArray();
                foreach (var item in Activities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SwitchCase DeserializeSwitchCase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string value = default;
            IList<Activity> activities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Activity> array = new List<Activity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Activity.DeserializeActivity(item));
                    }
                    activities = array;
                    continue;
                }
            }
            return new SwitchCase(value, activities ?? new ChangeTrackingList<Activity>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SwitchCase FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSwitchCase(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class SwitchCaseConverter : JsonConverter<SwitchCase>
        {
            public override void Write(Utf8JsonWriter writer, SwitchCase model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override SwitchCase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSwitchCase(document.RootElement);
            }
        }
    }
}
