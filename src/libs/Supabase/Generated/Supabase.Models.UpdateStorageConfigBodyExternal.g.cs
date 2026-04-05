
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateStorageConfigBodyExternal
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstreamTarget")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.UpdateStorageConfigBodyExternalUpstreamTargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.UpdateStorageConfigBodyExternalUpstreamTarget UpstreamTarget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStorageConfigBodyExternal" /> class.
        /// </summary>
        /// <param name="upstreamTarget"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateStorageConfigBodyExternal(
            global::Supabase.UpdateStorageConfigBodyExternalUpstreamTarget upstreamTarget)
        {
            this.UpstreamTarget = upstreamTarget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStorageConfigBodyExternal" /> class.
        /// </summary>
        public UpdateStorageConfigBodyExternal()
        {
        }
    }
}