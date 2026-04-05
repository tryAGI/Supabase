
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NetworkRestrictionsPatchRequestRemove
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
        /// Initializes a new instance of the <see cref="NetworkRestrictionsPatchRequestRemove" /> class.
        /// </summary>
        /// <param name="dbAllowedCidrs"></param>
        /// <param name="dbAllowedCidrsV6"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkRestrictionsPatchRequestRemove(
            global::System.Collections.Generic.IList<string>? dbAllowedCidrs,
            global::System.Collections.Generic.IList<string>? dbAllowedCidrsV6)
        {
            this.DbAllowedCidrs = dbAllowedCidrs;
            this.DbAllowedCidrsV6 = dbAllowedCidrsV6;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsPatchRequestRemove" /> class.
        /// </summary>
        public NetworkRestrictionsPatchRequestRemove()
        {
        }
    }
}