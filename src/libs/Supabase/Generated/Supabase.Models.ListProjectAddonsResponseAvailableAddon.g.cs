
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectAddonsResponseAvailableAddon
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.ListProjectAddonsResponseAvailableAddonType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variants")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseAvailableAddonVariant> Variants { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseAvailableAddon" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="variants"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectAddonsResponseAvailableAddon(
            global::Supabase.ListProjectAddonsResponseAvailableAddonType type,
            string name,
            global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseAvailableAddonVariant> variants)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Variants = variants ?? throw new global::System.ArgumentNullException(nameof(variants));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseAvailableAddon" /> class.
        /// </summary>
        public ListProjectAddonsResponseAvailableAddon()
        {
        }

    }
}