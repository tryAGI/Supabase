
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1ServiceHealthResponseInfoVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ServiceHealthResponseInfoVariant3" /> class.
        /// </summary>
        /// <param name="dbSchema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ServiceHealthResponseInfoVariant3(
            string dbSchema)
        {
            this.DbSchema = dbSchema ?? throw new global::System.ArgumentNullException(nameof(dbSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ServiceHealthResponseInfoVariant3" /> class.
        /// </summary>
        public V1ServiceHealthResponseInfoVariant3()
        {
        }
    }
}