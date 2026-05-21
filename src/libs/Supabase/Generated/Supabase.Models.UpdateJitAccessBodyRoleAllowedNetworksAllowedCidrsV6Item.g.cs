
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cidr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cidr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item" /> class.
        /// </summary>
        /// <param name="cidr"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item(
            string cidr)
        {
            this.Cidr = cidr ?? throw new global::System.ArgumentNullException(nameof(cidr));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item" /> class.
        /// </summary>
        public UpdateJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item()
        {
        }

    }
}