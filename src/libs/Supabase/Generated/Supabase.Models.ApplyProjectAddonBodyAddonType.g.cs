
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyProjectAddonBodyAddonType
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
    public static class ApplyProjectAddonBodyAddonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyProjectAddonBodyAddonType value)
        {
            return value switch
            {
                ApplyProjectAddonBodyAddonType.AuthMfaPhone => "auth_mfa_phone",
                ApplyProjectAddonBodyAddonType.AuthMfaWebAuthn => "auth_mfa_web_authn",
                ApplyProjectAddonBodyAddonType.ComputeInstance => "compute_instance",
                ApplyProjectAddonBodyAddonType.CustomDomain => "custom_domain",
                ApplyProjectAddonBodyAddonType.Ipv4 => "ipv4",
                ApplyProjectAddonBodyAddonType.LogDrain => "log_drain",
                ApplyProjectAddonBodyAddonType.Pitr => "pitr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyProjectAddonBodyAddonType? ToEnum(string value)
        {
            return value switch
            {
                "auth_mfa_phone" => ApplyProjectAddonBodyAddonType.AuthMfaPhone,
                "auth_mfa_web_authn" => ApplyProjectAddonBodyAddonType.AuthMfaWebAuthn,
                "compute_instance" => ApplyProjectAddonBodyAddonType.ComputeInstance,
                "custom_domain" => ApplyProjectAddonBodyAddonType.CustomDomain,
                "ipv4" => ApplyProjectAddonBodyAddonType.Ipv4,
                "log_drain" => ApplyProjectAddonBodyAddonType.LogDrain,
                "pitr" => ApplyProjectAddonBodyAddonType.Pitr,
                _ => null,
            };
        }
    }
}