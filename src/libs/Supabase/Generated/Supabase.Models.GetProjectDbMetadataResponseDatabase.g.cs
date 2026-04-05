
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectDbMetadataResponseDatabase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.GetProjectDbMetadataResponseDatabaseSchema> Schemas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDbMetadataResponseDatabase" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="schemas"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectDbMetadataResponseDatabase(
            string name,
            global::System.Collections.Generic.IList<global::Supabase.GetProjectDbMetadataResponseDatabaseSchema> schemas)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDbMetadataResponseDatabase" /> class.
        /// </summary>
        public GetProjectDbMetadataResponseDatabase()
        {
        }
    }
}