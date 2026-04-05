
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSupavisorConfigResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_pool_size")]
        public int? DefaultPoolSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PoolMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSupavisorConfigResponse" /> class.
        /// </summary>
        /// <param name="poolMode"></param>
        /// <param name="defaultPoolSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSupavisorConfigResponse(
            string poolMode,
            int? defaultPoolSize)
        {
            this.DefaultPoolSize = defaultPoolSize;
            this.PoolMode = poolMode ?? throw new global::System.ArgumentNullException(nameof(poolMode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSupavisorConfigResponse" /> class.
        /// </summary>
        public UpdateSupavisorConfigResponse()
        {
        }
    }
}