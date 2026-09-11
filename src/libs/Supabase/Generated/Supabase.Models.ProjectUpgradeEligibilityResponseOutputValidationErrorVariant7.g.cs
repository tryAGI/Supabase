
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7TypeJsonConverter))]
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("obj_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.AnyOfJsonConverter<global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant1?, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant2?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.AnyOf<global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant1?, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant2?> ObjType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SchemaName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("obj_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7" /> class.
        /// </summary>
        /// <param name="objType"></param>
        /// <param name="schemaName"></param>
        /// <param name="objName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7(
            global::Supabase.AnyOf<global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant1?, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant2?> objType,
            string schemaName,
            string objName,
            global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7Type type)
        {
            this.Type = type;
            this.ObjType = objType;
            this.SchemaName = schemaName ?? throw new global::System.ArgumentNullException(nameof(schemaName));
            this.ObjName = objName ?? throw new global::System.ArgumentNullException(nameof(objName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7" /> class.
        /// </summary>
        public ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7()
        {
        }

    }
}