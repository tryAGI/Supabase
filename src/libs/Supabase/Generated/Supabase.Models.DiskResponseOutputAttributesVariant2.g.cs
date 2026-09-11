
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DiskResponseOutputAttributesVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iops")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Iops { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_gb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeGb { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.DiskResponseOutputAttributesVariant2TypeJsonConverter))]
        public global::Supabase.DiskResponseOutputAttributesVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskResponseOutputAttributesVariant2" /> class.
        /// </summary>
        /// <param name="iops"></param>
        /// <param name="sizeGb"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiskResponseOutputAttributesVariant2(
            long iops,
            long sizeGb,
            global::Supabase.DiskResponseOutputAttributesVariant2Type type)
        {
            this.Iops = iops;
            this.SizeGb = sizeGb;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskResponseOutputAttributesVariant2" /> class.
        /// </summary>
        public DiskResponseOutputAttributesVariant2()
        {
        }

    }
}