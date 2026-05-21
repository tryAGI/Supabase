
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Populated when a new config has been received, but not registered as successfully applied to a project.
    /// </summary>
    public sealed partial class NetworkRestrictionsV2ResponseOldConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbAllowedCidrs")]
        public global::System.Collections.Generic.IList<global::Supabase.NetworkRestrictionsV2ResponseOldConfigDbAllowedCidr>? DbAllowedCidrs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsV2ResponseOldConfig" /> class.
        /// </summary>
        /// <param name="dbAllowedCidrs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkRestrictionsV2ResponseOldConfig(
            global::System.Collections.Generic.IList<global::Supabase.NetworkRestrictionsV2ResponseOldConfigDbAllowedCidr>? dbAllowedCidrs)
        {
            this.DbAllowedCidrs = dbAllowedCidrs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsV2ResponseOldConfig" /> class.
        /// </summary>
        public NetworkRestrictionsV2ResponseOldConfig()
        {
        }

    }
}