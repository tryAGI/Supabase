
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListProjectAddonsResponseOutputAvailableAddonType
    {
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
        ComputeInstance,
        /// <summary>
        ///
        /// </summary>
        CustomDomain,
        /// <summary>
        ///
        /// </summary>
        EtlPipeline,
        /// <summary>
        ///
        /// </summary>
        Ipv4,
        /// <summary>
        ///
        /// </summary>
        LogDrain,
        /// <summary>
        ///
        /// </summary>
        Pitr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseOutputAvailableAddonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseOutputAvailableAddonType value)
        {
            return value switch
            {
                ListProjectAddonsResponseOutputAvailableAddonType.AuthMfaPhone => "auth_mfa_phone",
                ListProjectAddonsResponseOutputAvailableAddonType.AuthMfaWebAuthn => "auth_mfa_web_authn",
                ListProjectAddonsResponseOutputAvailableAddonType.ComputeInstance => "compute_instance",
                ListProjectAddonsResponseOutputAvailableAddonType.CustomDomain => "custom_domain",
                ListProjectAddonsResponseOutputAvailableAddonType.EtlPipeline => "etl_pipeline",
                ListProjectAddonsResponseOutputAvailableAddonType.Ipv4 => "ipv4",
                ListProjectAddonsResponseOutputAvailableAddonType.LogDrain => "log_drain",
                ListProjectAddonsResponseOutputAvailableAddonType.Pitr => "pitr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseOutputAvailableAddonType? ToEnum(string value)
        {
            return value switch
            {
                "auth_mfa_phone" => ListProjectAddonsResponseOutputAvailableAddonType.AuthMfaPhone,
                "auth_mfa_web_authn" => ListProjectAddonsResponseOutputAvailableAddonType.AuthMfaWebAuthn,
                "compute_instance" => ListProjectAddonsResponseOutputAvailableAddonType.ComputeInstance,
                "custom_domain" => ListProjectAddonsResponseOutputAvailableAddonType.CustomDomain,
                "etl_pipeline" => ListProjectAddonsResponseOutputAvailableAddonType.EtlPipeline,
                "ipv4" => ListProjectAddonsResponseOutputAvailableAddonType.Ipv4,
                "log_drain" => ListProjectAddonsResponseOutputAvailableAddonType.LogDrain,
                "pitr" => ListProjectAddonsResponseOutputAvailableAddonType.Pitr,
                _ => null,
            };
        }
    }
}