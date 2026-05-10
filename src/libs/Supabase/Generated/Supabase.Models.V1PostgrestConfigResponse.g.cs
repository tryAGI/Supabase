
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1PostgrestConfigResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxRows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_extra_search_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbExtraSearchPath { get; set; }

        /// <summary>
        /// If `null`, the value is automatically configured based on compute size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_pool")]
        public int? DbPool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1PostgrestConfigResponse" /> class.
        /// </summary>
        /// <param name="dbSchema"></param>
        /// <param name="maxRows"></param>
        /// <param name="dbExtraSearchPath"></param>
        /// <param name="dbPool">
        /// If `null`, the value is automatically configured based on compute size.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1PostgrestConfigResponse(
            string dbSchema,
            int maxRows,
            string dbExtraSearchPath,
            int? dbPool)
        {
            this.DbSchema = dbSchema ?? throw new global::System.ArgumentNullException(nameof(dbSchema));
            this.MaxRows = maxRows;
            this.DbExtraSearchPath = dbExtraSearchPath ?? throw new global::System.ArgumentNullException(nameof(dbExtraSearchPath));
            this.DbPool = dbPool;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1PostgrestConfigResponse" /> class.
        /// </summary>
        public V1PostgrestConfigResponse()
        {
        }

    }
}