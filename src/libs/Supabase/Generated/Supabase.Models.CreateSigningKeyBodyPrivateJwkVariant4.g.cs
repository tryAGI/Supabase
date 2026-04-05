
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSigningKeyBodyPrivateJwkVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kid")]
        public global::System.Guid? Kid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4UseJsonConverter))]
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4Use? Use { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_ops")]
        public global::System.Collections.Generic.IList<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4KeyOp>? KeyOps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ext")]
        public bool? Ext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kty")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4KtyJsonConverter))]
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4Kty Kty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alg")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4AlgJsonConverter))]
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4Alg? Alg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("k")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string K { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSigningKeyBodyPrivateJwkVariant4" /> class.
        /// </summary>
        /// <param name="k"></param>
        /// <param name="kid"></param>
        /// <param name="use"></param>
        /// <param name="keyOps"></param>
        /// <param name="ext"></param>
        /// <param name="kty"></param>
        /// <param name="alg"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSigningKeyBodyPrivateJwkVariant4(
            string k,
            global::System.Guid? kid,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4Use? use,
            global::System.Collections.Generic.IList<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4KeyOp>? keyOps,
            bool? ext,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4Kty kty,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4Alg? alg)
        {
            this.Kid = kid;
            this.Use = use;
            this.KeyOps = keyOps;
            this.Ext = ext;
            this.Kty = kty;
            this.Alg = alg;
            this.K = k ?? throw new global::System.ArgumentNullException(nameof(k));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSigningKeyBodyPrivateJwkVariant4" /> class.
        /// </summary>
        public CreateSigningKeyBodyPrivateJwkVariant4()
        {
        }
    }
}