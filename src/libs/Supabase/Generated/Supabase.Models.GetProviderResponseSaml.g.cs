
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProviderResponseSaml
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_url")]
        public string? MetadataUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_xml")]
        public string? MetadataXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute_mapping")]
        public global::Supabase.GetProviderResponseSamlAttributeMapping? AttributeMapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name_id_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.GetProviderResponseSamlNameIdFormatJsonConverter))]
        public global::Supabase.GetProviderResponseSamlNameIdFormat? NameIdFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProviderResponseSaml" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entityId"></param>
        /// <param name="metadataUrl"></param>
        /// <param name="metadataXml"></param>
        /// <param name="attributeMapping"></param>
        /// <param name="nameIdFormat"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProviderResponseSaml(
            string id,
            string entityId,
            string? metadataUrl,
            string? metadataXml,
            global::Supabase.GetProviderResponseSamlAttributeMapping? attributeMapping,
            global::Supabase.GetProviderResponseSamlNameIdFormat? nameIdFormat)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.MetadataUrl = metadataUrl;
            this.MetadataXml = metadataXml;
            this.AttributeMapping = attributeMapping;
            this.NameIdFormat = nameIdFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProviderResponseSaml" /> class.
        /// </summary>
        public GetProviderResponseSaml()
        {
        }

    }
}