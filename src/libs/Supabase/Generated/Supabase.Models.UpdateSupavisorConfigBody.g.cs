
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSupavisorConfigBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_pool_size")]
        public int? DefaultPoolSize { get; set; }

        /// <summary>
        /// Dedicated pooler mode for the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.UpdateSupavisorConfigBodyPoolModeJsonConverter))]
        public global::Supabase.UpdateSupavisorConfigBodyPoolMode? PoolMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSupavisorConfigBody" /> class.
        /// </summary>
        /// <param name="defaultPoolSize"></param>
        /// <param name="poolMode">
        /// Dedicated pooler mode for the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSupavisorConfigBody(
            int? defaultPoolSize,
            global::Supabase.UpdateSupavisorConfigBodyPoolMode? poolMode)
        {
            this.DefaultPoolSize = defaultPoolSize;
            this.PoolMode = poolMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSupavisorConfigBody" /> class.
        /// </summary>
        public UpdateSupavisorConfigBody()
        {
        }
    }
}