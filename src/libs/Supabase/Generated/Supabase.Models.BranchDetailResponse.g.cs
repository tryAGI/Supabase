
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchDetailResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postgres_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PostgresVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postgres_engine")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PostgresEngine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_channel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReleaseChannel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.BranchDetailResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.BranchDetailResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbHost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_port")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DbPort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_user")]
        public string? DbUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_pass")]
        public string? DbPass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwt_secret")]
        public string? JwtSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchDetailResponse" /> class.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="postgresVersion"></param>
        /// <param name="postgresEngine"></param>
        /// <param name="releaseChannel"></param>
        /// <param name="status"></param>
        /// <param name="dbHost"></param>
        /// <param name="dbPort"></param>
        /// <param name="dbUser"></param>
        /// <param name="dbPass"></param>
        /// <param name="jwtSecret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchDetailResponse(
            string @ref,
            string postgresVersion,
            string postgresEngine,
            string releaseChannel,
            global::Supabase.BranchDetailResponseStatus status,
            string dbHost,
            int dbPort,
            string? dbUser,
            string? dbPass,
            string? jwtSecret)
        {
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.PostgresVersion = postgresVersion ?? throw new global::System.ArgumentNullException(nameof(postgresVersion));
            this.PostgresEngine = postgresEngine ?? throw new global::System.ArgumentNullException(nameof(postgresEngine));
            this.ReleaseChannel = releaseChannel ?? throw new global::System.ArgumentNullException(nameof(releaseChannel));
            this.Status = status;
            this.DbHost = dbHost ?? throw new global::System.ArgumentNullException(nameof(dbHost));
            this.DbPort = dbPort;
            this.DbUser = dbUser;
            this.DbPass = dbPass;
            this.JwtSecret = jwtSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchDetailResponse" /> class.
        /// </summary>
        public BranchDetailResponse()
        {
        }
    }
}