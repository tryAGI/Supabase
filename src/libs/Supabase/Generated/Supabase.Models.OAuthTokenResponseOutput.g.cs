
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OAuthTokenResponseOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// The `urn:ietf:params:oauth:grant-type:jwt-bearer` grant type issues access tokens only, no refresh token is returned and the token cannot be revoked via `/v1/oauth/revoke`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ExpiresIn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OAuthTokenResponseOutputTokenTypeJsonConverter))]
        public global::Supabase.OAuthTokenResponseOutputTokenType TokenType { get; set; }

        /// <summary>
        /// Space-delimited scopes granted to the token. Omitted when no scopes were granted.<br/>
        /// Example: projects:read projects:write
        /// </summary>
        /// <example>projects:read projects:write</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Project refs the token is limited to. `null` means all projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_refs")]
        public global::System.Collections.Generic.IList<string>? ProjectRefs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthTokenResponseOutput" /> class.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="expiresIn"></param>
        /// <param name="refreshToken">
        /// The `urn:ietf:params:oauth:grant-type:jwt-bearer` grant type issues access tokens only, no refresh token is returned and the token cannot be revoked via `/v1/oauth/revoke`.
        /// </param>
        /// <param name="tokenType"></param>
        /// <param name="scope">
        /// Space-delimited scopes granted to the token. Omitted when no scopes were granted.<br/>
        /// Example: projects:read projects:write
        /// </param>
        /// <param name="projectRefs">
        /// Project refs the token is limited to. `null` means all projects.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuthTokenResponseOutput(
            string accessToken,
            long expiresIn,
            string? refreshToken,
            global::Supabase.OAuthTokenResponseOutputTokenType tokenType,
            string? scope,
            global::System.Collections.Generic.IList<string>? projectRefs)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.RefreshToken = refreshToken;
            this.ExpiresIn = expiresIn;
            this.TokenType = tokenType;
            this.Scope = scope;
            this.ProjectRefs = projectRefs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthTokenResponseOutput" /> class.
        /// </summary>
        public OAuthTokenResponseOutput()
        {
        }

    }
}