
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSigningKeyBodyPrivateJwkDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kty")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkDiscriminatorKtyJsonConverter))]
        public global::Supabase.CreateSigningKeyBodyPrivateJwkDiscriminatorKty? Kty { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSigningKeyBodyPrivateJwkDiscriminator" /> class.
        /// </summary>
        /// <param name="kty"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSigningKeyBodyPrivateJwkDiscriminator(
            global::Supabase.CreateSigningKeyBodyPrivateJwkDiscriminatorKty? kty)
        {
            this.Kty = kty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSigningKeyBodyPrivateJwkDiscriminator" /> class.
        /// </summary>
        public CreateSigningKeyBodyPrivateJwkDiscriminator()
        {
        }

    }
}