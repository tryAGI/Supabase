
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JitAccessResponseUserRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public double? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_networks")]
        public global::Supabase.JitAccessResponseUserRoleAllowedNetworks? AllowedNetworks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JitAccessResponseUserRole" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="expiresAt"></param>
        /// <param name="allowedNetworks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JitAccessResponseUserRole(
            string role,
            double? expiresAt,
            global::Supabase.JitAccessResponseUserRoleAllowedNetworks? allowedNetworks)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.ExpiresAt = expiresAt;
            this.AllowedNetworks = allowedNetworks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JitAccessResponseUserRole" /> class.
        /// </summary>
        public JitAccessResponseUserRole()
        {
        }
    }
}