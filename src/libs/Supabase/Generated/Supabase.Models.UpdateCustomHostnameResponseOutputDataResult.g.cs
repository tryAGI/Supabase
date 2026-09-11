
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateCustomHostnameResponseOutputDataResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hostname { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssl")]
        public global::Supabase.UpdateCustomHostnameResponseOutputDataResultSsl? Ssl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownership_verification")]
        public global::Supabase.UpdateCustomHostnameResponseOutputDataResultOwnershipVerification? OwnershipVerification { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_origin_server")]
        public string? CustomOriginServer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_errors")]
        public global::System.Collections.Generic.IList<string>? VerificationErrors { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseOutputDataResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="hostname"></param>
        /// <param name="ssl"></param>
        /// <param name="ownershipVerification"></param>
        /// <param name="customOriginServer"></param>
        /// <param name="verificationErrors"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomHostnameResponseOutputDataResult(
            string id,
            string hostname,
            global::Supabase.UpdateCustomHostnameResponseOutputDataResultSsl? ssl,
            global::Supabase.UpdateCustomHostnameResponseOutputDataResultOwnershipVerification? ownershipVerification,
            string? customOriginServer,
            global::System.Collections.Generic.IList<string>? verificationErrors,
            string? status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Hostname = hostname ?? throw new global::System.ArgumentNullException(nameof(hostname));
            this.Ssl = ssl;
            this.OwnershipVerification = ownershipVerification;
            this.CustomOriginServer = customOriginServer;
            this.VerificationErrors = verificationErrors;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseOutputDataResult" /> class.
        /// </summary>
        public UpdateCustomHostnameResponseOutputDataResult()
        {
        }

    }
}