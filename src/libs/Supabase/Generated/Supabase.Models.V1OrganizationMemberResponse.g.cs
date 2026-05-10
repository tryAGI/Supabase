
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1OrganizationMemberResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfa_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MfaEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1OrganizationMemberResponse" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        /// <param name="roleName"></param>
        /// <param name="mfaEnabled"></param>
        /// <param name="email"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1OrganizationMemberResponse(
            string userId,
            string userName,
            string roleName,
            bool mfaEnabled,
            string? email)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.Email = email;
            this.RoleName = roleName ?? throw new global::System.ArgumentNullException(nameof(roleName));
            this.MfaEnabled = mfaEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1OrganizationMemberResponse" /> class.
        /// </summary>
        public V1OrganizationMemberResponse()
        {
        }

    }
}