
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUpgradeEligibilityResponseTargetUpgradeVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postgres_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion PostgresVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel ReleaseChannel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseTargetUpgradeVersion" /> class.
        /// </summary>
        /// <param name="postgresVersion"></param>
        /// <param name="releaseChannel"></param>
        /// <param name="appVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUpgradeEligibilityResponseTargetUpgradeVersion(
            global::Supabase.ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion postgresVersion,
            global::Supabase.ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel releaseChannel,
            string appVersion)
        {
            this.PostgresVersion = postgresVersion;
            this.ReleaseChannel = releaseChannel;
            this.AppVersion = appVersion ?? throw new global::System.ArgumentNullException(nameof(appVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseTargetUpgradeVersion" /> class.
        /// </summary>
        public ProjectUpgradeEligibilityResponseTargetUpgradeVersion()
        {
        }
    }
}