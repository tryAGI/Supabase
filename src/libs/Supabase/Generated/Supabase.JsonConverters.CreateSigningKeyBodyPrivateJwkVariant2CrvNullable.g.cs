#nullable enable

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSigningKeyBodyPrivateJwkVariant2CrvNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Crv?>
    {
        /// <inheritdoc />
        public override global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Crv? Read(
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
                        return global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2CrvExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Crv)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Crv?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Crv? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2CrvExtensions.ToValueString(value.Value));
            }
        }
    }
}
