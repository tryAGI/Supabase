
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"name":"Hello World","body":"Deno.serve(() =\u003E new Response(\u0027Hello again!\u0027))","verify_jwt":true}
    /// </summary>
    public sealed partial class V1UpdateFunctionBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

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
        /// Initializes a new instance of the <see cref="V1UpdateFunctionBody" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="body"></param>
        /// <param name="verifyJwt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1UpdateFunctionBody(
            string? name,
            string? body,
            bool? verifyJwt)
        {
            this.Name = name;
            this.Body = body;
            this.VerifyJwt = verifyJwt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1UpdateFunctionBody" /> class.
        /// </summary>
        public V1UpdateFunctionBody()
        {
        }
    }
}