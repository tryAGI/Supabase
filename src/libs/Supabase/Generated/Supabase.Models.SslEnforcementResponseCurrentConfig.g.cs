
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SslEnforcementResponseCurrentConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Database { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SslEnforcementResponseCurrentConfig" /> class.
        /// </summary>
        /// <param name="database"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SslEnforcementResponseCurrentConfig(
            bool database)
        {
            this.Database = database;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SslEnforcementResponseCurrentConfig" /> class.
        /// </summary>
        public SslEnforcementResponseCurrentConfig()
        {
        }
    }
}