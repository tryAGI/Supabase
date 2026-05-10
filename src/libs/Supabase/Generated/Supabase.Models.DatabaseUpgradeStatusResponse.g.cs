
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatabaseUpgradeStatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("databaseUpgradeStatus")]
        public global::Supabase.DatabaseUpgradeStatusResponseDatabaseUpgradeStatus? DatabaseUpgradeStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseUpgradeStatusResponse" /> class.
        /// </summary>
        /// <param name="databaseUpgradeStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatabaseUpgradeStatusResponse(
            global::Supabase.DatabaseUpgradeStatusResponseDatabaseUpgradeStatus? databaseUpgradeStatus)
        {
            this.DatabaseUpgradeStatus = databaseUpgradeStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseUpgradeStatusResponse" /> class.
        /// </summary>
        public DatabaseUpgradeStatusResponse()
        {
        }

    }
}