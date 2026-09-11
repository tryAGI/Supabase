#nullable enable

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public sealed class SigningKeysResponseOutputKeyAlgorithmNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.SigningKeysResponseOutputKeyAlgorithm?>
    {
        /// <inheritdoc />
        public override global::Supabase.SigningKeysResponseOutputKeyAlgorithm? Read(
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
                        return global::Supabase.SigningKeysResponseOutputKeyAlgorithmExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Supabase.SigningKeysResponseOutputKeyAlgorithm)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Supabase.SigningKeysResponseOutputKeyAlgorithm?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.SigningKeysResponseOutputKeyAlgorithm? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Supabase.SigningKeysResponseOutputKeyAlgorithmExtensions.ToValueString(value.Value));
            }
        }
    }
}
