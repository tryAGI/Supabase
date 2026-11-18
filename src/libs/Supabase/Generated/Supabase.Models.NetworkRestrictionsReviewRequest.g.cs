
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"action":"apply","requested_at":"2026-10-21T20:31:51.116\u002B00:00"}
    /// </summary>
    public sealed partial class NetworkRestrictionsReviewRequest
    {
        /// <summary>
        /// `apply` replaces the enforced list with the pending one and applies it. `reject` discards the pending one and keeps the enforced list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.NetworkRestrictionsReviewRequestActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.NetworkRestrictionsReviewRequestAction Action { get; set; }

        /// <summary>
        /// The `pending_requested_at` of the change being reviewed. Only that change is resolved: if another one has replaced it, the request gets a 409.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RequestedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsReviewRequest" /> class.
        /// </summary>
        /// <param name="action">
        /// `apply` replaces the enforced list with the pending one and applies it. `reject` discards the pending one and keeps the enforced list.
        /// </param>
        /// <param name="requestedAt">
        /// The `pending_requested_at` of the change being reviewed. Only that change is resolved: if another one has replaced it, the request gets a 409.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkRestrictionsReviewRequest(
            global::Supabase.NetworkRestrictionsReviewRequestAction action,
            global::System.DateTime requestedAt)
        {
            this.Action = action;
            this.RequestedAt = requestedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsReviewRequest" /> class.
        /// </summary>
        public NetworkRestrictionsReviewRequest()
        {
        }

    }
}