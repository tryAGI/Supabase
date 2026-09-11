
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class V1ListEntitlementsResponseOutputEntitlementFeature
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ListEntitlementsResponseOutputEntitlementFeatureKeyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureKey Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ListEntitlementsResponseOutputEntitlementFeatureTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListEntitlementsResponseOutputEntitlementFeature" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ListEntitlementsResponseOutputEntitlementFeature(
            global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureKey key,
            global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureType type)
        {
            this.Key = key;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListEntitlementsResponseOutputEntitlementFeature" /> class.
        /// </summary>
        public V1ListEntitlementsResponseOutputEntitlementFeature()
        {
        }

    }
}