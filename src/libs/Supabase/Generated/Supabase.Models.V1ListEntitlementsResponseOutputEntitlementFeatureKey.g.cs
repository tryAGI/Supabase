
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1ListEntitlementsResponseOutputEntitlementFeatureKey
    {
        /// <summary>
        ///
        /// </summary>
        ApiMembersInvitations,
        /// <summary>
        ///
        /// </summary>
        ApiMembersRoles,
        /// <summary>
        ///
        /// </summary>
        AssistantAdvanceModel,
        /// <summary>
        ///
        /// </summary>
        AuditLogDrains,
        /// <summary>
        ///
        /// </summary>
        AuthAdvancedAuthSettings,
        /// <summary>
        ///
        /// </summary>
        AuthCustomJwtTemplate,
        /// <summary>
        ///
        /// </summary>
        AuthCustomOauthMaxProviders,
        /// <summary>
        ///
        /// </summary>
        AuthHooks,
        /// <summary>
        ///
        /// </summary>
        AuthLeakedPasswordProtection,
        /// <summary>
        ///
        /// </summary>
        AuthMfaEnhancedSecurity,
        /// <summary>
        ///
        /// </summary>
        AuthMfaPhone,
        /// <summary>
        ///
        /// </summary>
        AuthMfaWebAuthn,
        /// <summary>
        ///
        /// </summary>
        AuthPasswordHibp,
        /// <summary>
        ///
        /// </summary>
        AuthPerformanceSettings,
        /// <summary>
        ///
        /// </summary>
        AuthPlatformSso,
        /// <summary>
        ///
        /// </summary>
        AuthSaml2,
        /// <summary>
        ///
        /// </summary>
        AuthUserSessions,
        /// <summary>
        ///
        /// </summary>
        BackupRestoreToNewProject,
        /// <summary>
        ///
        /// </summary>
        BackupRetentionDays,
        /// <summary>
        ///
        /// </summary>
        BackupSchedule,
        /// <summary>
        ///
        /// </summary>
        BranchingLimit,
        /// <summary>
        ///
        /// </summary>
        BranchingPersistent,
        /// <summary>
        ///
        /// </summary>
        CustomDomain,
        /// <summary>
        ///
        /// </summary>
        DedicatedPooler,
        /// <summary>
        ///
        /// </summary>
        FunctionMaxCount,
        /// <summary>
        ///
        /// </summary>
        FunctionSizeLimitMb,
        /// <summary>
        ///
        /// </summary>
        InstancesComputeUpdateAvailableSizes,
        /// <summary>
        ///
        /// </summary>
        InstancesDiskModifications,
        /// <summary>
        ///
        /// </summary>
        InstancesHighAvailability,
        /// <summary>
        ///
        /// </summary>
        InstancesOrioledb,
        /// <summary>
        ///
        /// </summary>
        InstancesReadReplicas,
        /// <summary>
        ///
        /// </summary>
        IntegrationsGithubConnections,
        /// <summary>
        ///
        /// </summary>
        IntegrationsGithubPushWebhooksLimit,
        /// <summary>
        ///
        /// </summary>
        Ipv4,
        /// <summary>
        ///
        /// </summary>
        LogRetentionDays,
        /// <summary>
        ///
        /// </summary>
        LogDrains,
        /// <summary>
        ///
        /// </summary>
        ObservabilityDashboardAdvancedMetrics,
        /// <summary>
        ///
        /// </summary>
        PitrAvailableVariants,
        /// <summary>
        ///
        /// </summary>
        ProjectCloning,
        /// <summary>
        ///
        /// </summary>
        ProjectPausing,
        /// <summary>
        ///
        /// </summary>
        ProjectRestoreAfterExpiry,
        /// <summary>
        ///
        /// </summary>
        ProjectScopedRoles,
        /// <summary>
        ///
        /// </summary>
        RealtimeMaxBytesPerSecond,
        /// <summary>
        ///
        /// </summary>
        RealtimeMaxChannelsPerClient,
        /// <summary>
        ///
        /// </summary>
        RealtimeMaxConcurrentUsers,
        /// <summary>
        ///
        /// </summary>
        RealtimeMaxEventsPerSecond,
        /// <summary>
        ///
        /// </summary>
        RealtimeMaxJoinsPerSecond,
        /// <summary>
        ///
        /// </summary>
        RealtimeMaxPayloadSizeInKb,
        /// <summary>
        ///
        /// </summary>
        RealtimeMaxPresenceEventsPerSecond,
        /// <summary>
        ///
        /// </summary>
        ReplicationEtl,
        /// <summary>
        ///
        /// </summary>
        SecurityAuditLogsDays,
        /// <summary>
        ///
        /// </summary>
        SecurityEnforceMfa,
        /// <summary>
        ///
        /// </summary>
        SecurityIso27001Certificate,
        /// <summary>
        ///
        /// </summary>
        SecurityMemberRoles,
        /// <summary>
        ///
        /// </summary>
        SecurityPrivateLink,
        /// <summary>
        ///
        /// </summary>
        SecurityQuestionnaire,
        /// <summary>
        ///
        /// </summary>
        SecuritySoc2Report,
        /// <summary>
        ///
        /// </summary>
        StorageIcebergCatalog,
        /// <summary>
        ///
        /// </summary>
        StorageImageTransformations,
        /// <summary>
        ///
        /// </summary>
        StorageMaxFileSize,
        /// <summary>
        ///
        /// </summary>
        StorageMaxFileSizeConfigurable,
        /// <summary>
        ///
        /// </summary>
        StoragePurgeCache,
        /// <summary>
        ///
        /// </summary>
        StorageVectorBuckets,
        /// <summary>
        ///
        /// </summary>
        VanitySubdomain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ListEntitlementsResponseOutputEntitlementFeatureKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListEntitlementsResponseOutputEntitlementFeatureKey value)
        {
            return value switch
            {
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.ApiMembersInvitations => "api.members.invitations",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.ApiMembersRoles => "api.members.roles",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.AssistantAdvanceModel => "assistant.advance_model",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuditLogDrains => "audit_log_drains",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthAdvancedAuthSettings => "auth.advanced_auth_settings",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthCustomJwtTemplate => "auth.custom_jwt_template",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthCustomOauthMaxProviders => "auth.custom_oauth.max_providers",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthHooks => "auth.hooks",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthLeakedPasswordProtection => "auth.leaked_password_protection",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthMfaEnhancedSecurity => "auth.mfa_enhanced_security",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthMfaPhone => "auth.mfa_phone",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthMfaWebAuthn => "auth.mfa_web_authn",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthPasswordHibp => "auth.password_hibp",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthPerformanceSettings => "auth.performance_settings",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthPlatformSso => "auth.platform.sso",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthSaml2 => "auth.saml_2",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthUserSessions => "auth.user_sessions",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.BackupRestoreToNewProject => "backup.restore_to_new_project",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.BackupRetentionDays => "backup.retention_days",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.BackupSchedule => "backup.schedule",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.BranchingLimit => "branching_limit",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.BranchingPersistent => "branching_persistent",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.CustomDomain => "custom_domain",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.DedicatedPooler => "dedicated_pooler",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.FunctionMaxCount => "function.max_count",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.FunctionSizeLimitMb => "function.size_limit_mb",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.InstancesComputeUpdateAvailableSizes => "instances.compute_update_available_sizes",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.InstancesDiskModifications => "instances.disk_modifications",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.InstancesHighAvailability => "instances.high_availability",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.InstancesOrioledb => "instances.orioledb",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.InstancesReadReplicas => "instances.read_replicas",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.IntegrationsGithubConnections => "integrations.github_connections",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.IntegrationsGithubPushWebhooksLimit => "integrations.github_push_webhooks_limit",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.Ipv4 => "ipv4",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.LogRetentionDays => "log.retention_days",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.LogDrains => "log_drains",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.ObservabilityDashboardAdvancedMetrics => "observability.dashboard_advanced_metrics",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.PitrAvailableVariants => "pitr.available_variants",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.ProjectCloning => "project_cloning",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.ProjectPausing => "project_pausing",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.ProjectRestoreAfterExpiry => "project_restore_after_expiry",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.ProjectScopedRoles => "project_scoped_roles",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.RealtimeMaxBytesPerSecond => "realtime.max_bytes_per_second",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.RealtimeMaxChannelsPerClient => "realtime.max_channels_per_client",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.RealtimeMaxConcurrentUsers => "realtime.max_concurrent_users",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.RealtimeMaxEventsPerSecond => "realtime.max_events_per_second",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.RealtimeMaxJoinsPerSecond => "realtime.max_joins_per_second",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.RealtimeMaxPayloadSizeInKb => "realtime.max_payload_size_in_kb",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.RealtimeMaxPresenceEventsPerSecond => "realtime.max_presence_events_per_second",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.ReplicationEtl => "replication.etl",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.SecurityAuditLogsDays => "security.audit_logs_days",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.SecurityEnforceMfa => "security.enforce_mfa",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.SecurityIso27001Certificate => "security.iso27001_certificate",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.SecurityMemberRoles => "security.member_roles",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.SecurityPrivateLink => "security.private_link",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.SecurityQuestionnaire => "security.questionnaire",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.SecuritySoc2Report => "security.soc2_report",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.StorageIcebergCatalog => "storage.iceberg_catalog",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.StorageImageTransformations => "storage.image_transformations",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.StorageMaxFileSize => "storage.max_file_size",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.StorageMaxFileSizeConfigurable => "storage.max_file_size.configurable",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.StoragePurgeCache => "storage.purge_cache",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.StorageVectorBuckets => "storage.vector_buckets",
                V1ListEntitlementsResponseOutputEntitlementFeatureKey.VanitySubdomain => "vanity_subdomain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListEntitlementsResponseOutputEntitlementFeatureKey? ToEnum(string value)
        {
            return value switch
            {
                "api.members.invitations" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.ApiMembersInvitations,
                "api.members.roles" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.ApiMembersRoles,
                "assistant.advance_model" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.AssistantAdvanceModel,
                "audit_log_drains" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuditLogDrains,
                "auth.advanced_auth_settings" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthAdvancedAuthSettings,
                "auth.custom_jwt_template" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthCustomJwtTemplate,
                "auth.custom_oauth.max_providers" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthCustomOauthMaxProviders,
                "auth.hooks" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthHooks,
                "auth.leaked_password_protection" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthLeakedPasswordProtection,
                "auth.mfa_enhanced_security" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthMfaEnhancedSecurity,
                "auth.mfa_phone" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthMfaPhone,
                "auth.mfa_web_authn" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthMfaWebAuthn,
                "auth.password_hibp" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthPasswordHibp,
                "auth.performance_settings" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthPerformanceSettings,
                "auth.platform.sso" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthPlatformSso,
                "auth.saml_2" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthSaml2,
                "auth.user_sessions" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.AuthUserSessions,
                "backup.restore_to_new_project" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.BackupRestoreToNewProject,
                "backup.retention_days" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.BackupRetentionDays,
                "backup.schedule" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.BackupSchedule,
                "branching_limit" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.BranchingLimit,
                "branching_persistent" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.BranchingPersistent,
                "custom_domain" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.CustomDomain,
                "dedicated_pooler" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.DedicatedPooler,
                "function.max_count" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.FunctionMaxCount,
                "function.size_limit_mb" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.FunctionSizeLimitMb,
                "instances.compute_update_available_sizes" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.InstancesComputeUpdateAvailableSizes,
                "instances.disk_modifications" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.InstancesDiskModifications,
                "instances.high_availability" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.InstancesHighAvailability,
                "instances.orioledb" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.InstancesOrioledb,
                "instances.read_replicas" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.InstancesReadReplicas,
                "integrations.github_connections" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.IntegrationsGithubConnections,
                "integrations.github_push_webhooks_limit" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.IntegrationsGithubPushWebhooksLimit,
                "ipv4" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.Ipv4,
                "log.retention_days" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.LogRetentionDays,
                "log_drains" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.LogDrains,
                "observability.dashboard_advanced_metrics" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.ObservabilityDashboardAdvancedMetrics,
                "pitr.available_variants" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.PitrAvailableVariants,
                "project_cloning" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.ProjectCloning,
                "project_pausing" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.ProjectPausing,
                "project_restore_after_expiry" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.ProjectRestoreAfterExpiry,
                "project_scoped_roles" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.ProjectScopedRoles,
                "realtime.max_bytes_per_second" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.RealtimeMaxBytesPerSecond,
                "realtime.max_channels_per_client" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.RealtimeMaxChannelsPerClient,
                "realtime.max_concurrent_users" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.RealtimeMaxConcurrentUsers,
                "realtime.max_events_per_second" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.RealtimeMaxEventsPerSecond,
                "realtime.max_joins_per_second" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.RealtimeMaxJoinsPerSecond,
                "realtime.max_payload_size_in_kb" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.RealtimeMaxPayloadSizeInKb,
                "realtime.max_presence_events_per_second" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.RealtimeMaxPresenceEventsPerSecond,
                "replication.etl" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.ReplicationEtl,
                "security.audit_logs_days" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.SecurityAuditLogsDays,
                "security.enforce_mfa" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.SecurityEnforceMfa,
                "security.iso27001_certificate" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.SecurityIso27001Certificate,
                "security.member_roles" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.SecurityMemberRoles,
                "security.private_link" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.SecurityPrivateLink,
                "security.questionnaire" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.SecurityQuestionnaire,
                "security.soc2_report" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.SecuritySoc2Report,
                "storage.iceberg_catalog" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.StorageIcebergCatalog,
                "storage.image_transformations" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.StorageImageTransformations,
                "storage.max_file_size" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.StorageMaxFileSize,
                "storage.max_file_size.configurable" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.StorageMaxFileSizeConfigurable,
                "storage.purge_cache" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.StoragePurgeCache,
                "storage.vector_buckets" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.StorageVectorBuckets,
                "vanity_subdomain" => V1ListEntitlementsResponseOutputEntitlementFeatureKey.VanitySubdomain,
                _ => null,
            };
        }
    }
}