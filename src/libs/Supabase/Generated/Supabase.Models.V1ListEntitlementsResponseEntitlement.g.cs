
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1ListEntitlementsResponseEntitlement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ListEntitlementsResponseEntitlementFeature Feature { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ListEntitlementsResponseEntitlementTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ListEntitlementsResponseEntitlementType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant1, global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant2, global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.OneOf<global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant1, global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant2, global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant3> Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListEntitlementsResponseEntitlement" /> class.
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="hasAccess"></param>
        /// <param name="type"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ListEntitlementsResponseEntitlement(
            global::Supabase.V1ListEntitlementsResponseEntitlementFeature feature,
            bool hasAccess,
            global::Supabase.V1ListEntitlementsResponseEntitlementType type,
            global::Supabase.OneOf<global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant1, global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant2, global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant3> config)
        {
            this.Feature = feature ?? throw new global::System.ArgumentNullException(nameof(feature));
            this.HasAccess = hasAccess;
            this.Type = type;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListEntitlementsResponseEntitlement" /> class.
        /// </summary>
        public V1ListEntitlementsResponseEntitlement()
        {
        }

    }
}