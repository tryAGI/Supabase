
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Present when a change that was never applied is waiting for review. `config` is the list the project enforces. Apply or reject the change with `POST /v1/projects/{ref}/network-restrictions/review`; submitting a new config also replaces it.<br/>
    /// Example: {"dbAllowedCidrs":["203.0.113.0/24"],"dbAllowedCidrsV6":["2001:db8::/32"]}
    /// </summary>
    public sealed partial class NetworkRestrictionsResponseOutputPendingConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbAllowedCidrs")]
        public global::System.Collections.Generic.IList<string>? DbAllowedCidrs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbAllowedCidrsV6")]
        public global::System.Collections.Generic.IList<string>? DbAllowedCidrsV6 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsResponseOutputPendingConfig" /> class.
        /// </summary>
        /// <param name="dbAllowedCidrs"></param>
        /// <param name="dbAllowedCidrsV6"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkRestrictionsResponseOutputPendingConfig(
            global::System.Collections.Generic.IList<string>? dbAllowedCidrs,
            global::System.Collections.Generic.IList<string>? dbAllowedCidrsV6)
        {
            this.DbAllowedCidrs = dbAllowedCidrs;
            this.DbAllowedCidrsV6 = dbAllowedCidrsV6;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsResponseOutputPendingConfig" /> class.
        /// </summary>
        public NetworkRestrictionsResponseOutputPendingConfig()
        {
        }

    }
}