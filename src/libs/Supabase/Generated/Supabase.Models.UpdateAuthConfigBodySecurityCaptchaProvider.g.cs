
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAuthConfigBodySecurityCaptchaProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Hcaptcha,
        /// <summary>
        /// 
        /// </summary>
        Turnstile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAuthConfigBodySecurityCaptchaProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAuthConfigBodySecurityCaptchaProvider value)
        {
            return value switch
            {
                UpdateAuthConfigBodySecurityCaptchaProvider.Hcaptcha => "hcaptcha",
                UpdateAuthConfigBodySecurityCaptchaProvider.Turnstile => "turnstile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAuthConfigBodySecurityCaptchaProvider? ToEnum(string value)
        {
            return value switch
            {
                "hcaptcha" => UpdateAuthConfigBodySecurityCaptchaProvider.Hcaptcha,
                "turnstile" => UpdateAuthConfigBodySecurityCaptchaProvider.Turnstile,
                _ => null,
            };
        }
    }
}