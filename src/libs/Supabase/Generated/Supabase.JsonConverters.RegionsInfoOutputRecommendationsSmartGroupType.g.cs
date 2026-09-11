#nullable enable

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public sealed class RegionsInfoOutputRecommendationsSmartGroupTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.RegionsInfoOutputRecommendationsSmartGroupType>
    {
        /// <inheritdoc />
        public override global::Supabase.RegionsInfoOutputRecommendationsSmartGroupType Read(
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
                        return global::Supabase.RegionsInfoOutputRecommendationsSmartGroupTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Supabase.RegionsInfoOutputRecommendationsSmartGroupType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Supabase.RegionsInfoOutputRecommendationsSmartGroupType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.RegionsInfoOutputRecommendationsSmartGroupType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Supabase.RegionsInfoOutputRecommendationsSmartGroupTypeExtensions.ToValueString(value));
        }
    }
}
