#nullable enable

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel>
    {
        /// <inheritdoc />
        public override global::Supabase.ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel Read(
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
                        return global::Supabase.ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannelExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Supabase.ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Supabase.ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Supabase.ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannelExtensions.ToValueString(value));
        }
    }
}
