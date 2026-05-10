
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"type":"saml","metadata_url":"https://sso.acme.com/metadata.xml","domains":["acme.com"],"attribute_mapping":{"keys":{"email":{"name":"email"},"first_name":{"name":"first_name"},"last_name":{"name":"last_name"}}}}
    /// </summary>
    public sealed partial class CreateProviderBody
    {
        /// <summary>
        /// What type of provider will be created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateProviderBodyTypeJsonConverter))]
        public global::Supabase.CreateProviderBodyType Type { get; set; }

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
        public global::Supabase.CreateProviderBodyAttributeMapping? AttributeMapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name_id_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateProviderBodyNameIdFormatJsonConverter))]
        public global::Supabase.CreateProviderBodyNameIdFormat? NameIdFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProviderBody" /> class.
        /// </summary>
        /// <param name="type">
        /// What type of provider will be created
        /// </param>
        /// <param name="metadataXml"></param>
        /// <param name="metadataUrl"></param>
        /// <param name="domains"></param>
        /// <param name="attributeMapping"></param>
        /// <param name="nameIdFormat"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProviderBody(
            global::Supabase.CreateProviderBodyType type,
            string? metadataXml,
            string? metadataUrl,
            global::System.Collections.Generic.IList<string>? domains,
            global::Supabase.CreateProviderBodyAttributeMapping? attributeMapping,
            global::Supabase.CreateProviderBodyNameIdFormat? nameIdFormat)
        {
            this.Type = type;
            this.MetadataXml = metadataXml;
            this.MetadataUrl = metadataUrl;
            this.Domains = domains;
            this.AttributeMapping = attributeMapping;
            this.NameIdFormat = nameIdFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProviderBody" /> class.
        /// </summary>
        public CreateProviderBody()
        {
        }

    }
}