
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NetworkRestrictionsV2Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseEntitlementJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.NetworkRestrictionsV2ResponseEntitlement Entitlement { get; set; }

        /// <summary>
        /// At any given point in time, this is the config that the user has requested be applied to their project. The `status` field indicates if it has been applied to the project, or is pending. When an updated config is received, the applied config is moved to `old_config`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.NetworkRestrictionsV2ResponseConfig Config { get; set; }

        /// <summary>
        /// Populated when a new config has been received, but not registered as successfully applied to a project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_config")]
        public global::Supabase.NetworkRestrictionsV2ResponseOldConfig? OldConfig { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.NetworkRestrictionsV2ResponseStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsV2Response" /> class.
        /// </summary>
        /// <param name="entitlement"></param>
        /// <param name="config">
        /// At any given point in time, this is the config that the user has requested be applied to their project. The `status` field indicates if it has been applied to the project, or is pending. When an updated config is received, the applied config is moved to `old_config`.
        /// </param>
        /// <param name="status"></param>
        /// <param name="oldConfig">
        /// Populated when a new config has been received, but not registered as successfully applied to a project.
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="appliedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkRestrictionsV2Response(
            global::Supabase.NetworkRestrictionsV2ResponseEntitlement entitlement,
            global::Supabase.NetworkRestrictionsV2ResponseConfig config,
            global::Supabase.NetworkRestrictionsV2ResponseStatus status,
            global::Supabase.NetworkRestrictionsV2ResponseOldConfig? oldConfig,
            global::System.DateTime? updatedAt,
            global::System.DateTime? appliedAt)
        {
            this.Entitlement = entitlement;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.OldConfig = oldConfig;
            this.UpdatedAt = updatedAt;
            this.AppliedAt = appliedAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkRestrictionsV2Response" /> class.
        /// </summary>
        public NetworkRestrictionsV2Response()
        {
        }
    }
}