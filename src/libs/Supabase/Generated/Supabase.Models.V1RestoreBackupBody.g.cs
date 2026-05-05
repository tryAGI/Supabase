
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"id":12345}
    /// </summary>
    public sealed partial class V1RestoreBackupBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1RestoreBackupBody" /> class.
        /// </summary>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1RestoreBackupBody(
            int id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1RestoreBackupBody" /> class.
        /// </summary>
        public V1RestoreBackupBody()
        {
        }
    }
}