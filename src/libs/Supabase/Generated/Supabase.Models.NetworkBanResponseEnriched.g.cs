
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NetworkBanResponseEnriched
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("banned_ipv4_addresses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.NetworkBanResponseEnrichedBannedIpv4Addresse> BannedIpv4Addresses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkBanResponseEnriched" /> class.
        /// </summary>
        /// <param name="bannedIpv4Addresses"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkBanResponseEnriched(
            global::System.Collections.Generic.IList<global::Supabase.NetworkBanResponseEnrichedBannedIpv4Addresse> bannedIpv4Addresses)
        {
            this.BannedIpv4Addresses = bannedIpv4Addresses ?? throw new global::System.ArgumentNullException(nameof(bannedIpv4Addresses));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkBanResponseEnriched" /> class.
        /// </summary>
        public NetworkBanResponseEnriched()
        {
        }
    }
}