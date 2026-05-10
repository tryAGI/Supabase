
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"attributes":{"type":"gp3","size_gb":100,"iops":3000,"throughput_mibps":125}}
    /// </summary>
    public sealed partial class DiskRequestBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.Attributes2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.Attributes2 Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskRequestBody" /> class.
        /// </summary>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiskRequestBody(
            global::Supabase.Attributes2 attributes)
        {
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskRequestBody" /> class.
        /// </summary>
        public DiskRequestBody()
        {
        }

    }
}