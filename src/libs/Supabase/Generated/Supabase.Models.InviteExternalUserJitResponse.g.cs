
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InviteExternalUserJitResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("invite_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid InviteId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitResponseUserRole> UserRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteExternalUserJitResponse" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="inviteId"></param>
        /// <param name="userRoles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InviteExternalUserJitResponse(
            string email,
            global::System.Guid inviteId,
            global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitResponseUserRole> userRoles)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.InviteId = inviteId;
            this.UserRoles = userRoles ?? throw new global::System.ArgumentNullException(nameof(userRoles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteExternalUserJitResponse" /> class.
        /// </summary>
        public InviteExternalUserJitResponse()
        {
        }

    }
}