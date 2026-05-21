
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"custom_hostname":"docs.example.com"}
    /// </summary>
    public sealed partial class UpdateCustomHostnameBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_hostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomHostname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameBody" /> class.
        /// </summary>
        /// <param name="customHostname"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomHostnameBody(
            string customHostname)
        {
            this.CustomHostname = customHostname ?? throw new global::System.ArgumentNullException(nameof(customHostname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomHostnameBody" /> class.
        /// </summary>
        public UpdateCustomHostnameBody()
        {
        }

    }
}