
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCustomHostnameResponseDataResult
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.UpdateCustomHostnameResponseDataResultSsl Ssl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownership_verification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.UpdateCustomHostnameResponseDataResultOwnershipVerification OwnershipVerification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_origin_server")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomOriginServer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_errors")]
        public global::System.Collections.Generic.IList<string>? VerificationErrors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseDataResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="hostname"></param>
        /// <param name="ssl"></param>
        /// <param name="ownershipVerification"></param>
        /// <param name="customOriginServer"></param>
        /// <param name="status"></param>
        /// <param name="verificationErrors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomHostnameResponseDataResult(
            string id,
            string hostname,
            global::Supabase.UpdateCustomHostnameResponseDataResultSsl ssl,
            global::Supabase.UpdateCustomHostnameResponseDataResultOwnershipVerification ownershipVerification,
            string customOriginServer,
            string status,
            global::System.Collections.Generic.IList<string>? verificationErrors)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Hostname = hostname ?? throw new global::System.ArgumentNullException(nameof(hostname));
            this.Ssl = ssl ?? throw new global::System.ArgumentNullException(nameof(ssl));
            this.OwnershipVerification = ownershipVerification ?? throw new global::System.ArgumentNullException(nameof(ownershipVerification));
            this.CustomOriginServer = customOriginServer ?? throw new global::System.ArgumentNullException(nameof(customOriginServer));
            this.VerificationErrors = verificationErrors;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseDataResult" /> class.
        /// </summary>
        public UpdateCustomHostnameResponseDataResult()
        {
        }

    }
}