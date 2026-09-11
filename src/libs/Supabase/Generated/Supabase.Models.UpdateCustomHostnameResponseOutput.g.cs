
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateCustomHostnameResponseOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.UpdateCustomHostnameResponseOutputStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.UpdateCustomHostnameResponseOutputStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_hostname")]
        public string? CustomHostname { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.UpdateCustomHostnameResponseOutputData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseOutput" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="data"></param>
        /// <param name="customHostname"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomHostnameResponseOutput(
            global::Supabase.UpdateCustomHostnameResponseOutputStatus status,
            global::Supabase.UpdateCustomHostnameResponseOutputData data,
            string? customHostname)
        {
            this.Status = status;
            this.CustomHostname = customHostname;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponseOutput" /> class.
        /// </summary>
        public UpdateCustomHostnameResponseOutput()
        {
        }

    }
}