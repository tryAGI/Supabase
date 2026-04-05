
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectAddonsResponseAvailableAddonType
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
    public static class ListProjectAddonsResponseAvailableAddonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseAvailableAddonType value)
        {
            return value switch
            {
                ListProjectAddonsResponseAvailableAddonType.AuthMfaPhone => "auth_mfa_phone",
                ListProjectAddonsResponseAvailableAddonType.AuthMfaWebAuthn => "auth_mfa_web_authn",
                ListProjectAddonsResponseAvailableAddonType.ComputeInstance => "compute_instance",
                ListProjectAddonsResponseAvailableAddonType.CustomDomain => "custom_domain",
                ListProjectAddonsResponseAvailableAddonType.Ipv4 => "ipv4",
                ListProjectAddonsResponseAvailableAddonType.LogDrain => "log_drain",
                ListProjectAddonsResponseAvailableAddonType.Pitr => "pitr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseAvailableAddonType? ToEnum(string value)
        {
            return value switch
            {
                "auth_mfa_phone" => ListProjectAddonsResponseAvailableAddonType.AuthMfaPhone,
                "auth_mfa_web_authn" => ListProjectAddonsResponseAvailableAddonType.AuthMfaWebAuthn,
                "compute_instance" => ListProjectAddonsResponseAvailableAddonType.ComputeInstance,
                "custom_domain" => ListProjectAddonsResponseAvailableAddonType.CustomDomain,
                "ipv4" => ListProjectAddonsResponseAvailableAddonType.Ipv4,
                "log_drain" => ListProjectAddonsResponseAvailableAddonType.LogDrain,
                "pitr" => ListProjectAddonsResponseAvailableAddonType.Pitr,
                _ => null,
            };
        }
    }
}