
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NetworkRestrictionsV2ResponseConfigDbAllowedCidr
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseConfigDbAllowedCidrTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.NetworkRestrictionsV2ResponseConfigDbAllowedCidrType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsV2ResponseConfigDbAllowedCidr" /> class.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkRestrictionsV2ResponseConfigDbAllowedCidr(
            string address,
            global::Supabase.NetworkRestrictionsV2ResponseConfigDbAllowedCidrType type)
        {
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsV2ResponseConfigDbAllowedCidr" /> class.
        /// </summary>
        public NetworkRestrictionsV2ResponseConfigDbAllowedCidr()
        {
        }
    }
}