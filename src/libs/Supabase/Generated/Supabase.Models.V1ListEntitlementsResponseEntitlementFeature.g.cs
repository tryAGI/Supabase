
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1ListEntitlementsResponseEntitlementFeature
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ListEntitlementsResponseEntitlementFeatureKeyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ListEntitlementsResponseEntitlementFeatureKey Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ListEntitlementsResponseEntitlementFeatureTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ListEntitlementsResponseEntitlementFeatureType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListEntitlementsResponseEntitlementFeature" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ListEntitlementsResponseEntitlementFeature(
            global::Supabase.V1ListEntitlementsResponseEntitlementFeatureKey key,
            global::Supabase.V1ListEntitlementsResponseEntitlementFeatureType type)
        {
            this.Key = key;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListEntitlementsResponseEntitlementFeature" /> class.
        /// </summary>
        public V1ListEntitlementsResponseEntitlementFeature()
        {
        }

    }
}