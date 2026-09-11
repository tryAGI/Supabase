
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class V1ListEntitlementsResponseOutputEntitlement
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeature Feature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasAccess")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasAccess { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ListEntitlementsResponseOutputEntitlementTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ListEntitlementsResponseOutputEntitlementType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.AnyOfJsonConverter<global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant1, global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant2, global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.AnyOf<global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant1, global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant2, global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant3> Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListEntitlementsResponseOutputEntitlement" /> class.
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="hasAccess"></param>
        /// <param name="type"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ListEntitlementsResponseOutputEntitlement(
            global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeature feature,
            bool hasAccess,
            global::Supabase.V1ListEntitlementsResponseOutputEntitlementType type,
            global::Supabase.AnyOf<global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant1, global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant2, global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant3> config)
        {
            this.Feature = feature ?? throw new global::System.ArgumentNullException(nameof(feature));
            this.HasAccess = hasAccess;
            this.Type = type;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListEntitlementsResponseOutputEntitlement" /> class.
        /// </summary>
        public V1ListEntitlementsResponseOutputEntitlement()
        {
        }

    }
}