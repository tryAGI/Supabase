
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1ServiceHealthResponseInfoVariant2
    {
        /// <summary>
        /// Deprecated. Use `status` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("healthy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Healthy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_connected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DbConnected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replication_connected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ReplicationConnected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_cluster")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConnectedCluster { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ServiceHealthResponseInfoVariant2" /> class.
        /// </summary>
        /// <param name="healthy">
        /// Deprecated. Use `status` instead.
        /// </param>
        /// <param name="dbConnected"></param>
        /// <param name="replicationConnected"></param>
        /// <param name="connectedCluster"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ServiceHealthResponseInfoVariant2(
            bool healthy,
            bool dbConnected,
            bool replicationConnected,
            int connectedCluster)
        {
            this.Healthy = healthy;
            this.DbConnected = dbConnected;
            this.ReplicationConnected = replicationConnected;
            this.ConnectedCluster = connectedCluster;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ServiceHealthResponseInfoVariant2" /> class.
        /// </summary>
        public V1ServiceHealthResponseInfoVariant2()
        {
        }

    }
}