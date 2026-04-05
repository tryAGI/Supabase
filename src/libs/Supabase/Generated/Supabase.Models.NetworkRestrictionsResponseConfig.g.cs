
#nullable enable

namespace Supabase
{
    /// <summary>
    /// At any given point in time, this is the config that the user has requested be applied to their project. The `status` field indicates if it has been applied to the project, or is pending. When an updated config is received, the applied config is moved to `old_config`.
    /// </summary>
    public sealed partial class NetworkRestrictionsResponseConfig
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
        /// Initializes a new instance of the <see cref="NetworkRestrictionsResponseConfig" /> class.
        /// </summary>
        /// <param name="dbAllowedCidrs"></param>
        /// <param name="dbAllowedCidrsV6"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkRestrictionsResponseConfig(
            global::System.Collections.Generic.IList<string>? dbAllowedCidrs,
            global::System.Collections.Generic.IList<string>? dbAllowedCidrsV6)
        {
            this.DbAllowedCidrs = dbAllowedCidrs;
            this.DbAllowedCidrsV6 = dbAllowedCidrsV6;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsResponseConfig" /> class.
        /// </summary>
        public NetworkRestrictionsResponseConfig()
        {
        }
    }
}