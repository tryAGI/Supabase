
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthConfigResponseSecurityCaptchaProvider
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
    public static class AuthConfigResponseSecurityCaptchaProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthConfigResponseSecurityCaptchaProvider value)
        {
            return value switch
            {
                AuthConfigResponseSecurityCaptchaProvider.Hcaptcha => "hcaptcha",
                AuthConfigResponseSecurityCaptchaProvider.Turnstile => "turnstile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthConfigResponseSecurityCaptchaProvider? ToEnum(string value)
        {
            return value switch
            {
                "hcaptcha" => AuthConfigResponseSecurityCaptchaProvider.Hcaptcha,
                "turnstile" => AuthConfigResponseSecurityCaptchaProvider.Turnstile,
                _ => null,
            };
        }
    }
}