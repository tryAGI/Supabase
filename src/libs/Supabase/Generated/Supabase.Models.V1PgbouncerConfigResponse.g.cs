
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1PgbouncerConfigResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_pool_size")]
        public long? DefaultPoolSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_startup_parameters")]
        public string? IgnoreStartupParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_client_conn")]
        public long? MaxClientConn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1PgbouncerConfigResponsePoolModeJsonConverter))]
        public global::Supabase.V1PgbouncerConfigResponsePoolMode? PoolMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_string")]
        public string? ConnectionString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_idle_timeout")]
        public long? ServerIdleTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_lifetime")]
        public long? ServerLifetime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_wait_timeout")]
        public long? QueryWaitTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reserve_pool_size")]
        public long? ReservePoolSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1PgbouncerConfigResponse" /> class.
        /// </summary>
        /// <param name="defaultPoolSize"></param>
        /// <param name="ignoreStartupParameters"></param>
        /// <param name="maxClientConn"></param>
        /// <param name="poolMode"></param>
        /// <param name="connectionString"></param>
        /// <param name="serverIdleTimeout"></param>
        /// <param name="serverLifetime"></param>
        /// <param name="queryWaitTimeout"></param>
        /// <param name="reservePoolSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1PgbouncerConfigResponse(
            long? defaultPoolSize,
            string? ignoreStartupParameters,
            long? maxClientConn,
            global::Supabase.V1PgbouncerConfigResponsePoolMode? poolMode,
            string? connectionString,
            long? serverIdleTimeout,
            long? serverLifetime,
            long? queryWaitTimeout,
            long? reservePoolSize)
        {
            this.DefaultPoolSize = defaultPoolSize;
            this.IgnoreStartupParameters = ignoreStartupParameters;
            this.MaxClientConn = maxClientConn;
            this.PoolMode = poolMode;
            this.ConnectionString = connectionString;
            this.ServerIdleTimeout = serverIdleTimeout;
            this.ServerLifetime = serverLifetime;
            this.QueryWaitTimeout = queryWaitTimeout;
            this.ReservePoolSize = reservePoolSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1PgbouncerConfigResponse" /> class.
        /// </summary>
        public V1PgbouncerConfigResponse()
        {
        }

    }
}