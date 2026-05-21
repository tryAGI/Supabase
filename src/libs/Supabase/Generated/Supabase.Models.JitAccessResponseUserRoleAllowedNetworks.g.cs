
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JitAccessResponseUserRoleAllowedNetworks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_cidrs")]
        public global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseUserRoleAllowedNetworksAllowedCidr>? AllowedCidrs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_cidrs_v6")]
        public global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseUserRoleAllowedNetworksAllowedCidrsV6Item>? AllowedCidrsV6 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JitAccessResponseUserRoleAllowedNetworks" /> class.
        /// </summary>
        /// <param name="allowedCidrs"></param>
        /// <param name="allowedCidrsV6"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JitAccessResponseUserRoleAllowedNetworks(
            global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseUserRoleAllowedNetworksAllowedCidr>? allowedCidrs,
            global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseUserRoleAllowedNetworksAllowedCidrsV6Item>? allowedCidrsV6)
        {
            this.AllowedCidrs = allowedCidrs;
            this.AllowedCidrsV6 = allowedCidrsV6;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JitAccessResponseUserRoleAllowedNetworks" /> class.
        /// </summary>
        public JitAccessResponseUserRoleAllowedNetworks()
        {
        }

    }
}