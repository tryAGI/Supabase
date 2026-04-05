
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1UpdatePostgrestConfigBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_extra_search_path")]
        public string? DbExtraSearchPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_schema")]
        public string? DbSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_rows")]
        public int? MaxRows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_pool")]
        public int? DbPool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1UpdatePostgrestConfigBody" /> class.
        /// </summary>
        /// <param name="dbExtraSearchPath"></param>
        /// <param name="dbSchema"></param>
        /// <param name="maxRows"></param>
        /// <param name="dbPool"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1UpdatePostgrestConfigBody(
            string? dbExtraSearchPath,
            string? dbSchema,
            int? maxRows,
            int? dbPool)
        {
            this.DbExtraSearchPath = dbExtraSearchPath;
            this.DbSchema = dbSchema;
            this.MaxRows = maxRows;
            this.DbPool = dbPool;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1UpdatePostgrestConfigBody" /> class.
        /// </summary>
        public V1UpdatePostgrestConfigBody()
        {
        }
    }
}