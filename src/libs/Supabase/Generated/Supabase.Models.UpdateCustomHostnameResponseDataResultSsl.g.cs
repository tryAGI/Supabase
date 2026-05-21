
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCustomHostnameResponseDataResultSsl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_records")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseDataResultSslValidationRecord> ValidationRecords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_errors")]
        public global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseDataResultSslValidationError>? ValidationErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseDataResultSsl" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="validationRecords"></param>
        /// <param name="validationErrors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomHostnameResponseDataResultSsl(
            string status,
            global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseDataResultSslValidationRecord> validationRecords,
            global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseDataResultSslValidationError>? validationErrors)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.ValidationRecords = validationRecords ?? throw new global::System.ArgumentNullException(nameof(validationRecords));
            this.ValidationErrors = validationErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseDataResultSsl" /> class.
        /// </summary>
        public UpdateCustomHostnameResponseDataResultSsl()
        {
        }

    }
}