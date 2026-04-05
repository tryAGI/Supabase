
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1GetUsageApiCountResponseResultItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_auth_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalAuthRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_realtime_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalRealtimeRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_rest_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalRestRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_storage_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalStorageRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1GetUsageApiCountResponseResultItem" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="totalAuthRequests"></param>
        /// <param name="totalRealtimeRequests"></param>
        /// <param name="totalRestRequests"></param>
        /// <param name="totalStorageRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1GetUsageApiCountResponseResultItem(
            global::System.DateTime timestamp,
            double totalAuthRequests,
            double totalRealtimeRequests,
            double totalRestRequests,
            double totalStorageRequests)
        {
            this.Timestamp = timestamp;
            this.TotalAuthRequests = totalAuthRequests;
            this.TotalRealtimeRequests = totalRealtimeRequests;
            this.TotalRestRequests = totalRestRequests;
            this.TotalStorageRequests = totalStorageRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1GetUsageApiCountResponseResultItem" /> class.
        /// </summary>
        public V1GetUsageApiCountResponseResultItem()
        {
        }
    }
}