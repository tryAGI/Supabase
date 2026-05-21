
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"client_id":"66666666-6666-4666-8666-666666666666","client_secret":"sb_secret_live_example_9f4d3a206b2e4a7e8c91","refresh_token":"oauth_refresh_9f4d3a206b2e4a7e8c91"}
    /// </summary>
    public sealed partial class OAuthRevokeTokenBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RefreshToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthRevokeTokenBody" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="refreshToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuthRevokeTokenBody(
            global::System.Guid clientId,
            string clientSecret,
            string refreshToken)
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.RefreshToken = refreshToken ?? throw new global::System.ArgumentNullException(nameof(refreshToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthRevokeTokenBody" /> class.
        /// </summary>
        public OAuthRevokeTokenBody()
        {
        }

    }
}