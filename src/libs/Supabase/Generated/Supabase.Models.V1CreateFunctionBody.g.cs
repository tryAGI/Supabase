
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"slug":"hello-world","name":"Hello World","body":"Deno.serve(() =\u003E new Response(\u0027Hello, world!\u0027))","verify_jwt":true}
    /// </summary>
    public sealed partial class V1CreateFunctionBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verify_jwt")]
        public bool? VerifyJwt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1CreateFunctionBody" /> class.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="name"></param>
        /// <param name="body"></param>
        /// <param name="verifyJwt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1CreateFunctionBody(
            string slug,
            string name,
            string body,
            bool? verifyJwt)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.VerifyJwt = verifyJwt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1CreateFunctionBody" /> class.
        /// </summary>
        public V1CreateFunctionBody()
        {
        }
    }
}