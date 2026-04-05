#nullable enable

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public sealed class DatabaseUpgradeStatusResponseDatabaseUpgradeStatusErrorNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError?>
    {
        /// <inheritdoc />
        public override global::Supabase.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError? Read(
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
                        return global::Supabase.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusErrorExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Supabase.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Supabase.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Supabase.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusErrorExtensions.ToValueString(value.Value));
            }
        }
    }
}
