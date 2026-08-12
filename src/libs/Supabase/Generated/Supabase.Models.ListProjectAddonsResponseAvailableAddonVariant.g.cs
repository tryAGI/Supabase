
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectAddonsResponseAvailableAddonVariant
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.AnyOfJsonConverter<global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant1?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant2?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant3?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant4?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant5?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant6?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant7?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant8?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.AnyOf<global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant1?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant2?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant3?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant4?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant5?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant6?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant7?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant8?> Id { get; set; }

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
        public required global::Supabase.ListProjectAddonsResponseAvailableAddonVariantPrice Price { get; set; }

        /// <summary>
        /// Any JSON-serializable value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseJsonValueJsonConverter))]
        public global::Supabase.ListProjectAddonsResponseJsonValue? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseAvailableAddonVariant" /> class.
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
        public ListProjectAddonsResponseAvailableAddonVariant(
            global::Supabase.AnyOf<global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant1?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant2?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant3?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant4?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant5?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant6?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant7?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant8?> id,
            string name,
            global::Supabase.ListProjectAddonsResponseAvailableAddonVariantPrice price,
            global::Supabase.ListProjectAddonsResponseJsonValue? meta)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Price = price ?? throw new global::System.ArgumentNullException(nameof(price));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseAvailableAddonVariant" /> class.
        /// </summary>
        public ListProjectAddonsResponseAvailableAddonVariant()
        {
        }

    }
}