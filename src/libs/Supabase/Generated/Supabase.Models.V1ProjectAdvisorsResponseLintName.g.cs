
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ProjectAdvisorsResponseLintName
    {
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
        LeakedServiceKey,
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
    public static class V1ProjectAdvisorsResponseLintNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectAdvisorsResponseLintName value)
        {
            return value switch
            {
                V1ProjectAdvisorsResponseLintName.AuthInsufficientMfaOptions => "auth_insufficient_mfa_options",
                V1ProjectAdvisorsResponseLintName.AuthLeakedPasswordProtection => "auth_leaked_password_protection",
                V1ProjectAdvisorsResponseLintName.AuthOtpLongExpiry => "auth_otp_long_expiry",
                V1ProjectAdvisorsResponseLintName.AuthOtpShortLength => "auth_otp_short_length",
                V1ProjectAdvisorsResponseLintName.AuthPasswordPolicyMissing => "auth_password_policy_missing",
                V1ProjectAdvisorsResponseLintName.AuthRlsInitplan => "auth_rls_initplan",
                V1ProjectAdvisorsResponseLintName.AuthUsersExposed => "auth_users_exposed",
                V1ProjectAdvisorsResponseLintName.DuplicateIndex => "duplicate_index",
                V1ProjectAdvisorsResponseLintName.ExtensionInPublic => "extension_in_public",
                V1ProjectAdvisorsResponseLintName.ForeignTableInApi => "foreign_table_in_api",
                V1ProjectAdvisorsResponseLintName.FunctionSearchPathMutable => "function_search_path_mutable",
                V1ProjectAdvisorsResponseLintName.LeakedServiceKey => "leaked_service_key",
                V1ProjectAdvisorsResponseLintName.MaterializedViewInApi => "materialized_view_in_api",
                V1ProjectAdvisorsResponseLintName.MultiplePermissivePolicies => "multiple_permissive_policies",
                V1ProjectAdvisorsResponseLintName.NetworkRestrictionsNotSet => "network_restrictions_not_set",
                V1ProjectAdvisorsResponseLintName.NoBackupAdmin => "no_backup_admin",
                V1ProjectAdvisorsResponseLintName.NoPrimaryKey => "no_primary_key",
                V1ProjectAdvisorsResponseLintName.PasswordRequirementsMinLength => "password_requirements_min_length",
                V1ProjectAdvisorsResponseLintName.PitrNotEnabled => "pitr_not_enabled",
                V1ProjectAdvisorsResponseLintName.PolicyExistsRlsDisabled => "policy_exists_rls_disabled",
                V1ProjectAdvisorsResponseLintName.RlsDisabledInPublic => "rls_disabled_in_public",
                V1ProjectAdvisorsResponseLintName.RlsEnabledNoPolicy => "rls_enabled_no_policy",
                V1ProjectAdvisorsResponseLintName.RlsReferencesUserMetadata => "rls_references_user_metadata",
                V1ProjectAdvisorsResponseLintName.SecurityDefinerView => "security_definer_view",
                V1ProjectAdvisorsResponseLintName.SslNotEnforced => "ssl_not_enforced",
                V1ProjectAdvisorsResponseLintName.UnindexedForeignKeys => "unindexed_foreign_keys",
                V1ProjectAdvisorsResponseLintName.UnsupportedRegTypes => "unsupported_reg_types",
                V1ProjectAdvisorsResponseLintName.UnusedIndex => "unused_index",
                V1ProjectAdvisorsResponseLintName.VulnerablePostgresVersion => "vulnerable_postgres_version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectAdvisorsResponseLintName? ToEnum(string value)
        {
            return value switch
            {
                "auth_insufficient_mfa_options" => V1ProjectAdvisorsResponseLintName.AuthInsufficientMfaOptions,
                "auth_leaked_password_protection" => V1ProjectAdvisorsResponseLintName.AuthLeakedPasswordProtection,
                "auth_otp_long_expiry" => V1ProjectAdvisorsResponseLintName.AuthOtpLongExpiry,
                "auth_otp_short_length" => V1ProjectAdvisorsResponseLintName.AuthOtpShortLength,
                "auth_password_policy_missing" => V1ProjectAdvisorsResponseLintName.AuthPasswordPolicyMissing,
                "auth_rls_initplan" => V1ProjectAdvisorsResponseLintName.AuthRlsInitplan,
                "auth_users_exposed" => V1ProjectAdvisorsResponseLintName.AuthUsersExposed,
                "duplicate_index" => V1ProjectAdvisorsResponseLintName.DuplicateIndex,
                "extension_in_public" => V1ProjectAdvisorsResponseLintName.ExtensionInPublic,
                "foreign_table_in_api" => V1ProjectAdvisorsResponseLintName.ForeignTableInApi,
                "function_search_path_mutable" => V1ProjectAdvisorsResponseLintName.FunctionSearchPathMutable,
                "leaked_service_key" => V1ProjectAdvisorsResponseLintName.LeakedServiceKey,
                "materialized_view_in_api" => V1ProjectAdvisorsResponseLintName.MaterializedViewInApi,
                "multiple_permissive_policies" => V1ProjectAdvisorsResponseLintName.MultiplePermissivePolicies,
                "network_restrictions_not_set" => V1ProjectAdvisorsResponseLintName.NetworkRestrictionsNotSet,
                "no_backup_admin" => V1ProjectAdvisorsResponseLintName.NoBackupAdmin,
                "no_primary_key" => V1ProjectAdvisorsResponseLintName.NoPrimaryKey,
                "password_requirements_min_length" => V1ProjectAdvisorsResponseLintName.PasswordRequirementsMinLength,
                "pitr_not_enabled" => V1ProjectAdvisorsResponseLintName.PitrNotEnabled,
                "policy_exists_rls_disabled" => V1ProjectAdvisorsResponseLintName.PolicyExistsRlsDisabled,
                "rls_disabled_in_public" => V1ProjectAdvisorsResponseLintName.RlsDisabledInPublic,
                "rls_enabled_no_policy" => V1ProjectAdvisorsResponseLintName.RlsEnabledNoPolicy,
                "rls_references_user_metadata" => V1ProjectAdvisorsResponseLintName.RlsReferencesUserMetadata,
                "security_definer_view" => V1ProjectAdvisorsResponseLintName.SecurityDefinerView,
                "ssl_not_enforced" => V1ProjectAdvisorsResponseLintName.SslNotEnforced,
                "unindexed_foreign_keys" => V1ProjectAdvisorsResponseLintName.UnindexedForeignKeys,
                "unsupported_reg_types" => V1ProjectAdvisorsResponseLintName.UnsupportedRegTypes,
                "unused_index" => V1ProjectAdvisorsResponseLintName.UnusedIndex,
                "vulnerable_postgres_version" => V1ProjectAdvisorsResponseLintName.VulnerablePostgresVersion,
                _ => null,
            };
        }
    }
}