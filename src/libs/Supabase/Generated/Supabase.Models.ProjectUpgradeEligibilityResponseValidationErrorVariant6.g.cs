
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUpgradeEligibilityResponseValidationErrorVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant6TypeJsonConverter))]
        public global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant6Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SchemaName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TableName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SequenceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseValidationErrorVariant6" /> class.
        /// </summary>
        /// <param name="schemaName"></param>
        /// <param name="tableName"></param>
        /// <param name="sequenceName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUpgradeEligibilityResponseValidationErrorVariant6(
            string schemaName,
            string tableName,
            string sequenceName,
            global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant6Type type)
        {
            this.Type = type;
            this.SchemaName = schemaName ?? throw new global::System.ArgumentNullException(nameof(schemaName));
            this.TableName = tableName ?? throw new global::System.ArgumentNullException(nameof(tableName));
            this.SequenceName = sequenceName ?? throw new global::System.ArgumentNullException(nameof(sequenceName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseValidationErrorVariant6" /> class.
        /// </summary>
        public ProjectUpgradeEligibilityResponseValidationErrorVariant6()
        {
        }

    }
}