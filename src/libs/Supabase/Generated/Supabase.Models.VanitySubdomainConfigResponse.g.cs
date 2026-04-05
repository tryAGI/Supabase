
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VanitySubdomainConfigResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.VanitySubdomainConfigResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.VanitySubdomainConfigResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_domain")]
        public string? CustomDomain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VanitySubdomainConfigResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="customDomain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VanitySubdomainConfigResponse(
            global::Supabase.VanitySubdomainConfigResponseStatus status,
            string? customDomain)
        {
            this.Status = status;
            this.CustomDomain = customDomain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VanitySubdomainConfigResponse" /> class.
        /// </summary>
        public VanitySubdomainConfigResponse()
        {
        }
    }
}