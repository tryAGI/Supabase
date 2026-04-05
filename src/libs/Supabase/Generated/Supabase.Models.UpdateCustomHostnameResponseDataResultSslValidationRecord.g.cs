
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCustomHostnameResponseDataResultSslValidationRecord
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("txt_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TxtName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("txt_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TxtValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseDataResultSslValidationRecord" /> class.
        /// </summary>
        /// <param name="txtName"></param>
        /// <param name="txtValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomHostnameResponseDataResultSslValidationRecord(
            string txtName,
            string txtValue)
        {
            this.TxtName = txtName ?? throw new global::System.ArgumentNullException(nameof(txtName));
            this.TxtValue = txtValue ?? throw new global::System.ArgumentNullException(nameof(txtValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseDataResultSslValidationRecord" /> class.
        /// </summary>
        public UpdateCustomHostnameResponseDataResultSslValidationRecord()
        {
        }
    }
}