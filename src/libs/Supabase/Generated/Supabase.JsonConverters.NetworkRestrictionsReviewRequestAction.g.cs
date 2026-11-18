#nullable enable

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public sealed class NetworkRestrictionsReviewRequestActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.NetworkRestrictionsReviewRequestAction>
    {
        /// <inheritdoc />
        public override global::Supabase.NetworkRestrictionsReviewRequestAction Read(
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
                        return global::Supabase.NetworkRestrictionsReviewRequestActionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Supabase.NetworkRestrictionsReviewRequestAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Supabase.NetworkRestrictionsReviewRequestAction);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.NetworkRestrictionsReviewRequestAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Supabase.NetworkRestrictionsReviewRequestActionExtensions.ToValueString(value));
        }
    }
}
