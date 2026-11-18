
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NetworkRestrictionsResponseOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.NetworkRestrictionsResponseOutputEntitlementJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.NetworkRestrictionsResponseOutputEntitlement Entitlement { get; set; }

        /// <summary>
        /// At any given point in time, this is the config that the user has requested be applied to their project. The `status` field indicates if it has been applied to the project, or is pending. When an updated config is received, the applied config is moved to `old_config`.<br/>
        /// Example: {"dbAllowedCidrs":["203.0.113.0/24"],"dbAllowedCidrsV6":["2001:db8::/32"]}
        /// </summary>
        /// <example>{"dbAllowedCidrs":["203.0.113.0/24"],"dbAllowedCidrsV6":["2001:db8::/32"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.NetworkRestrictionsResponseOutputConfig Config { get; set; }

        /// <summary>
        /// Populated when a new config has been received, but not registered as successfully applied to a project.<br/>
        /// Example: {"dbAllowedCidrs":["203.0.113.0/24"],"dbAllowedCidrsV6":["2001:db8::/32"]}
        /// </summary>
        /// <example>{"dbAllowedCidrs":["203.0.113.0/24"],"dbAllowedCidrsV6":["2001:db8::/32"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_config")]
        public global::Supabase.NetworkRestrictionsResponseOutputOldConfig? OldConfig { get; set; }

        /// <summary>
        /// Present when a change that was never applied is waiting for review. `config` is the list the project enforces. Apply or reject the change with `POST /v1/projects/{ref}/network-restrictions/review`; submitting a new config also replaces it.<br/>
        /// Example: {"dbAllowedCidrs":["203.0.113.0/24"],"dbAllowedCidrsV6":["2001:db8::/32"]}
        /// </summary>
        /// <example>{"dbAllowedCidrs":["203.0.113.0/24"],"dbAllowedCidrsV6":["2001:db8::/32"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_config")]
        public global::Supabase.NetworkRestrictionsResponseOutputPendingConfig? PendingConfig { get; set; }

        /// <summary>
        /// When the change in `pending_config` was requested. Send it as `requested_at` to the review endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_requested_at")]
        public global::System.DateTime? PendingRequestedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.NetworkRestrictionsResponseOutputStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.NetworkRestrictionsResponseOutputStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applied_at")]
        public global::System.DateTime? AppliedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsResponseOutput" /> class.
        /// </summary>
        /// <param name="entitlement"></param>
        /// <param name="config">
        /// At any given point in time, this is the config that the user has requested be applied to their project. The `status` field indicates if it has been applied to the project, or is pending. When an updated config is received, the applied config is moved to `old_config`.<br/>
        /// Example: {"dbAllowedCidrs":["203.0.113.0/24"],"dbAllowedCidrsV6":["2001:db8::/32"]}
        /// </param>
        /// <param name="status"></param>
        /// <param name="oldConfig">
        /// Populated when a new config has been received, but not registered as successfully applied to a project.<br/>
        /// Example: {"dbAllowedCidrs":["203.0.113.0/24"],"dbAllowedCidrsV6":["2001:db8::/32"]}
        /// </param>
        /// <param name="pendingConfig">
        /// Present when a change that was never applied is waiting for review. `config` is the list the project enforces. Apply or reject the change with `POST /v1/projects/{ref}/network-restrictions/review`; submitting a new config also replaces it.<br/>
        /// Example: {"dbAllowedCidrs":["203.0.113.0/24"],"dbAllowedCidrsV6":["2001:db8::/32"]}
        /// </param>
        /// <param name="pendingRequestedAt">
        /// When the change in `pending_config` was requested. Send it as `requested_at` to the review endpoint.
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="appliedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkRestrictionsResponseOutput(
            global::Supabase.NetworkRestrictionsResponseOutputEntitlement entitlement,
            global::Supabase.NetworkRestrictionsResponseOutputConfig config,
            global::Supabase.NetworkRestrictionsResponseOutputStatus status,
            global::Supabase.NetworkRestrictionsResponseOutputOldConfig? oldConfig,
            global::Supabase.NetworkRestrictionsResponseOutputPendingConfig? pendingConfig,
            global::System.DateTime? pendingRequestedAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? appliedAt)
        {
            this.Entitlement = entitlement;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.OldConfig = oldConfig;
            this.PendingConfig = pendingConfig;
            this.PendingRequestedAt = pendingRequestedAt;
            this.Status = status;
            this.UpdatedAt = updatedAt;
            this.AppliedAt = appliedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsResponseOutput" /> class.
        /// </summary>
        public NetworkRestrictionsResponseOutput()
        {
        }

    }
}