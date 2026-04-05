
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1ProjectAdvisorsResponseLintMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public string? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        public string? Entity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintMetadataTypeJsonConverter))]
        public global::Supabase.V1ProjectAdvisorsResponseLintMetadataType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fkey_name")]
        public string? FkeyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fkey_columns")]
        public global::System.Collections.Generic.IList<double>? FkeyColumns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ProjectAdvisorsResponseLintMetadata" /> class.
        /// </summary>
        /// <param name="schema"></param>
        /// <param name="name"></param>
        /// <param name="entity"></param>
        /// <param name="type"></param>
        /// <param name="fkeyName"></param>
        /// <param name="fkeyColumns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ProjectAdvisorsResponseLintMetadata(
            string? schema,
            string? name,
            string? entity,
            global::Supabase.V1ProjectAdvisorsResponseLintMetadataType? type,
            string? fkeyName,
            global::System.Collections.Generic.IList<double>? fkeyColumns)
        {
            this.Schema = schema;
            this.Name = name;
            this.Entity = entity;
            this.Type = type;
            this.FkeyName = fkeyName;
            this.FkeyColumns = fkeyColumns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ProjectAdvisorsResponseLintMetadata" /> class.
        /// </summary>
        public V1ProjectAdvisorsResponseLintMetadata()
        {
        }
    }
}