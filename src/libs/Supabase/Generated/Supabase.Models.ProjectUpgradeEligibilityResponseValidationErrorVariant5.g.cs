
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUpgradeEligibilityResponseValidationErrorVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant5TypeJsonConverter))]
        public global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant5Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fdw_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FdwName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fdw_handler_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FdwHandlerName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseValidationErrorVariant5" /> class.
        /// </summary>
        /// <param name="fdwName"></param>
        /// <param name="fdwHandlerName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUpgradeEligibilityResponseValidationErrorVariant5(
            string fdwName,
            string fdwHandlerName,
            global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant5Type type)
        {
            this.Type = type;
            this.FdwName = fdwName ?? throw new global::System.ArgumentNullException(nameof(fdwName));
            this.FdwHandlerName = fdwHandlerName ?? throw new global::System.ArgumentNullException(nameof(fdwHandlerName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseValidationErrorVariant5" /> class.
        /// </summary>
        public ProjectUpgradeEligibilityResponseValidationErrorVariant5()
        {
        }
    }
}