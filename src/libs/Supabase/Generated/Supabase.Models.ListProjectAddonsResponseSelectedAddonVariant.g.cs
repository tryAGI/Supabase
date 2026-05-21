
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectAddonsResponseSelectedAddonVariant
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant1?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant2?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant3?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant4?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant5?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant6?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant7?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.OneOf<global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant1?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant2?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant3?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant4?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant5?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant6?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant7?> Id { get; set; }

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
        public required global::Supabase.ListProjectAddonsResponseSelectedAddonVariantPrice Price { get; set; }

        /// <summary>
        /// Any JSON-serializable value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseSelectedAddonVariant" /> class.
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
        public ListProjectAddonsResponseSelectedAddonVariant(
            global::Supabase.OneOf<global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant1?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant2?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant3?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant4?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant5?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant6?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant7?> id,
            string name,
            global::Supabase.ListProjectAddonsResponseSelectedAddonVariantPrice price,
            object? meta)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Price = price ?? throw new global::System.ArgumentNullException(nameof(price));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseSelectedAddonVariant" /> class.
        /// </summary>
        public ListProjectAddonsResponseSelectedAddonVariant()
        {
        }

    }
}