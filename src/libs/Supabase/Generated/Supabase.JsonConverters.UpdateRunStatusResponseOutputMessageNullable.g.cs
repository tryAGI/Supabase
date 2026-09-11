#nullable enable

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateRunStatusResponseOutputMessageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.UpdateRunStatusResponseOutputMessage?>
    {
        /// <inheritdoc />
        public override global::Supabase.UpdateRunStatusResponseOutputMessage? Read(
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
                        return global::Supabase.UpdateRunStatusResponseOutputMessageExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Supabase.UpdateRunStatusResponseOutputMessage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Supabase.UpdateRunStatusResponseOutputMessage?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.UpdateRunStatusResponseOutputMessage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Supabase.UpdateRunStatusResponseOutputMessageExtensions.ToValueString(value.Value));
            }
        }
    }
}
