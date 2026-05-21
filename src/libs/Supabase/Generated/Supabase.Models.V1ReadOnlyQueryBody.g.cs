
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"query":"select * from pg_stat_activity limit 1;"}
    /// </summary>
    public sealed partial class V1ReadOnlyQueryBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.IList<object>? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ReadOnlyQueryBody" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ReadOnlyQueryBody(
            string query,
            global::System.Collections.Generic.IList<object>? parameters)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ReadOnlyQueryBody" /> class.
        /// </summary>
        public V1ReadOnlyQueryBody()
        {
        }

    }
}