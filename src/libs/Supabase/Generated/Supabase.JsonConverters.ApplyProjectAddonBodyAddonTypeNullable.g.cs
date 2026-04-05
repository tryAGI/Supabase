#nullable enable

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApplyProjectAddonBodyAddonTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.ApplyProjectAddonBodyAddonType?>
    {
        /// <inheritdoc />
        public override global::Supabase.ApplyProjectAddonBodyAddonType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Supabase.ApplyProjectAddonBodyAddonTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Supabase.ApplyProjectAddonBodyAddonType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Supabase.ApplyProjectAddonBodyAddonType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.ApplyProjectAddonBodyAddonType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Supabase.ApplyProjectAddonBodyAddonTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
