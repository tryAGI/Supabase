
#nullable enable

namespace Supabase
{
    /// <summary>
    /// At any given point in time, this is the config that the user has requested be applied to their project. The `status` field indicates if it has been applied to the project, or is pending. When an updated config is received, the applied config is moved to `old_config`.
    /// </summary>
    public sealed partial class NetworkRestrictionsV2ResponseConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dbAllowedCidrs")]
        public global::System.Collections.Generic.IList<global::Supabase.NetworkRestrictionsV2ResponseConfigDbAllowedCidr>? DbAllowedCidrs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsV2ResponseConfig" /> class.
        /// </summary>
        /// <param name="dbAllowedCidrs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkRestrictionsV2ResponseConfig(
            global::System.Collections.Generic.IList<global::Supabase.NetworkRestrictionsV2ResponseConfigDbAllowedCidr>? dbAllowedCidrs)
        {
            this.DbAllowedCidrs = dbAllowedCidrs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsV2ResponseConfig" /> class.
        /// </summary>
        public NetworkRestrictionsV2ResponseConfig()
        {
        }
    }
}