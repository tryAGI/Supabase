
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ApiKeyResponseTypeJsonConverter))]
        public global::Supabase.ApiKeyResponseType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_jwt_template")]
        public object? SecretJwtTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inserted_at")]
        public global::System.DateTime? InsertedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="apiKey"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="prefix"></param>
        /// <param name="description"></param>
        /// <param name="hash"></param>
        /// <param name="secretJwtTemplate"></param>
        /// <param name="insertedAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeyResponse(
            string name,
            string? apiKey,
            string? id,
            global::Supabase.ApiKeyResponseType? type,
            string? prefix,
            string? description,
            string? hash,
            object? secretJwtTemplate,
            global::System.DateTime? insertedAt,
            global::System.DateTime? updatedAt)
        {
            this.ApiKey = apiKey;
            this.Id = id;
            this.Type = type;
            this.Prefix = prefix;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Hash = hash;
            this.SecretJwtTemplate = secretJwtTemplate;
            this.InsertedAt = insertedAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyResponse" /> class.
        /// </summary>
        public ApiKeyResponse()
        {
        }

    }
}