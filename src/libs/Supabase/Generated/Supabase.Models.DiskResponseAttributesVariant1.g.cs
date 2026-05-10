
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiskResponseAttributesVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iops")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Iops { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_gb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SizeGb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("throughput_mibps")]
        public int? ThroughputMibps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.DiskResponseAttributesVariant1TypeJsonConverter))]
        public global::Supabase.DiskResponseAttributesVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskResponseAttributesVariant1" /> class.
        /// </summary>
        /// <param name="iops"></param>
        /// <param name="sizeGb"></param>
        /// <param name="throughputMibps"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiskResponseAttributesVariant1(
            int iops,
            int sizeGb,
            int? throughputMibps,
            global::Supabase.DiskResponseAttributesVariant1Type type)
        {
            this.Iops = iops;
            this.SizeGb = sizeGb;
            this.ThroughputMibps = throughputMibps;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskResponseAttributesVariant1" /> class.
        /// </summary>
        public DiskResponseAttributesVariant1()
        {
        }

    }
}