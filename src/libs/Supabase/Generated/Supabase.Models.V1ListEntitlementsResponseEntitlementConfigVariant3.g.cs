
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1ListEntitlementsResponseEntitlementConfigVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("set")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Set { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListEntitlementsResponseEntitlementConfigVariant3" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="set"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ListEntitlementsResponseEntitlementConfigVariant3(
            bool enabled,
            global::System.Collections.Generic.IList<string> set)
        {
            this.Enabled = enabled;
            this.Set = set ?? throw new global::System.ArgumentNullException(nameof(set));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListEntitlementsResponseEntitlementConfigVariant3" /> class.
        /// </summary>
        public V1ListEntitlementsResponseEntitlementConfigVariant3()
        {
        }

    }
}