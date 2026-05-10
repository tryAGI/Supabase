
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1ProjectWithDatabaseResponseDatabase
    {
        /// <summary>
        /// Database host
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        /// Database version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Database engine
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postgres_engine")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PostgresEngine { get; set; }

        /// <summary>
        /// Release channel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_channel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReleaseChannel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ProjectWithDatabaseResponseDatabase" /> class.
        /// </summary>
        /// <param name="host">
        /// Database host
        /// </param>
        /// <param name="version">
        /// Database version
        /// </param>
        /// <param name="postgresEngine">
        /// Database engine
        /// </param>
        /// <param name="releaseChannel">
        /// Release channel
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ProjectWithDatabaseResponseDatabase(
            string host,
            string version,
            string postgresEngine,
            string releaseChannel)
        {
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.PostgresEngine = postgresEngine ?? throw new global::System.ArgumentNullException(nameof(postgresEngine));
            this.ReleaseChannel = releaseChannel ?? throw new global::System.ArgumentNullException(nameof(releaseChannel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ProjectWithDatabaseResponseDatabase" /> class.
        /// </summary>
        public V1ProjectWithDatabaseResponseDatabase()
        {
        }

    }
}