
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1TypeJsonConverter))]
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Dependents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1" /> class.
        /// </summary>
        /// <param name="dependents"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1(
            global::System.Collections.Generic.IList<string> dependents,
            global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1Type type)
        {
            this.Type = type;
            this.Dependents = dependents ?? throw new global::System.ArgumentNullException(nameof(dependents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1" /> class.
        /// </summary>
        public ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1()
        {
        }

    }
}