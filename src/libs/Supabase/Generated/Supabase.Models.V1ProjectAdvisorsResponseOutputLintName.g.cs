
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1ProjectAdvisorsResponseOutputLintName
    {
        /// <summary>
        ///
        /// </summary>
        AdvisorCheckUnavailable,
        /// <summary>
        ///
        /// </summary>
        AuthInsufficientMfaOptions,
        /// <summary>
        ///
        /// </summary>
        AuthLeakedPasswordProtection,
        /// <summary>
        ///
        /// </summary>
        AuthOtpLongExpiry,
        /// <summary>
        ///
        /// </summary>
        AuthOtpShortLength,
        /// <summary>
        ///
        /// </summary>
        AuthPasswordPolicyMissing,
        /// <summary>
        ///
        /// </summary>
        AuthRlsInitplan,
        /// <summary>
        ///
        /// </summary>
        AuthUsersExposed,
        /// <summary>
        ///
        /// </summary>
        DbConnectionFailing,
        /// <summary>
        ///
        /// </summary>
        DbConnectionLimitReached,
        /// <summary>
        ///
        /// </summary>
        DbNotReachable,
        /// <summary>
        ///
        /// </summary>
        DuplicateIndex,
        /// <summary>
        ///
        /// </summary>
        ExtensionInPublic,
        /// <summary>
        ///
        /// </summary>
        ForeignTableInApi,
        /// <summary>
        ///
        /// </summary>
        FunctionSearchPathMutable,
        /// <summary>
        ///
        /// </summary>
        InstanceAlertFiring,
        /// <summary>
        ///
        /// </summary>
        InstanceDbDown,
        /// <summary>
        ///
        /// </summary>
        InstanceTelemetryLost,
        /// <summary>
        ///
        /// </summary>
        LeakedServiceKey,
        /// <summary>
        ///
        /// </summary>
        LogAuthErrorRateHigh,
        /// <summary>
        ///
        /// </summary>
        LogConnectionsNotEnabled,
        /// <summary>
        ///
        /// </summary>
        LogDataApiErrorRateHigh,
        /// <summary>
        ///
        /// </summary>
        LogEdgeFunctionErrorRateHigh,
        /// <summary>
        ///
        /// </summary>
        LogStorageErrorRateHigh,
        /// <summary>
        ///
        /// </summary>
        MaterializedViewInApi,
        /// <summary>
        ///
        /// </summary>
        MultiplePermissivePolicies,
        /// <summary>
        ///
        /// </summary>
        NetworkRestrictionsNotSet,
        /// <summary>
        ///
        /// </summary>
        NoBackupAdmin,
        /// <summary>
        ///
        /// </summary>
        NoPrimaryKey,
        /// <summary>
        ///
        /// </summary>
        PasswordRequirementsMinLength,
        /// <summary>
        ///
        /// </summary>
        PitrNotEnabled,
        /// <summary>
        ///
        /// </summary>
        PolicyExistsRlsDisabled,
        /// <summary>
        ///
        /// </summary>
        ProjectNotActive,
        /// <summary>
        ///
        /// </summary>
        RlsDisabledInPublic,
        /// <summary>
        ///
        /// </summary>
        RlsEnabledNoPolicy,
        /// <summary>
        ///
        /// </summary>
        RlsReferencesUserMetadata,
        /// <summary>
        ///
        /// </summary>
        SecurityDefinerView,
        /// <summary>
        ///
        /// </summary>
        SslNotEnforced,
        /// <summary>
        ///
        /// </summary>
        UnindexedForeignKeys,
        /// <summary>
        ///
        /// </summary>
        UnsupportedRegTypes,
        /// <summary>
        ///
        /// </summary>
        UnusedIndex,
        /// <summary>
        ///
        /// </summary>
        VulnerablePostgresVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ProjectAdvisorsResponseOutputLintNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectAdvisorsResponseOutputLintName value)
        {
            return value switch
            {
                V1ProjectAdvisorsResponseOutputLintName.AdvisorCheckUnavailable => "advisor_check_unavailable",
                V1ProjectAdvisorsResponseOutputLintName.AuthInsufficientMfaOptions => "auth_insufficient_mfa_options",
                V1ProjectAdvisorsResponseOutputLintName.AuthLeakedPasswordProtection => "auth_leaked_password_protection",
                V1ProjectAdvisorsResponseOutputLintName.AuthOtpLongExpiry => "auth_otp_long_expiry",
                V1ProjectAdvisorsResponseOutputLintName.AuthOtpShortLength => "auth_otp_short_length",
                V1ProjectAdvisorsResponseOutputLintName.AuthPasswordPolicyMissing => "auth_password_policy_missing",
                V1ProjectAdvisorsResponseOutputLintName.AuthRlsInitplan => "auth_rls_initplan",
                V1ProjectAdvisorsResponseOutputLintName.AuthUsersExposed => "auth_users_exposed",
                V1ProjectAdvisorsResponseOutputLintName.DbConnectionFailing => "db_connection_failing",
                V1ProjectAdvisorsResponseOutputLintName.DbConnectionLimitReached => "db_connection_limit_reached",
                V1ProjectAdvisorsResponseOutputLintName.DbNotReachable => "db_not_reachable",
                V1ProjectAdvisorsResponseOutputLintName.DuplicateIndex => "duplicate_index",
                V1ProjectAdvisorsResponseOutputLintName.ExtensionInPublic => "extension_in_public",
                V1ProjectAdvisorsResponseOutputLintName.ForeignTableInApi => "foreign_table_in_api",
                V1ProjectAdvisorsResponseOutputLintName.FunctionSearchPathMutable => "function_search_path_mutable",
                V1ProjectAdvisorsResponseOutputLintName.InstanceAlertFiring => "instance_alert_firing",
                V1ProjectAdvisorsResponseOutputLintName.InstanceDbDown => "instance_db_down",
                V1ProjectAdvisorsResponseOutputLintName.InstanceTelemetryLost => "instance_telemetry_lost",
                V1ProjectAdvisorsResponseOutputLintName.LeakedServiceKey => "leaked_service_key",
                V1ProjectAdvisorsResponseOutputLintName.LogAuthErrorRateHigh => "log_auth_error_rate_high",
                V1ProjectAdvisorsResponseOutputLintName.LogConnectionsNotEnabled => "log_connections_not_enabled",
                V1ProjectAdvisorsResponseOutputLintName.LogDataApiErrorRateHigh => "log_data_api_error_rate_high",
                V1ProjectAdvisorsResponseOutputLintName.LogEdgeFunctionErrorRateHigh => "log_edge_function_error_rate_high",
                V1ProjectAdvisorsResponseOutputLintName.LogStorageErrorRateHigh => "log_storage_error_rate_high",
                V1ProjectAdvisorsResponseOutputLintName.MaterializedViewInApi => "materialized_view_in_api",
                V1ProjectAdvisorsResponseOutputLintName.MultiplePermissivePolicies => "multiple_permissive_policies",
                V1ProjectAdvisorsResponseOutputLintName.NetworkRestrictionsNotSet => "network_restrictions_not_set",
                V1ProjectAdvisorsResponseOutputLintName.NoBackupAdmin => "no_backup_admin",
                V1ProjectAdvisorsResponseOutputLintName.NoPrimaryKey => "no_primary_key",
                V1ProjectAdvisorsResponseOutputLintName.PasswordRequirementsMinLength => "password_requirements_min_length",
                V1ProjectAdvisorsResponseOutputLintName.PitrNotEnabled => "pitr_not_enabled",
                V1ProjectAdvisorsResponseOutputLintName.PolicyExistsRlsDisabled => "policy_exists_rls_disabled",
                V1ProjectAdvisorsResponseOutputLintName.ProjectNotActive => "project_not_active",
                V1ProjectAdvisorsResponseOutputLintName.RlsDisabledInPublic => "rls_disabled_in_public",
                V1ProjectAdvisorsResponseOutputLintName.RlsEnabledNoPolicy => "rls_enabled_no_policy",
                V1ProjectAdvisorsResponseOutputLintName.RlsReferencesUserMetadata => "rls_references_user_metadata",
                V1ProjectAdvisorsResponseOutputLintName.SecurityDefinerView => "security_definer_view",
                V1ProjectAdvisorsResponseOutputLintName.SslNotEnforced => "ssl_not_enforced",
                V1ProjectAdvisorsResponseOutputLintName.UnindexedForeignKeys => "unindexed_foreign_keys",
                V1ProjectAdvisorsResponseOutputLintName.UnsupportedRegTypes => "unsupported_reg_types",
                V1ProjectAdvisorsResponseOutputLintName.UnusedIndex => "unused_index",
                V1ProjectAdvisorsResponseOutputLintName.VulnerablePostgresVersion => "vulnerable_postgres_version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectAdvisorsResponseOutputLintName? ToEnum(string value)
        {
            return value switch
            {
                "advisor_check_unavailable" => V1ProjectAdvisorsResponseOutputLintName.AdvisorCheckUnavailable,
                "auth_insufficient_mfa_options" => V1ProjectAdvisorsResponseOutputLintName.AuthInsufficientMfaOptions,
                "auth_leaked_password_protection" => V1ProjectAdvisorsResponseOutputLintName.AuthLeakedPasswordProtection,
                "auth_otp_long_expiry" => V1ProjectAdvisorsResponseOutputLintName.AuthOtpLongExpiry,
                "auth_otp_short_length" => V1ProjectAdvisorsResponseOutputLintName.AuthOtpShortLength,
                "auth_password_policy_missing" => V1ProjectAdvisorsResponseOutputLintName.AuthPasswordPolicyMissing,
                "auth_rls_initplan" => V1ProjectAdvisorsResponseOutputLintName.AuthRlsInitplan,
                "auth_users_exposed" => V1ProjectAdvisorsResponseOutputLintName.AuthUsersExposed,
                "db_connection_failing" => V1ProjectAdvisorsResponseOutputLintName.DbConnectionFailing,
                "db_connection_limit_reached" => V1ProjectAdvisorsResponseOutputLintName.DbConnectionLimitReached,
                "db_not_reachable" => V1ProjectAdvisorsResponseOutputLintName.DbNotReachable,
                "duplicate_index" => V1ProjectAdvisorsResponseOutputLintName.DuplicateIndex,
                "extension_in_public" => V1ProjectAdvisorsResponseOutputLintName.ExtensionInPublic,
                "foreign_table_in_api" => V1ProjectAdvisorsResponseOutputLintName.ForeignTableInApi,
                "function_search_path_mutable" => V1ProjectAdvisorsResponseOutputLintName.FunctionSearchPathMutable,
                "instance_alert_firing" => V1ProjectAdvisorsResponseOutputLintName.InstanceAlertFiring,
                "instance_db_down" => V1ProjectAdvisorsResponseOutputLintName.InstanceDbDown,
                "instance_telemetry_lost" => V1ProjectAdvisorsResponseOutputLintName.InstanceTelemetryLost,
                "leaked_service_key" => V1ProjectAdvisorsResponseOutputLintName.LeakedServiceKey,
                "log_auth_error_rate_high" => V1ProjectAdvisorsResponseOutputLintName.LogAuthErrorRateHigh,
                "log_connections_not_enabled" => V1ProjectAdvisorsResponseOutputLintName.LogConnectionsNotEnabled,
                "log_data_api_error_rate_high" => V1ProjectAdvisorsResponseOutputLintName.LogDataApiErrorRateHigh,
                "log_edge_function_error_rate_high" => V1ProjectAdvisorsResponseOutputLintName.LogEdgeFunctionErrorRateHigh,
                "log_storage_error_rate_high" => V1ProjectAdvisorsResponseOutputLintName.LogStorageErrorRateHigh,
                "materialized_view_in_api" => V1ProjectAdvisorsResponseOutputLintName.MaterializedViewInApi,
                "multiple_permissive_policies" => V1ProjectAdvisorsResponseOutputLintName.MultiplePermissivePolicies,
                "network_restrictions_not_set" => V1ProjectAdvisorsResponseOutputLintName.NetworkRestrictionsNotSet,
                "no_backup_admin" => V1ProjectAdvisorsResponseOutputLintName.NoBackupAdmin,
                "no_primary_key" => V1ProjectAdvisorsResponseOutputLintName.NoPrimaryKey,
                "password_requirements_min_length" => V1ProjectAdvisorsResponseOutputLintName.PasswordRequirementsMinLength,
                "pitr_not_enabled" => V1ProjectAdvisorsResponseOutputLintName.PitrNotEnabled,
                "policy_exists_rls_disabled" => V1ProjectAdvisorsResponseOutputLintName.PolicyExistsRlsDisabled,
                "project_not_active" => V1ProjectAdvisorsResponseOutputLintName.ProjectNotActive,
                "rls_disabled_in_public" => V1ProjectAdvisorsResponseOutputLintName.RlsDisabledInPublic,
                "rls_enabled_no_policy" => V1ProjectAdvisorsResponseOutputLintName.RlsEnabledNoPolicy,
                "rls_references_user_metadata" => V1ProjectAdvisorsResponseOutputLintName.RlsReferencesUserMetadata,
                "security_definer_view" => V1ProjectAdvisorsResponseOutputLintName.SecurityDefinerView,
                "ssl_not_enforced" => V1ProjectAdvisorsResponseOutputLintName.SslNotEnforced,
                "unindexed_foreign_keys" => V1ProjectAdvisorsResponseOutputLintName.UnindexedForeignKeys,
                "unsupported_reg_types" => V1ProjectAdvisorsResponseOutputLintName.UnsupportedRegTypes,
                "unused_index" => V1ProjectAdvisorsResponseOutputLintName.UnusedIndex,
                "vulnerable_postgres_version" => V1ProjectAdvisorsResponseOutputLintName.VulnerablePostgresVersion,
                _ => null,
            };
        }
    }
}