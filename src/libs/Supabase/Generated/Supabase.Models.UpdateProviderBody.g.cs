
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"metadata_url":"https://sso.acme.com/metadata.xml","domains":["acme.com","contractors.acme.com"]}
    /// </summary>
    public sealed partial class UpdateProviderBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_xml")]
        public string? MetadataXml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_url")]
        public string? MetadataUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::System.Collections.Generic.IList<string>? Domains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute_mapping")]
        public global::Supabase.UpdateProviderBodyAttributeMapping? AttributeMapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name_id_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.UpdateProviderBodyNameIdFormatJsonConverter))]
        public global::Supabase.UpdateProviderBodyNameIdFormat? NameIdFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProviderBody" /> class.
        /// </summary>
        /// <param name="metadataXml"></param>
        /// <param name="metadataUrl"></param>
        /// <param name="domains"></param>
        /// <param name="attributeMapping"></param>
        /// <param name="nameIdFormat"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProviderBody(
            string? metadataXml,
            string? metadataUrl,
            global::System.Collections.Generic.IList<string>? domains,
            global::Supabase.UpdateProviderBodyAttributeMapping? attributeMapping,
            global::Supabase.UpdateProviderBodyNameIdFormat? nameIdFormat)
        {
            this.MetadataXml = metadataXml;
            this.MetadataUrl = metadataUrl;
            this.Domains = domains;
            this.AttributeMapping = attributeMapping;
            this.NameIdFormat = nameIdFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProviderBody" /> class.
        /// </summary>
        public UpdateProviderBody()
        {
        }
    }
}