
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUpgradeEligibilityResponseValidationErrorVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant8TypeJsonConverter))]
        public global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant8Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slot_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SlotName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseValidationErrorVariant8" /> class.
        /// </summary>
        /// <param name="slotName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUpgradeEligibilityResponseValidationErrorVariant8(
            string slotName,
            global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant8Type type)
        {
            this.Type = type;
            this.SlotName = slotName ?? throw new global::System.ArgumentNullException(nameof(slotName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseValidationErrorVariant8" /> class.
        /// </summary>
        public ProjectUpgradeEligibilityResponseValidationErrorVariant8()
        {
        }

    }
}