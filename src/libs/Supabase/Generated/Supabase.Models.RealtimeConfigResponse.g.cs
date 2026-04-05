
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeConfigResponse
    {
        /// <summary>
        /// Whether to only allow private channels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_only")]
        public bool? PrivateOnly { get; set; }

        /// <summary>
        /// Sets connection pool size for Realtime Authorization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_pool")]
        public int? ConnectionPool { get; set; }

        /// <summary>
        /// Sets maximum number of concurrent users rate limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_users")]
        public int? MaxConcurrentUsers { get; set; }

        /// <summary>
        /// Sets maximum number of events per second rate per channel limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_events_per_second")]
        public int? MaxEventsPerSecond { get; set; }

        /// <summary>
        /// Sets maximum number of bytes per second rate per channel limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_bytes_per_second")]
        public long? MaxBytesPerSecond { get; set; }

        /// <summary>
        /// Sets maximum number of channels per client rate limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_channels_per_client")]
        public int? MaxChannelsPerClient { get; set; }

        /// <summary>
        /// Sets maximum number of joins per second rate limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_joins_per_second")]
        public int? MaxJoinsPerSecond { get; set; }

        /// <summary>
        /// Sets maximum number of presence events per second rate limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_presence_events_per_second")]
        public int? MaxPresenceEventsPerSecond { get; set; }

        /// <summary>
        /// Sets maximum number of payload size in KB rate limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_payload_size_in_kb")]
        public int? MaxPayloadSizeInKb { get; set; }

        /// <summary>
        /// Disables the Realtime service for this project when true. Set to false to re-enable it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspend")]
        public bool? Suspend { get; set; }

        /// <summary>
        /// Whether to enable presence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PresenceEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConfigResponse" /> class.
        /// </summary>
        /// <param name="presenceEnabled">
        /// Whether to enable presence
        /// </param>
        /// <param name="privateOnly">
        /// Whether to only allow private channels
        /// </param>
        /// <param name="connectionPool">
        /// Sets connection pool size for Realtime Authorization
        /// </param>
        /// <param name="maxConcurrentUsers">
        /// Sets maximum number of concurrent users rate limit
        /// </param>
        /// <param name="maxEventsPerSecond">
        /// Sets maximum number of events per second rate per channel limit
        /// </param>
        /// <param name="maxBytesPerSecond">
        /// Sets maximum number of bytes per second rate per channel limit
        /// </param>
        /// <param name="maxChannelsPerClient">
        /// Sets maximum number of channels per client rate limit
        /// </param>
        /// <param name="maxJoinsPerSecond">
        /// Sets maximum number of joins per second rate limit
        /// </param>
        /// <param name="maxPresenceEventsPerSecond">
        /// Sets maximum number of presence events per second rate limit
        /// </param>
        /// <param name="maxPayloadSizeInKb">
        /// Sets maximum number of payload size in KB rate limit
        /// </param>
        /// <param name="suspend">
        /// Disables the Realtime service for this project when true. Set to false to re-enable it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConfigResponse(
            bool presenceEnabled,
            bool? privateOnly,
            int? connectionPool,
            int? maxConcurrentUsers,
            int? maxEventsPerSecond,
            long? maxBytesPerSecond,
            int? maxChannelsPerClient,
            int? maxJoinsPerSecond,
            int? maxPresenceEventsPerSecond,
            int? maxPayloadSizeInKb,
            bool? suspend)
        {
            this.PrivateOnly = privateOnly;
            this.ConnectionPool = connectionPool;
            this.MaxConcurrentUsers = maxConcurrentUsers;
            this.MaxEventsPerSecond = maxEventsPerSecond;
            this.MaxBytesPerSecond = maxBytesPerSecond;
            this.MaxChannelsPerClient = maxChannelsPerClient;
            this.MaxJoinsPerSecond = maxJoinsPerSecond;
            this.MaxPresenceEventsPerSecond = maxPresenceEventsPerSecond;
            this.MaxPayloadSizeInKb = maxPayloadSizeInKb;
            this.Suspend = suspend;
            this.PresenceEnabled = presenceEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConfigResponse" /> class.
        /// </summary>
        public RealtimeConfigResponse()
        {
        }
    }
}