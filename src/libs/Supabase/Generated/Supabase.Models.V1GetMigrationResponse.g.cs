
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1GetMigrationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statements")]
        public global::System.Collections.Generic.IList<string>? Statements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollback")]
        public global::System.Collections.Generic.IList<string>? Rollback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idempotency_key")]
        public string? IdempotencyKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1GetMigrationResponse" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="name"></param>
        /// <param name="statements"></param>
        /// <param name="rollback"></param>
        /// <param name="createdBy"></param>
        /// <param name="idempotencyKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1GetMigrationResponse(
            string version,
            string? name,
            global::System.Collections.Generic.IList<string>? statements,
            global::System.Collections.Generic.IList<string>? rollback,
            string? createdBy,
            string? idempotencyKey)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Name = name;
            this.Statements = statements;
            this.Rollback = rollback;
            this.CreatedBy = createdBy;
            this.IdempotencyKey = idempotencyKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1GetMigrationResponse" /> class.
        /// </summary>
        public V1GetMigrationResponse()
        {
        }
    }
}