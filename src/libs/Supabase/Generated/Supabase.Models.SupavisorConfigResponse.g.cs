
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SupavisorConfigResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.SupavisorConfigResponseDatabaseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.SupavisorConfigResponseDatabaseType DatabaseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_using_scram_auth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsUsingScramAuth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbUser { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("db_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_string")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionString { get; set; }

        /// <summary>
        /// Use connection_string instead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionString")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionString2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_pool_size")]
        public int? DefaultPoolSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_client_conn")]
        public int? MaxClientConn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.SupavisorConfigResponsePoolModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.SupavisorConfigResponsePoolMode PoolMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SupavisorConfigResponse" /> class.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="databaseType"></param>
        /// <param name="isUsingScramAuth"></param>
        /// <param name="dbUser"></param>
        /// <param name="dbHost"></param>
        /// <param name="dbPort"></param>
        /// <param name="dbName"></param>
        /// <param name="connectionString"></param>
        /// <param name="connectionString2">
        /// Use connection_string instead
        /// </param>
        /// <param name="poolMode"></param>
        /// <param name="defaultPoolSize"></param>
        /// <param name="maxClientConn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SupavisorConfigResponse(
            string identifier,
            global::Supabase.SupavisorConfigResponseDatabaseType databaseType,
            bool isUsingScramAuth,
            string dbUser,
            string dbHost,
            int dbPort,
            string dbName,
            string connectionString,
            string connectionString2,
            global::Supabase.SupavisorConfigResponsePoolMode poolMode,
            int? defaultPoolSize,
            int? maxClientConn)
        {
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.DatabaseType = databaseType;
            this.IsUsingScramAuth = isUsingScramAuth;
            this.DbUser = dbUser ?? throw new global::System.ArgumentNullException(nameof(dbUser));
            this.DbHost = dbHost ?? throw new global::System.ArgumentNullException(nameof(dbHost));
            this.DbPort = dbPort;
            this.DbName = dbName ?? throw new global::System.ArgumentNullException(nameof(dbName));
            this.ConnectionString = connectionString ?? throw new global::System.ArgumentNullException(nameof(connectionString));
            this.ConnectionString2 = connectionString2 ?? throw new global::System.ArgumentNullException(nameof(connectionString2));
            this.DefaultPoolSize = defaultPoolSize;
            this.MaxClientConn = maxClientConn;
            this.PoolMode = poolMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupavisorConfigResponse" /> class.
        /// </summary>
        public SupavisorConfigResponse()
        {
        }
    }
}