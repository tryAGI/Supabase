
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum AuthConfigResponseOutputSecurityCaptchaProvider
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
    public static class AuthConfigResponseOutputSecurityCaptchaProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthConfigResponseOutputSecurityCaptchaProvider value)
        {
            return value switch
            {
                AuthConfigResponseOutputSecurityCaptchaProvider.Hcaptcha => "hcaptcha",
                AuthConfigResponseOutputSecurityCaptchaProvider.Turnstile => "turnstile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthConfigResponseOutputSecurityCaptchaProvider? ToEnum(string value)
        {
            return value switch
            {
                "hcaptcha" => AuthConfigResponseOutputSecurityCaptchaProvider.Hcaptcha,
                "turnstile" => AuthConfigResponseOutputSecurityCaptchaProvider.Turnstile,
                _ => null,
            };
        }
    }
}