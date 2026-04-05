
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectAddonsResponseSelectedAddon
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.ListProjectAddonsResponseSelectedAddonType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.ListProjectAddonsResponseSelectedAddonVariant Variant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseSelectedAddon" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="variant"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectAddonsResponseSelectedAddon(
            global::Supabase.ListProjectAddonsResponseSelectedAddonType type,
            global::Supabase.ListProjectAddonsResponseSelectedAddonVariant variant)
        {
            this.Type = type;
            this.Variant = variant ?? throw new global::System.ArgumentNullException(nameof(variant));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseSelectedAddon" /> class.
        /// </summary>
        public ListProjectAddonsResponseSelectedAddon()
        {
        }
    }
}