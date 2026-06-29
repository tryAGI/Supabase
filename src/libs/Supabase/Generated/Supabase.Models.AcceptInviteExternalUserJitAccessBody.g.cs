
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"email":"external-user@somedomain.xyz","token":""}
    /// </summary>
    public sealed partial class AcceptInviteExternalUserJitAccessBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptInviteExternalUserJitAccessBody" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptInviteExternalUserJitAccessBody(
            string email,
            string token)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptInviteExternalUserJitAccessBody" /> class.
        /// </summary>
        public AcceptInviteExternalUserJitAccessBody()
        {
        }

    }
}