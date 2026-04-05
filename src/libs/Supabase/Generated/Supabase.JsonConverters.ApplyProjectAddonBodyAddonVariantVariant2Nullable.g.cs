#nullable enable

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApplyProjectAddonBodyAddonVariantVariant2NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2?>
    {
        /// <inheritdoc />
        public override global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2? Read(
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
                        return global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2Extensions.ToValueString(value.Value));
            }
        }
    }
}
