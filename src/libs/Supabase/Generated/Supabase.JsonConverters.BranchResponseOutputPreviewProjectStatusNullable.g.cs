#nullable enable

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public sealed class BranchResponseOutputPreviewProjectStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.BranchResponseOutputPreviewProjectStatus?>
    {
        /// <inheritdoc />
        public override global::Supabase.BranchResponseOutputPreviewProjectStatus? Read(
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
                        return global::Supabase.BranchResponseOutputPreviewProjectStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Supabase.BranchResponseOutputPreviewProjectStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Supabase.BranchResponseOutputPreviewProjectStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.BranchResponseOutputPreviewProjectStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Supabase.BranchResponseOutputPreviewProjectStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
