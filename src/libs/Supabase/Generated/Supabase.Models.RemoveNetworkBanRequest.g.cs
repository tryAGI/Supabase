
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"ipv4_addresses":["203.0.113.10"],"requester_ip":false}
    /// </summary>
    public sealed partial class RemoveNetworkBanRequest
    {
        /// <summary>
        /// List of IP addresses to unban.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipv4_addresses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ipv4Addresses { get; set; }

        /// <summary>
        /// Include requester's public IP in the list of addresses to unban.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requester_ip")]
        public bool? RequesterIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveNetworkBanRequest" /> class.
        /// </summary>
        /// <param name="ipv4Addresses">
        /// List of IP addresses to unban.
        /// </param>
        /// <param name="requesterIp">
        /// Include requester's public IP in the list of addresses to unban.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="identifier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveNetworkBanRequest(
            global::System.Collections.Generic.IList<string> ipv4Addresses,
            bool? requesterIp,
            string? identifier)
        {
            this.Ipv4Addresses = ipv4Addresses ?? throw new global::System.ArgumentNullException(nameof(ipv4Addresses));
            this.RequesterIp = requesterIp;
            this.Identifier = identifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveNetworkBanRequest" /> class.
        /// </summary>
        public RemoveNetworkBanRequest()
        {
        }

    }
}