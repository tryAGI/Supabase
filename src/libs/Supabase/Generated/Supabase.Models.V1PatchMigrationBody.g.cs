
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1PatchMigrationBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollback")]
        public string? Rollback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1PatchMigrationBody" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rollback"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1PatchMigrationBody(
            string? name,
            string? rollback)
        {
            this.Name = name;
            this.Rollback = rollback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1PatchMigrationBody" /> class.
        /// </summary>
        public V1PatchMigrationBody()
        {
        }
    }
}