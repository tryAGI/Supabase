
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JitListAccessResponseItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_email")]
        public string? PrimaryEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite_id")]
        public object? InviteId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public object? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseItemVariant1UserRole> UserRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JitListAccessResponseItemVariant1" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userRoles"></param>
        /// <param name="primaryEmail"></param>
        /// <param name="inviteId"></param>
        /// <param name="expiresAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JitListAccessResponseItemVariant1(
            global::System.Guid userId,
            global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseItemVariant1UserRole> userRoles,
            string? primaryEmail,
            object? inviteId,
            object? expiresAt)
        {
            this.UserId = userId;
            this.PrimaryEmail = primaryEmail;
            this.InviteId = inviteId;
            this.ExpiresAt = expiresAt;
            this.UserRoles = userRoles ?? throw new global::System.ArgumentNullException(nameof(userRoles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JitListAccessResponseItemVariant1" /> class.
        /// </summary>
        public JitListAccessResponseItemVariant1()
        {
        }

    }
}