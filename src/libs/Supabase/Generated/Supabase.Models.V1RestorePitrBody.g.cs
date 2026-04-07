
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"recovery_time_target_unix":1740787200}
    /// </summary>
    public sealed partial class V1RestorePitrBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recovery_time_target_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long RecoveryTimeTargetUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1RestorePitrBody" /> class.
        /// </summary>
        /// <param name="recoveryTimeTargetUnix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1RestorePitrBody(
            long recoveryTimeTargetUnix)
        {
            this.RecoveryTimeTargetUnix = recoveryTimeTargetUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1RestorePitrBody" /> class.
        /// </summary>
        public V1RestorePitrBody()
        {
        }
    }
}