
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSigningKeyBodyPrivateJwkVariant2
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2UseJsonConverter))]
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Use? Use { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_ops")]
        public global::System.Collections.Generic.IList<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2KeyOp>? KeyOps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ext")]
        public bool? Ext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kty")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2KtyJsonConverter))]
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Kty Kty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alg")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2AlgJsonConverter))]
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Alg? Alg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crv")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2CrvJsonConverter))]
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Crv Crv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string X { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Y { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("d")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string D { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSigningKeyBodyPrivateJwkVariant2" /> class.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="d"></param>
        /// <param name="kid"></param>
        /// <param name="use"></param>
        /// <param name="keyOps"></param>
        /// <param name="ext"></param>
        /// <param name="kty"></param>
        /// <param name="alg"></param>
        /// <param name="crv"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSigningKeyBodyPrivateJwkVariant2(
            string x,
            string y,
            string d,
            global::System.Guid? kid,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Use? use,
            global::System.Collections.Generic.IList<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2KeyOp>? keyOps,
            bool? ext,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Kty kty,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Alg? alg,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Crv crv)
        {
            this.Kid = kid;
            this.Use = use;
            this.KeyOps = keyOps;
            this.Ext = ext;
            this.Kty = kty;
            this.Alg = alg;
            this.Crv = crv;
            this.X = x ?? throw new global::System.ArgumentNullException(nameof(x));
            this.Y = y ?? throw new global::System.ArgumentNullException(nameof(y));
            this.D = d ?? throw new global::System.ArgumentNullException(nameof(d));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSigningKeyBodyPrivateJwkVariant2" /> class.
        /// </summary>
        public CreateSigningKeyBodyPrivateJwkVariant2()
        {
        }
    }
}