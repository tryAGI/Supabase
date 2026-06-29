
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"email":"external-user@somedomain.xyz","roles":[{"role":"postgres","expires_at":1740787200,"allowed_networks":{"allowed_cidrs":[{"cidr":"203.0.113.0/24"}]},"branches_only":false}]}
    /// </summary>
    public sealed partial class InviteExternalUserJitAccessBody
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
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitAccessBodyRole> Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteExternalUserJitAccessBody" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="roles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InviteExternalUserJitAccessBody(
            string email,
            global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitAccessBodyRole> roles)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Roles = roles ?? throw new global::System.ArgumentNullException(nameof(roles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteExternalUserJitAccessBody" /> class.
        /// </summary>
        public InviteExternalUserJitAccessBody()
        {
        }

    }
}