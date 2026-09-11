
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class V1ServiceHealthResponseOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ServiceHealthResponseOutputNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ServiceHealthResponseOutputName Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ServiceHealthResponseOutputStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1ServiceHealthResponseOutputStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("info")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.AnyOfJsonConverter<global::Supabase.V1ServiceHealthResponseOutputInfoVariant1, global::Supabase.V1ServiceHealthResponseOutputInfoVariant2, global::Supabase.V1ServiceHealthResponseOutputInfoVariant3>))]
        public global::Supabase.AnyOf<global::Supabase.V1ServiceHealthResponseOutputInfoVariant1, global::Supabase.V1ServiceHealthResponseOutputInfoVariant2, global::Supabase.V1ServiceHealthResponseOutputInfoVariant3>? Info { get; set; }

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
        /// Initializes a new instance of the <see cref="V1ServiceHealthResponseOutput" /> class.
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
        public V1ServiceHealthResponseOutput(
            global::Supabase.V1ServiceHealthResponseOutputName name,
            bool healthy,
            global::Supabase.V1ServiceHealthResponseOutputStatus status,
            global::Supabase.AnyOf<global::Supabase.V1ServiceHealthResponseOutputInfoVariant1, global::Supabase.V1ServiceHealthResponseOutputInfoVariant2, global::Supabase.V1ServiceHealthResponseOutputInfoVariant3>? info,
            string? error)
        {
            this.Name = name;
            this.Healthy = healthy;
            this.Status = status;
            this.Info = info;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ServiceHealthResponseOutput" /> class.
        /// </summary>
        public V1ServiceHealthResponseOutput()
        {
        }

    }
}