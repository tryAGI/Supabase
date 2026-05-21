#nullable enable

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public sealed class JitStateResponseDiscriminatorStateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.JitStateResponseDiscriminatorState?>
    {
        /// <inheritdoc />
        public override global::Supabase.JitStateResponseDiscriminatorState? Read(
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
                        return global::Supabase.JitStateResponseDiscriminatorStateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Supabase.JitStateResponseDiscriminatorState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Supabase.JitStateResponseDiscriminatorState?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.JitStateResponseDiscriminatorState? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Supabase.JitStateResponseDiscriminatorStateExtensions.ToValueString(value.Value));
            }
        }
    }
}
