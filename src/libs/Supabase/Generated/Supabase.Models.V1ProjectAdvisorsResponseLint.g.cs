
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1ProjectAdvisorsResponseLint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ProjectAdvisorsResponseLintName Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ProjectAdvisorsResponseLintLevel Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintFacingJsonConverter))]
        public global::Supabase.V1ProjectAdvisorsResponseLintFacing Facing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.V1ProjectAdvisorsResponseLintCategorie> Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remediation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Remediation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Supabase.V1ProjectAdvisorsResponseLintMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CacheKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ProjectAdvisorsResponseLint" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="title"></param>
        /// <param name="level"></param>
        /// <param name="categories"></param>
        /// <param name="description"></param>
        /// <param name="detail"></param>
        /// <param name="remediation"></param>
        /// <param name="cacheKey"></param>
        /// <param name="facing"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ProjectAdvisorsResponseLint(
            global::Supabase.V1ProjectAdvisorsResponseLintName name,
            string title,
            global::Supabase.V1ProjectAdvisorsResponseLintLevel level,
            global::System.Collections.Generic.IList<global::Supabase.V1ProjectAdvisorsResponseLintCategorie> categories,
            string description,
            string detail,
            string remediation,
            string cacheKey,
            global::Supabase.V1ProjectAdvisorsResponseLintFacing facing,
            global::Supabase.V1ProjectAdvisorsResponseLintMetadata? metadata)
        {
            this.Name = name;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Level = level;
            this.Facing = facing;
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.Remediation = remediation ?? throw new global::System.ArgumentNullException(nameof(remediation));
            this.Metadata = metadata;
            this.CacheKey = cacheKey ?? throw new global::System.ArgumentNullException(nameof(cacheKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ProjectAdvisorsResponseLint" /> class.
        /// </summary>
        public V1ProjectAdvisorsResponseLint()
        {
        }
    }
}