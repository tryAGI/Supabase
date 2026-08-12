
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlanGateErrorBody
    {
        /// <summary>
        /// Human-readable explanation of the plan gate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Present on entitlement denials. Other errors with this status code (validation, billing state) carry only message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Supabase.PlanGateErrorBodyError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanGateErrorBody" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable explanation of the plan gate
        /// </param>
        /// <param name="error">
        /// Present on entitlement denials. Other errors with this status code (validation, billing state) carry only message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlanGateErrorBody(
            string message,
            global::Supabase.PlanGateErrorBodyError? error)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanGateErrorBody" /> class.
        /// </summary>
        public PlanGateErrorBody()
        {
        }

    }
}