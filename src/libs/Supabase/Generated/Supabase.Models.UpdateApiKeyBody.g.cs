
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"name":"ci_secret_key_rotated","description":"Rotated after March release"}
    /// </summary>
    public sealed partial class UpdateApiKeyBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateApiKeyBody" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="secretJwtTemplate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateApiKeyBody(
            string? name,
            string? description,
            object? secretJwtTemplate)
        {
            this.Name = name;
            this.Description = description;
            this.SecretJwtTemplate = secretJwtTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyBody" /> class.
        /// </summary>
        public UpdateApiKeyBody()
        {
        }

    }
}