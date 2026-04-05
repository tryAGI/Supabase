#nullable enable

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public sealed class OrganizationProjectsResponseProjectDatabaseStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.OrganizationProjectsResponseProjectDatabaseStatus?>
    {
        /// <inheritdoc />
        public override global::Supabase.OrganizationProjectsResponseProjectDatabaseStatus? Read(
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
                        return global::Supabase.OrganizationProjectsResponseProjectDatabaseStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Supabase.OrganizationProjectsResponseProjectDatabaseStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Supabase.OrganizationProjectsResponseProjectDatabaseStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.OrganizationProjectsResponseProjectDatabaseStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Supabase.OrganizationProjectsResponseProjectDatabaseStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
