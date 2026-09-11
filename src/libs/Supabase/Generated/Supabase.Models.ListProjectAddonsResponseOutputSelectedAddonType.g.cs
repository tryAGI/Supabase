
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ListProjectAddonsResponseOutputSelectedAddonType
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
    public static class ListProjectAddonsResponseOutputSelectedAddonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseOutputSelectedAddonType value)
        {
            return value switch
            {
                ListProjectAddonsResponseOutputSelectedAddonType.AuthMfaPhone => "auth_mfa_phone",
                ListProjectAddonsResponseOutputSelectedAddonType.AuthMfaWebAuthn => "auth_mfa_web_authn",
                ListProjectAddonsResponseOutputSelectedAddonType.ComputeInstance => "compute_instance",
                ListProjectAddonsResponseOutputSelectedAddonType.CustomDomain => "custom_domain",
                ListProjectAddonsResponseOutputSelectedAddonType.EtlPipeline => "etl_pipeline",
                ListProjectAddonsResponseOutputSelectedAddonType.Ipv4 => "ipv4",
                ListProjectAddonsResponseOutputSelectedAddonType.LogDrain => "log_drain",
                ListProjectAddonsResponseOutputSelectedAddonType.Pitr => "pitr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseOutputSelectedAddonType? ToEnum(string value)
        {
            return value switch
            {
                "auth_mfa_phone" => ListProjectAddonsResponseOutputSelectedAddonType.AuthMfaPhone,
                "auth_mfa_web_authn" => ListProjectAddonsResponseOutputSelectedAddonType.AuthMfaWebAuthn,
                "compute_instance" => ListProjectAddonsResponseOutputSelectedAddonType.ComputeInstance,
                "custom_domain" => ListProjectAddonsResponseOutputSelectedAddonType.CustomDomain,
                "etl_pipeline" => ListProjectAddonsResponseOutputSelectedAddonType.EtlPipeline,
                "ipv4" => ListProjectAddonsResponseOutputSelectedAddonType.Ipv4,
                "log_drain" => ListProjectAddonsResponseOutputSelectedAddonType.LogDrain,
                "pitr" => ListProjectAddonsResponseOutputSelectedAddonType.Pitr,
                _ => null,
            };
        }
    }
}