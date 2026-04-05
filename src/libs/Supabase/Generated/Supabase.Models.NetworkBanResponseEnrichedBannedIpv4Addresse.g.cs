
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NetworkBanResponseEnrichedBannedIpv4Addresse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("banned_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BannedAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkBanResponseEnrichedBannedIpv4Addresse" /> class.
        /// </summary>
        /// <param name="bannedAddress"></param>
        /// <param name="identifier"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkBanResponseEnrichedBannedIpv4Addresse(
            string bannedAddress,
            string identifier,
            string type)
        {
            this.BannedAddress = bannedAddress ?? throw new global::System.ArgumentNullException(nameof(bannedAddress));
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkBanResponseEnrichedBannedIpv4Addresse" /> class.
        /// </summary>
        public NetworkBanResponseEnrichedBannedIpv4Addresse()
        {
        }
    }
}