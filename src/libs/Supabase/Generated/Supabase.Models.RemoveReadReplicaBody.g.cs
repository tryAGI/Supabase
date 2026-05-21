
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"database_identifier":"abcdefghijklmnopqrst-rr-us-west-1-abcde"}
    /// </summary>
    public sealed partial class RemoveReadReplicaBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatabaseIdentifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveReadReplicaBody" /> class.
        /// </summary>
        /// <param name="databaseIdentifier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveReadReplicaBody(
            string databaseIdentifier)
        {
            this.DatabaseIdentifier = databaseIdentifier ?? throw new global::System.ArgumentNullException(nameof(databaseIdentifier));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveReadReplicaBody" /> class.
        /// </summary>
        public RemoveReadReplicaBody()
        {
        }

    }
}