
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectAvailableRestoreVersionsResponseAvailableVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel ReleaseChannel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postgres_engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngineJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine PostgresEngine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectAvailableRestoreVersionsResponseAvailableVersion" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="releaseChannel"></param>
        /// <param name="postgresEngine"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectAvailableRestoreVersionsResponseAvailableVersion(
            string version,
            global::Supabase.GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel releaseChannel,
            global::Supabase.GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine postgresEngine)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.ReleaseChannel = releaseChannel;
            this.PostgresEngine = postgresEngine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectAvailableRestoreVersionsResponseAvailableVersion" /> class.
        /// </summary>
        public GetProjectAvailableRestoreVersionsResponseAvailableVersion()
        {
        }
    }
}