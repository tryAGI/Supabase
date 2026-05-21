
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUpgradeEligibilityResponseWarningVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseWarningVariant1TypeJsonConverter))]
        public global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseWarningVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUpgradeEligibilityResponseWarningVariant1(
            global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseWarningVariant1" /> class.
        /// </summary>
        public ProjectUpgradeEligibilityResponseWarningVariant1()
        {
        }

    }
}