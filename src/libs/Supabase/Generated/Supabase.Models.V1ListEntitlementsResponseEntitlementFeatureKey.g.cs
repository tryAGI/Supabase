
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ListEntitlementsResponseEntitlementFeatureKey
    {
        /// <summary>
        /// 
        /// </summary>
        AssistantAdvanceModel,
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
        StorageVectorBuckets,
        /// <summary>
        /// 
        /// </summary>
        VanitySubdomain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ListEntitlementsResponseEntitlementFeatureKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListEntitlementsResponseEntitlementFeatureKey value)
        {
            return value switch
            {
                V1ListEntitlementsResponseEntitlementFeatureKey.AssistantAdvanceModel => "assistant.advance_model",
                V1ListEntitlementsResponseEntitlementFeatureKey.AuthAdvancedAuthSettings => "auth.advanced_auth_settings",
                V1ListEntitlementsResponseEntitlementFeatureKey.AuthCustomJwtTemplate => "auth.custom_jwt_template",
                V1ListEntitlementsResponseEntitlementFeatureKey.AuthHooks => "auth.hooks",
                V1ListEntitlementsResponseEntitlementFeatureKey.AuthLeakedPasswordProtection => "auth.leaked_password_protection",
                V1ListEntitlementsResponseEntitlementFeatureKey.AuthMfaEnhancedSecurity => "auth.mfa_enhanced_security",
                V1ListEntitlementsResponseEntitlementFeatureKey.AuthMfaPhone => "auth.mfa_phone",
                V1ListEntitlementsResponseEntitlementFeatureKey.AuthMfaWebAuthn => "auth.mfa_web_authn",
                V1ListEntitlementsResponseEntitlementFeatureKey.AuthPasswordHibp => "auth.password_hibp",
                V1ListEntitlementsResponseEntitlementFeatureKey.AuthPerformanceSettings => "auth.performance_settings",
                V1ListEntitlementsResponseEntitlementFeatureKey.AuthPlatformSso => "auth.platform.sso",
                V1ListEntitlementsResponseEntitlementFeatureKey.AuthSaml2 => "auth.saml_2",
                V1ListEntitlementsResponseEntitlementFeatureKey.AuthUserSessions => "auth.user_sessions",
                V1ListEntitlementsResponseEntitlementFeatureKey.BackupRestoreToNewProject => "backup.restore_to_new_project",
                V1ListEntitlementsResponseEntitlementFeatureKey.BackupRetentionDays => "backup.retention_days",
                V1ListEntitlementsResponseEntitlementFeatureKey.BranchingLimit => "branching_limit",
                V1ListEntitlementsResponseEntitlementFeatureKey.BranchingPersistent => "branching_persistent",
                V1ListEntitlementsResponseEntitlementFeatureKey.CustomDomain => "custom_domain",
                V1ListEntitlementsResponseEntitlementFeatureKey.DedicatedPooler => "dedicated_pooler",
                V1ListEntitlementsResponseEntitlementFeatureKey.FunctionMaxCount => "function.max_count",
                V1ListEntitlementsResponseEntitlementFeatureKey.FunctionSizeLimitMb => "function.size_limit_mb",
                V1ListEntitlementsResponseEntitlementFeatureKey.InstancesComputeUpdateAvailableSizes => "instances.compute_update_available_sizes",
                V1ListEntitlementsResponseEntitlementFeatureKey.InstancesDiskModifications => "instances.disk_modifications",
                V1ListEntitlementsResponseEntitlementFeatureKey.InstancesHighAvailability => "instances.high_availability",
                V1ListEntitlementsResponseEntitlementFeatureKey.InstancesOrioledb => "instances.orioledb",
                V1ListEntitlementsResponseEntitlementFeatureKey.InstancesReadReplicas => "instances.read_replicas",
                V1ListEntitlementsResponseEntitlementFeatureKey.IntegrationsGithubConnections => "integrations.github_connections",
                V1ListEntitlementsResponseEntitlementFeatureKey.Ipv4 => "ipv4",
                V1ListEntitlementsResponseEntitlementFeatureKey.LogRetentionDays => "log.retention_days",
                V1ListEntitlementsResponseEntitlementFeatureKey.LogDrains => "log_drains",
                V1ListEntitlementsResponseEntitlementFeatureKey.ObservabilityDashboardAdvancedMetrics => "observability.dashboard_advanced_metrics",
                V1ListEntitlementsResponseEntitlementFeatureKey.PitrAvailableVariants => "pitr.available_variants",
                V1ListEntitlementsResponseEntitlementFeatureKey.ProjectCloning => "project_cloning",
                V1ListEntitlementsResponseEntitlementFeatureKey.ProjectPausing => "project_pausing",
                V1ListEntitlementsResponseEntitlementFeatureKey.ProjectRestoreAfterExpiry => "project_restore_after_expiry",
                V1ListEntitlementsResponseEntitlementFeatureKey.ProjectScopedRoles => "project_scoped_roles",
                V1ListEntitlementsResponseEntitlementFeatureKey.RealtimeMaxBytesPerSecond => "realtime.max_bytes_per_second",
                V1ListEntitlementsResponseEntitlementFeatureKey.RealtimeMaxChannelsPerClient => "realtime.max_channels_per_client",
                V1ListEntitlementsResponseEntitlementFeatureKey.RealtimeMaxConcurrentUsers => "realtime.max_concurrent_users",
                V1ListEntitlementsResponseEntitlementFeatureKey.RealtimeMaxEventsPerSecond => "realtime.max_events_per_second",
                V1ListEntitlementsResponseEntitlementFeatureKey.RealtimeMaxJoinsPerSecond => "realtime.max_joins_per_second",
                V1ListEntitlementsResponseEntitlementFeatureKey.RealtimeMaxPayloadSizeInKb => "realtime.max_payload_size_in_kb",
                V1ListEntitlementsResponseEntitlementFeatureKey.RealtimeMaxPresenceEventsPerSecond => "realtime.max_presence_events_per_second",
                V1ListEntitlementsResponseEntitlementFeatureKey.ReplicationEtl => "replication.etl",
                V1ListEntitlementsResponseEntitlementFeatureKey.SecurityAuditLogsDays => "security.audit_logs_days",
                V1ListEntitlementsResponseEntitlementFeatureKey.SecurityEnforceMfa => "security.enforce_mfa",
                V1ListEntitlementsResponseEntitlementFeatureKey.SecurityMemberRoles => "security.member_roles",
                V1ListEntitlementsResponseEntitlementFeatureKey.SecurityPrivateLink => "security.private_link",
                V1ListEntitlementsResponseEntitlementFeatureKey.SecurityQuestionnaire => "security.questionnaire",
                V1ListEntitlementsResponseEntitlementFeatureKey.SecuritySoc2Report => "security.soc2_report",
                V1ListEntitlementsResponseEntitlementFeatureKey.StorageIcebergCatalog => "storage.iceberg_catalog",
                V1ListEntitlementsResponseEntitlementFeatureKey.StorageImageTransformations => "storage.image_transformations",
                V1ListEntitlementsResponseEntitlementFeatureKey.StorageMaxFileSize => "storage.max_file_size",
                V1ListEntitlementsResponseEntitlementFeatureKey.StorageMaxFileSizeConfigurable => "storage.max_file_size.configurable",
                V1ListEntitlementsResponseEntitlementFeatureKey.StorageVectorBuckets => "storage.vector_buckets",
                V1ListEntitlementsResponseEntitlementFeatureKey.VanitySubdomain => "vanity_subdomain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListEntitlementsResponseEntitlementFeatureKey? ToEnum(string value)
        {
            return value switch
            {
                "assistant.advance_model" => V1ListEntitlementsResponseEntitlementFeatureKey.AssistantAdvanceModel,
                "auth.advanced_auth_settings" => V1ListEntitlementsResponseEntitlementFeatureKey.AuthAdvancedAuthSettings,
                "auth.custom_jwt_template" => V1ListEntitlementsResponseEntitlementFeatureKey.AuthCustomJwtTemplate,
                "auth.hooks" => V1ListEntitlementsResponseEntitlementFeatureKey.AuthHooks,
                "auth.leaked_password_protection" => V1ListEntitlementsResponseEntitlementFeatureKey.AuthLeakedPasswordProtection,
                "auth.mfa_enhanced_security" => V1ListEntitlementsResponseEntitlementFeatureKey.AuthMfaEnhancedSecurity,
                "auth.mfa_phone" => V1ListEntitlementsResponseEntitlementFeatureKey.AuthMfaPhone,
                "auth.mfa_web_authn" => V1ListEntitlementsResponseEntitlementFeatureKey.AuthMfaWebAuthn,
                "auth.password_hibp" => V1ListEntitlementsResponseEntitlementFeatureKey.AuthPasswordHibp,
                "auth.performance_settings" => V1ListEntitlementsResponseEntitlementFeatureKey.AuthPerformanceSettings,
                "auth.platform.sso" => V1ListEntitlementsResponseEntitlementFeatureKey.AuthPlatformSso,
                "auth.saml_2" => V1ListEntitlementsResponseEntitlementFeatureKey.AuthSaml2,
                "auth.user_sessions" => V1ListEntitlementsResponseEntitlementFeatureKey.AuthUserSessions,
                "backup.restore_to_new_project" => V1ListEntitlementsResponseEntitlementFeatureKey.BackupRestoreToNewProject,
                "backup.retention_days" => V1ListEntitlementsResponseEntitlementFeatureKey.BackupRetentionDays,
                "branching_limit" => V1ListEntitlementsResponseEntitlementFeatureKey.BranchingLimit,
                "branching_persistent" => V1ListEntitlementsResponseEntitlementFeatureKey.BranchingPersistent,
                "custom_domain" => V1ListEntitlementsResponseEntitlementFeatureKey.CustomDomain,
                "dedicated_pooler" => V1ListEntitlementsResponseEntitlementFeatureKey.DedicatedPooler,
                "function.max_count" => V1ListEntitlementsResponseEntitlementFeatureKey.FunctionMaxCount,
                "function.size_limit_mb" => V1ListEntitlementsResponseEntitlementFeatureKey.FunctionSizeLimitMb,
                "instances.compute_update_available_sizes" => V1ListEntitlementsResponseEntitlementFeatureKey.InstancesComputeUpdateAvailableSizes,
                "instances.disk_modifications" => V1ListEntitlementsResponseEntitlementFeatureKey.InstancesDiskModifications,
                "instances.high_availability" => V1ListEntitlementsResponseEntitlementFeatureKey.InstancesHighAvailability,
                "instances.orioledb" => V1ListEntitlementsResponseEntitlementFeatureKey.InstancesOrioledb,
                "instances.read_replicas" => V1ListEntitlementsResponseEntitlementFeatureKey.InstancesReadReplicas,
                "integrations.github_connections" => V1ListEntitlementsResponseEntitlementFeatureKey.IntegrationsGithubConnections,
                "ipv4" => V1ListEntitlementsResponseEntitlementFeatureKey.Ipv4,
                "log.retention_days" => V1ListEntitlementsResponseEntitlementFeatureKey.LogRetentionDays,
                "log_drains" => V1ListEntitlementsResponseEntitlementFeatureKey.LogDrains,
                "observability.dashboard_advanced_metrics" => V1ListEntitlementsResponseEntitlementFeatureKey.ObservabilityDashboardAdvancedMetrics,
                "pitr.available_variants" => V1ListEntitlementsResponseEntitlementFeatureKey.PitrAvailableVariants,
                "project_cloning" => V1ListEntitlementsResponseEntitlementFeatureKey.ProjectCloning,
                "project_pausing" => V1ListEntitlementsResponseEntitlementFeatureKey.ProjectPausing,
                "project_restore_after_expiry" => V1ListEntitlementsResponseEntitlementFeatureKey.ProjectRestoreAfterExpiry,
                "project_scoped_roles" => V1ListEntitlementsResponseEntitlementFeatureKey.ProjectScopedRoles,
                "realtime.max_bytes_per_second" => V1ListEntitlementsResponseEntitlementFeatureKey.RealtimeMaxBytesPerSecond,
                "realtime.max_channels_per_client" => V1ListEntitlementsResponseEntitlementFeatureKey.RealtimeMaxChannelsPerClient,
                "realtime.max_concurrent_users" => V1ListEntitlementsResponseEntitlementFeatureKey.RealtimeMaxConcurrentUsers,
                "realtime.max_events_per_second" => V1ListEntitlementsResponseEntitlementFeatureKey.RealtimeMaxEventsPerSecond,
                "realtime.max_joins_per_second" => V1ListEntitlementsResponseEntitlementFeatureKey.RealtimeMaxJoinsPerSecond,
                "realtime.max_payload_size_in_kb" => V1ListEntitlementsResponseEntitlementFeatureKey.RealtimeMaxPayloadSizeInKb,
                "realtime.max_presence_events_per_second" => V1ListEntitlementsResponseEntitlementFeatureKey.RealtimeMaxPresenceEventsPerSecond,
                "replication.etl" => V1ListEntitlementsResponseEntitlementFeatureKey.ReplicationEtl,
                "security.audit_logs_days" => V1ListEntitlementsResponseEntitlementFeatureKey.SecurityAuditLogsDays,
                "security.enforce_mfa" => V1ListEntitlementsResponseEntitlementFeatureKey.SecurityEnforceMfa,
                "security.member_roles" => V1ListEntitlementsResponseEntitlementFeatureKey.SecurityMemberRoles,
                "security.private_link" => V1ListEntitlementsResponseEntitlementFeatureKey.SecurityPrivateLink,
                "security.questionnaire" => V1ListEntitlementsResponseEntitlementFeatureKey.SecurityQuestionnaire,
                "security.soc2_report" => V1ListEntitlementsResponseEntitlementFeatureKey.SecuritySoc2Report,
                "storage.iceberg_catalog" => V1ListEntitlementsResponseEntitlementFeatureKey.StorageIcebergCatalog,
                "storage.image_transformations" => V1ListEntitlementsResponseEntitlementFeatureKey.StorageImageTransformations,
                "storage.max_file_size" => V1ListEntitlementsResponseEntitlementFeatureKey.StorageMaxFileSize,
                "storage.max_file_size.configurable" => V1ListEntitlementsResponseEntitlementFeatureKey.StorageMaxFileSizeConfigurable,
                "storage.vector_buckets" => V1ListEntitlementsResponseEntitlementFeatureKey.StorageVectorBuckets,
                "vanity_subdomain" => V1ListEntitlementsResponseEntitlementFeatureKey.VanitySubdomain,
                _ => null,
            };
        }
    }
}