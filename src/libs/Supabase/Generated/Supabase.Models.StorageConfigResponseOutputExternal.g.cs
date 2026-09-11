
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StorageConfigResponseOutputExternal
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstreamTarget")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.StorageConfigResponseOutputExternalUpstreamTargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.StorageConfigResponseOutputExternalUpstreamTarget UpstreamTarget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponseOutputExternal" /> class.
        /// </summary>
        /// <param name="upstreamTarget"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageConfigResponseOutputExternal(
            global::Supabase.StorageConfigResponseOutputExternalUpstreamTarget upstreamTarget)
        {
            this.UpstreamTarget = upstreamTarget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageConfigResponseOutputExternal" /> class.
        /// </summary>
        public StorageConfigResponseOutputExternal()
        {
        }

    }
}