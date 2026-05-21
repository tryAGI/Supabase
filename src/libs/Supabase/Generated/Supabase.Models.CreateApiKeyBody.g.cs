
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"type":"secret","name":"ci_secret_key","description":"CI deploy key"}
    /// </summary>
    public sealed partial class CreateApiKeyBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateApiKeyBodyTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.CreateApiKeyBodyType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_jwt_template")]
        public object? SecretJwtTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyBody" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="secretJwtTemplate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeyBody(
            global::Supabase.CreateApiKeyBodyType type,
            string name,
            string? description,
            object? secretJwtTemplate)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.SecretJwtTemplate = secretJwtTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyBody" /> class.
        /// </summary>
        public CreateApiKeyBody()
        {
        }

    }
}