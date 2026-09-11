
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4TypeJsonConverter))]
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExtensionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4" /> class.
        /// </summary>
        /// <param name="extensionName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4(
            string extensionName,
            global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4Type type)
        {
            this.Type = type;
            this.ExtensionName = extensionName ?? throw new global::System.ArgumentNullException(nameof(extensionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4" /> class.
        /// </summary>
        public ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4()
        {
        }

    }
}