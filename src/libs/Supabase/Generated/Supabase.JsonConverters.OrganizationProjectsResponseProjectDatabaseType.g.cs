#nullable enable

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public sealed class OrganizationProjectsResponseProjectDatabaseTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.OrganizationProjectsResponseProjectDatabaseType>
    {
        /// <inheritdoc />
        public override global::Supabase.OrganizationProjectsResponseProjectDatabaseType Read(
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
                        return global::Supabase.OrganizationProjectsResponseProjectDatabaseTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Supabase.OrganizationProjectsResponseProjectDatabaseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Supabase.OrganizationProjectsResponseProjectDatabaseType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.OrganizationProjectsResponseProjectDatabaseType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Supabase.OrganizationProjectsResponseProjectDatabaseTypeExtensions.ToValueString(value));
        }
    }
}
