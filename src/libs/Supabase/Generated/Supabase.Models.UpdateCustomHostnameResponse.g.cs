
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCustomHostnameResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.UpdateCustomHostnameResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.UpdateCustomHostnameResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_hostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomHostname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.UpdateCustomHostnameResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="customHostname"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomHostnameResponse(
            global::Supabase.UpdateCustomHostnameResponseStatus status,
            string customHostname,
            global::Supabase.UpdateCustomHostnameResponseData data)
        {
            this.Status = status;
            this.CustomHostname = customHostname ?? throw new global::System.ArgumentNullException(nameof(customHostname));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameResponse" /> class.
        /// </summary>
        public UpdateCustomHostnameResponse()
        {
        }

    }
}