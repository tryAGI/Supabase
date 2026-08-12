
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Present on entitlement denials. Other errors with this status code (validation, billing state) carry only message.
    /// </summary>
    public sealed partial class PlanGateErrorBodyError
    {
        /// <summary>
        /// Machine-readable marker for plan-gated denials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.PlanGateErrorBodyErrorCodeJsonConverter))]
        public global::Supabase.PlanGateErrorBodyErrorCode Code { get; set; }

        /// <summary>
        /// Entitlement feature key that failed the check
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Feature { get; set; }

        /// <summary>
        /// Billing page URL for the organization, present when the org is resolvable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upgrade_url")]
        public string? UpgradeUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanGateErrorBodyError" /> class.
        /// </summary>
        /// <param name="feature">
        /// Entitlement feature key that failed the check
        /// </param>
        /// <param name="code">
        /// Machine-readable marker for plan-gated denials
        /// </param>
        /// <param name="upgradeUrl">
        /// Billing page URL for the organization, present when the org is resolvable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlanGateErrorBodyError(
            string feature,
            global::Supabase.PlanGateErrorBodyErrorCode code,
            string? upgradeUrl)
        {
            this.Code = code;
            this.Feature = feature ?? throw new global::System.ArgumentNullException(nameof(feature));
            this.UpgradeUrl = upgradeUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanGateErrorBodyError" /> class.
        /// </summary>
        public PlanGateErrorBodyError()
        {
        }

    }
}