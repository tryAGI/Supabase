
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetUpReadReplicaBody
    {
        /// <summary>
        /// Region you want your read replica to reside in<br/>
        /// Example: us-east-1
        /// </summary>
        /// <example>us-east-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_replica_region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.SetUpReadReplicaBodyReadReplicaRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.SetUpReadReplicaBodyReadReplicaRegion ReadReplicaRegion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetUpReadReplicaBody" /> class.
        /// </summary>
        /// <param name="readReplicaRegion">
        /// Region you want your read replica to reside in<br/>
        /// Example: us-east-1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetUpReadReplicaBody(
            global::Supabase.SetUpReadReplicaBodyReadReplicaRegion readReplicaRegion)
        {
            this.ReadReplicaRegion = readReplicaRegion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetUpReadReplicaBody" /> class.
        /// </summary>
        public SetUpReadReplicaBody()
        {
        }
    }
}