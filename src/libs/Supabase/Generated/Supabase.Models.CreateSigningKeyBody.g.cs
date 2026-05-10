
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"algorithm":"RS256","status":"standby"}
    /// </summary>
    public sealed partial class CreateSigningKeyBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyAlgorithmJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.CreateSigningKeyBodyAlgorithm Algorithm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyStatusJsonConverter))]
        public global::Supabase.CreateSigningKeyBodyStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_jwk")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.PrivateJwkJsonConverter))]
        public global::Supabase.PrivateJwk? PrivateJwk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSigningKeyBody" /> class.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="status"></param>
        /// <param name="privateJwk"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSigningKeyBody(
            global::Supabase.CreateSigningKeyBodyAlgorithm algorithm,
            global::Supabase.CreateSigningKeyBodyStatus? status,
            global::Supabase.PrivateJwk? privateJwk)
        {
            this.Algorithm = algorithm;
            this.Status = status;
            this.PrivateJwk = privateJwk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSigningKeyBody" /> class.
        /// </summary>
        public CreateSigningKeyBody()
        {
        }

    }
}