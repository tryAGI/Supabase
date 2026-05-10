
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUpgradeEligibilityResponseValidationErrorVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant7TypeJsonConverter))]
        public global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant7Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("obj_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjType ObjType { get; set; }

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
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseValidationErrorVariant7" /> class.
        /// </summary>
        /// <param name="objType"></param>
        /// <param name="schemaName"></param>
        /// <param name="objName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUpgradeEligibilityResponseValidationErrorVariant7(
            global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjType objType,
            string schemaName,
            string objName,
            global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant7Type type)
        {
            this.Type = type;
            this.ObjType = objType;
            this.SchemaName = schemaName ?? throw new global::System.ArgumentNullException(nameof(schemaName));
            this.ObjName = objName ?? throw new global::System.ArgumentNullException(nameof(objName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseValidationErrorVariant7" /> class.
        /// </summary>
        public ProjectUpgradeEligibilityResponseValidationErrorVariant7()
        {
        }

    }
}