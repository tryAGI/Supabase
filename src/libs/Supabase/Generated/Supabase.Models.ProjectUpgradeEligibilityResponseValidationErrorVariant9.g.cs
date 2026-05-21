
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUpgradeEligibilityResponseValidationErrorVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant9TypeJsonConverter))]
        public global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant9Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseValidationErrorVariant9" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUpgradeEligibilityResponseValidationErrorVariant9(
            global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant9Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseValidationErrorVariant9" /> class.
        /// </summary>
        public ProjectUpgradeEligibilityResponseValidationErrorVariant9()
        {
        }

    }
}