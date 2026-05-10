
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThirdPartyAuth
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_jwks")]
        public object? ResolvedJwks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inserted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InsertedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_at")]
        public string? ResolvedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyAuth" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="insertedAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="oidcIssuerUrl"></param>
        /// <param name="jwksUrl"></param>
        /// <param name="customJwks"></param>
        /// <param name="resolvedJwks"></param>
        /// <param name="resolvedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThirdPartyAuth(
            global::System.Guid id,
            string type,
            string insertedAt,
            string updatedAt,
            string? oidcIssuerUrl,
            string? jwksUrl,
            object? customJwks,
            object? resolvedJwks,
            string? resolvedAt)
        {
            this.Id = id;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.OidcIssuerUrl = oidcIssuerUrl;
            this.JwksUrl = jwksUrl;
            this.CustomJwks = customJwks;
            this.ResolvedJwks = resolvedJwks;
            this.InsertedAt = insertedAt ?? throw new global::System.ArgumentNullException(nameof(insertedAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.ResolvedAt = resolvedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyAuth" /> class.
        /// </summary>
        public ThirdPartyAuth()
        {
        }

    }
}