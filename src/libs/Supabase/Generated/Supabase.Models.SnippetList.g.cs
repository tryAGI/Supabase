
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SnippetList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.SnippetListDataItem> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnippetList" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="cursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SnippetList(
            global::System.Collections.Generic.IList<global::Supabase.SnippetListDataItem> data,
            string? cursor)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnippetList" /> class.
        /// </summary>
        public SnippetList()
        {
        }

    }
}