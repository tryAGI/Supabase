
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"migration_version":"20250312000000"}
    /// </summary>
    public sealed partial class BranchActionBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("migration_version")]
        public string? MigrationVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchActionBody" /> class.
        /// </summary>
        /// <param name="migrationVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchActionBody(
            string? migrationVersion)
        {
            this.MigrationVersion = migrationVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchActionBody" /> class.
        /// </summary>
        public BranchActionBody()
        {
        }

    }
}