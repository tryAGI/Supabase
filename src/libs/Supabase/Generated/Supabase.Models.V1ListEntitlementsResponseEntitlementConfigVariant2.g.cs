
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1ListEntitlementsResponseEntitlementConfigVariant2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unlimited")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Unlimited { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListEntitlementsResponseEntitlementConfigVariant2" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="value"></param>
        /// <param name="unlimited"></param>
        /// <param name="unit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ListEntitlementsResponseEntitlementConfigVariant2(
            bool enabled,
            double value,
            bool unlimited,
            string unit)
        {
            this.Enabled = enabled;
            this.Value = value;
            this.Unlimited = unlimited;
            this.Unit = unit ?? throw new global::System.ArgumentNullException(nameof(unit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListEntitlementsResponseEntitlementConfigVariant2" /> class.
        /// </summary>
        public V1ListEntitlementsResponseEntitlementConfigVariant2()
        {
        }
    }
}