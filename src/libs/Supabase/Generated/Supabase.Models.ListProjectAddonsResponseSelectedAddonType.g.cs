
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectAddonsResponseSelectedAddonType
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
    public static class ListProjectAddonsResponseSelectedAddonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseSelectedAddonType value)
        {
            return value switch
            {
                ListProjectAddonsResponseSelectedAddonType.AuthMfaPhone => "auth_mfa_phone",
                ListProjectAddonsResponseSelectedAddonType.AuthMfaWebAuthn => "auth_mfa_web_authn",
                ListProjectAddonsResponseSelectedAddonType.ComputeInstance => "compute_instance",
                ListProjectAddonsResponseSelectedAddonType.CustomDomain => "custom_domain",
                ListProjectAddonsResponseSelectedAddonType.Ipv4 => "ipv4",
                ListProjectAddonsResponseSelectedAddonType.LogDrain => "log_drain",
                ListProjectAddonsResponseSelectedAddonType.Pitr => "pitr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseSelectedAddonType? ToEnum(string value)
        {
            return value switch
            {
                "auth_mfa_phone" => ListProjectAddonsResponseSelectedAddonType.AuthMfaPhone,
                "auth_mfa_web_authn" => ListProjectAddonsResponseSelectedAddonType.AuthMfaWebAuthn,
                "compute_instance" => ListProjectAddonsResponseSelectedAddonType.ComputeInstance,
                "custom_domain" => ListProjectAddonsResponseSelectedAddonType.CustomDomain,
                "ipv4" => ListProjectAddonsResponseSelectedAddonType.Ipv4,
                "log_drain" => ListProjectAddonsResponseSelectedAddonType.LogDrain,
                "pitr" => ListProjectAddonsResponseSelectedAddonType.Pitr,
                _ => null,
            };
        }
    }
}