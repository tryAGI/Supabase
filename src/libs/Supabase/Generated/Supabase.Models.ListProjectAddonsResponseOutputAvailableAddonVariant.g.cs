
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListProjectAddonsResponseOutputAvailableAddonVariant
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.AnyOfJsonConverter<global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant1?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant2?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant3?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant4?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant5?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant6?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant7?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant8?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.AnyOf<global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant1?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant2?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant3?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant4?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant5?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant6?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant7?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant8?> Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantPrice Price { get; set; }

        /// <summary>
        /// Any JSON-serializable value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.JsonValueOutputJsonConverter))]
        public global::Supabase.JsonValueOutput? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseOutputAvailableAddonVariant" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="meta">
        /// Any JSON-serializable value
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectAddonsResponseOutputAvailableAddonVariant(
            global::Supabase.AnyOf<global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant1?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant2?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant3?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant4?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant5?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant6?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant7?, global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant8?> id,
            string name,
            global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantPrice price,
            global::Supabase.JsonValueOutput? meta)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Price = price ?? throw new global::System.ArgumentNullException(nameof(price));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseOutputAvailableAddonVariant" /> class.
        /// </summary>
        public ListProjectAddonsResponseOutputAvailableAddonVariant()
        {
        }

    }
}