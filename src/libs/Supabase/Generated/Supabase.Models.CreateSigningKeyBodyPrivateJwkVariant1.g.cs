
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSigningKeyBodyPrivateJwkVariant1
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1UseJsonConverter))]
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1Use? Use { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_ops")]
        public global::System.Collections.Generic.IList<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1KeyOp>? KeyOps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ext")]
        public bool? Ext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kty")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1KtyJsonConverter))]
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1Kty Kty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alg")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1AlgJsonConverter))]
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1Alg? Alg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string N { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("e")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1EJsonConverter))]
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1E E { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("d")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string D { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string P { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Q { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dq")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("qi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Qi { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSigningKeyBodyPrivateJwkVariant1" /> class.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <param name="dp"></param>
        /// <param name="dq"></param>
        /// <param name="qi"></param>
        /// <param name="kid"></param>
        /// <param name="use"></param>
        /// <param name="keyOps"></param>
        /// <param name="ext"></param>
        /// <param name="kty"></param>
        /// <param name="alg"></param>
        /// <param name="e"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSigningKeyBodyPrivateJwkVariant1(
            string n,
            string d,
            string p,
            string q,
            string dp,
            string dq,
            string qi,
            global::System.Guid? kid,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1Use? use,
            global::System.Collections.Generic.IList<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1KeyOp>? keyOps,
            bool? ext,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1Kty kty,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1Alg? alg,
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1E e)
        {
            this.Kid = kid;
            this.Use = use;
            this.KeyOps = keyOps;
            this.Ext = ext;
            this.Kty = kty;
            this.Alg = alg;
            this.N = n ?? throw new global::System.ArgumentNullException(nameof(n));
            this.E = e;
            this.D = d ?? throw new global::System.ArgumentNullException(nameof(d));
            this.P = p ?? throw new global::System.ArgumentNullException(nameof(p));
            this.Q = q ?? throw new global::System.ArgumentNullException(nameof(q));
            this.Dp = dp ?? throw new global::System.ArgumentNullException(nameof(dp));
            this.Dq = dq ?? throw new global::System.ArgumentNullException(nameof(dq));
            this.Qi = qi ?? throw new global::System.ArgumentNullException(nameof(qi));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSigningKeyBodyPrivateJwkVariant1" /> class.
        /// </summary>
        public CreateSigningKeyBodyPrivateJwkVariant1()
        {
        }

    }
}