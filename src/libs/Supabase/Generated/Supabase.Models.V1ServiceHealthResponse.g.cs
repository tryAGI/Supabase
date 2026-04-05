
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1ServiceHealthResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ServiceHealthResponseNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ServiceHealthResponseName Name { get; set; }

        /// <summary>
        /// Deprecated. Use `status` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("healthy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Healthy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ServiceHealthResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ServiceHealthResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("info")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.V1ServiceHealthResponseInfoVariant1, global::Supabase.V1ServiceHealthResponseInfoVariant2, global::Supabase.V1ServiceHealthResponseInfoVariant3>))]
        public global::Supabase.OneOf<global::Supabase.V1ServiceHealthResponseInfoVariant1, global::Supabase.V1ServiceHealthResponseInfoVariant2, global::Supabase.V1ServiceHealthResponseInfoVariant3>? Info { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ServiceHealthResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="healthy">
        /// Deprecated. Use `status` instead.
        /// </param>
        /// <param name="status"></param>
        /// <param name="info"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ServiceHealthResponse(
            global::Supabase.V1ServiceHealthResponseName name,
            bool healthy,
            global::Supabase.V1ServiceHealthResponseStatus status,
            global::Supabase.OneOf<global::Supabase.V1ServiceHealthResponseInfoVariant1, global::Supabase.V1ServiceHealthResponseInfoVariant2, global::Supabase.V1ServiceHealthResponseInfoVariant3>? info,
            string? error)
        {
            this.Name = name;
            this.Healthy = healthy;
            this.Status = status;
            this.Info = info;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ServiceHealthResponse" /> class.
        /// </summary>
        public V1ServiceHealthResponse()
        {
        }
    }
}