
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateCustomHostnameResponseOutputDataResultSsl
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_records")]
        public global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseOutputDataResultSslValidationRecord>? ValidationRecords { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_errors")]
        public global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseOutputDataResultSslValidationError>? ValidationErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseOutputDataResultSsl" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="validationRecords"></param>
        /// <param name="validationErrors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomHostnameResponseOutputDataResultSsl(
            string? status,
            global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseOutputDataResultSslValidationRecord>? validationRecords,
            global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseOutputDataResultSslValidationError>? validationErrors)
        {
            this.Status = status;
            this.ValidationRecords = validationRecords;
            this.ValidationErrors = validationErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseOutputDataResultSsl" /> class.
        /// </summary>
        public UpdateCustomHostnameResponseOutputDataResultSsl()
        {
        }

    }
}