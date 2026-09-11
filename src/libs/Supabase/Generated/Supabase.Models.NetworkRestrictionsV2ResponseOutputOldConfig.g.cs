
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Populated when a new config has been received, but not registered as successfully applied to a project.
    /// </summary>
    public sealed partial class NetworkRestrictionsV2ResponseOutputOldConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbAllowedCidrs")]
        public global::System.Collections.Generic.IList<global::Supabase.NetworkRestrictionsV2ResponseOutputOldConfigDbAllowedCidr>? DbAllowedCidrs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsV2ResponseOutputOldConfig" /> class.
        /// </summary>
        /// <param name="dbAllowedCidrs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkRestrictionsV2ResponseOutputOldConfig(
            global::System.Collections.Generic.IList<global::Supabase.NetworkRestrictionsV2ResponseOutputOldConfigDbAllowedCidr>? dbAllowedCidrs)
        {
            this.DbAllowedCidrs = dbAllowedCidrs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsV2ResponseOutputOldConfig" /> class.
        /// </summary>
        public NetworkRestrictionsV2ResponseOutputOldConfig()
        {
        }

    }
}