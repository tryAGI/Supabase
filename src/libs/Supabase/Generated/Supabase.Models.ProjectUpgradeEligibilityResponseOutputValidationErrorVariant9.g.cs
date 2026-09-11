
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9TypeJsonConverter))]
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9(
            global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9" /> class.
        /// </summary>
        public ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9()
        {
        }

    }
}