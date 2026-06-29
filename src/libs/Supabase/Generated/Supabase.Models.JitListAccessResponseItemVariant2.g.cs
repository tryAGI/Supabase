
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JitListAccessResponseItemVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public object? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrimaryEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid InviteId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseItemVariant2UserRole> UserRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JitListAccessResponseItemVariant2" /> class.
        /// </summary>
        /// <param name="primaryEmail"></param>
        /// <param name="inviteId"></param>
        /// <param name="expiresAt"></param>
        /// <param name="userRoles"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JitListAccessResponseItemVariant2(
            string primaryEmail,
            global::System.Guid inviteId,
            string expiresAt,
            global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseItemVariant2UserRole> userRoles,
            object? userId)
        {
            this.UserId = userId;
            this.PrimaryEmail = primaryEmail ?? throw new global::System.ArgumentNullException(nameof(primaryEmail));
            this.InviteId = inviteId;
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
            this.UserRoles = userRoles ?? throw new global::System.ArgumentNullException(nameof(userRoles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JitListAccessResponseItemVariant2" /> class.
        /// </summary>
        public JitListAccessResponseItemVariant2()
        {
        }

    }
}