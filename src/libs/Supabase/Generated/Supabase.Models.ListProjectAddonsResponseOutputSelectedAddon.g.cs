
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListProjectAddonsResponseOutputSelectedAddon
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseOutputSelectedAddonTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.ListProjectAddonsResponseOutputSelectedAddonType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.ListProjectAddonsResponseOutputSelectedAddonVariant Variant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseOutputSelectedAddon" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="variant"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectAddonsResponseOutputSelectedAddon(
            global::Supabase.ListProjectAddonsResponseOutputSelectedAddonType type,
            global::Supabase.ListProjectAddonsResponseOutputSelectedAddonVariant variant)
        {
            this.Type = type;
            this.Variant = variant ?? throw new global::System.ArgumentNullException(nameof(variant));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseOutputSelectedAddon" /> class.
        /// </summary>
        public ListProjectAddonsResponseOutputSelectedAddon()
        {
        }

    }
}