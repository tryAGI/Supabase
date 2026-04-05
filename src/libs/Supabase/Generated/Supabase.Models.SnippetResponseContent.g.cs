
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SnippetResponseContent
    {
        /// <summary>
        /// Deprecated: Rely on root-level favorite property instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favorite")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Favorite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SchemaVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sql")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sql { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnippetResponseContent" /> class.
        /// </summary>
        /// <param name="schemaVersion"></param>
        /// <param name="sql"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SnippetResponseContent(
            string schemaVersion,
            string sql)
        {
            this.SchemaVersion = schemaVersion ?? throw new global::System.ArgumentNullException(nameof(schemaVersion));
            this.Sql = sql ?? throw new global::System.ArgumentNullException(nameof(sql));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnippetResponseContent" /> class.
        /// </summary>
        public SnippetResponseContent()
        {
        }
    }
}