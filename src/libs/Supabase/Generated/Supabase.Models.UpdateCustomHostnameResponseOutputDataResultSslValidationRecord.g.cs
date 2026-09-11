
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateCustomHostnameResponseOutputDataResultSslValidationRecord
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("txt_name")]
        public string? TxtName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("txt_value")]
        public string? TxtValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseOutputDataResultSslValidationRecord" /> class.
        /// </summary>
        /// <param name="txtName"></param>
        /// <param name="txtValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomHostnameResponseOutputDataResultSslValidationRecord(
            string? txtName,
            string? txtValue)
        {
            this.TxtName = txtName;
            this.TxtValue = txtValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseOutputDataResultSslValidationRecord" /> class.
        /// </summary>
        public UpdateCustomHostnameResponseOutputDataResultSslValidationRecord()
        {
        }

    }
}