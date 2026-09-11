#nullable enable

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public sealed class V1ProjectAdvisorsResponseOutputLintNameNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.V1ProjectAdvisorsResponseOutputLintName?>
    {
        /// <inheritdoc />
        public override global::Supabase.V1ProjectAdvisorsResponseOutputLintName? Read(
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
                        return global::Supabase.V1ProjectAdvisorsResponseOutputLintNameExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Supabase.V1ProjectAdvisorsResponseOutputLintName)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Supabase.V1ProjectAdvisorsResponseOutputLintName?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.V1ProjectAdvisorsResponseOutputLintName? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Supabase.V1ProjectAdvisorsResponseOutputLintNameExtensions.ToValueString(value.Value));
            }
        }
    }
}
