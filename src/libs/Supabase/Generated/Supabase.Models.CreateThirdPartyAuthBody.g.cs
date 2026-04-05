
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateThirdPartyAuthBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidc_issuer_url")]
        public string? OidcIssuerUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_url")]
        public string? JwksUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_jwks")]
        public object? CustomJwks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThirdPartyAuthBody" /> class.
        /// </summary>
        /// <param name="oidcIssuerUrl"></param>
        /// <param name="jwksUrl"></param>
        /// <param name="customJwks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateThirdPartyAuthBody(
            string? oidcIssuerUrl,
            string? jwksUrl,
            object? customJwks)
        {
            this.OidcIssuerUrl = oidcIssuerUrl;
            this.JwksUrl = jwksUrl;
            this.CustomJwks = customJwks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThirdPartyAuthBody" /> class.
        /// </summary>
        public CreateThirdPartyAuthBody()
        {
        }
    }
}