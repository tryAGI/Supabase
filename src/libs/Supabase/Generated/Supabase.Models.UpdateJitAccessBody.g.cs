
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"user_id":"55555555-5555-4555-8555-555555555555","roles":[{"role":"postgres","expires_at":1740787200,"allowed_networks":{"allowed_cidrs":[{"cidr":"203.0.113.0/24"}]}}]}
    /// </summary>
    public sealed partial class UpdateJitAccessBody
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
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.UpdateJitAccessBodyRole> Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateJitAccessBody" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateJitAccessBody(
            global::System.Guid userId,
            global::System.Collections.Generic.IList<global::Supabase.UpdateJitAccessBodyRole> roles)
        {
            this.UserId = userId;
            this.Roles = roles ?? throw new global::System.ArgumentNullException(nameof(roles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateJitAccessBody" /> class.
        /// </summary>
        public UpdateJitAccessBody()
        {
        }
    }
}