
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"grant_type":"authorization_code","client_id":"66666666-6666-4666-8666-666666666666","client_secret":"sb_secret_live_example_9f4d3a206b2e4a7e8c91","code":"oauth_code_9f4d3a206b2e4a7e8c91","code_verifier":"qW0Z6d9pQnW0mL1dK1q9wFq6Yz2nV5rA8jT3mP7sH4c","redirect_uri":"https://app.acme.com/auth/callback","scope":"projects:read projects:write"}
    /// </summary>
    public sealed partial class OAuthTokenBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OAuthTokenBodyGrantTypeJsonConverter))]
        public global::Supabase.OAuthTokenBodyGrantType? GrantType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public global::System.Guid? ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_verifier")]
        public string? CodeVerifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        public string? RedirectUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// Resource indicator for MCP (Model Context Protocol) clients
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public string? Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthTokenBody" /> class.
        /// </summary>
        /// <param name="grantType"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="code"></param>
        /// <param name="codeVerifier"></param>
        /// <param name="redirectUri"></param>
        /// <param name="refreshToken"></param>
        /// <param name="resource">
        /// Resource indicator for MCP (Model Context Protocol) clients
        /// </param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuthTokenBody(
            global::Supabase.OAuthTokenBodyGrantType? grantType,
            global::System.Guid? clientId,
            string? clientSecret,
            string? code,
            string? codeVerifier,
            string? redirectUri,
            string? refreshToken,
            string? resource,
            string? scope)
        {
            this.GrantType = grantType;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.Code = code;
            this.CodeVerifier = codeVerifier;
            this.RedirectUri = redirectUri;
            this.RefreshToken = refreshToken;
            this.Resource = resource;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthTokenBody" /> class.
        /// </summary>
        public OAuthTokenBody()
        {
        }
    }
}