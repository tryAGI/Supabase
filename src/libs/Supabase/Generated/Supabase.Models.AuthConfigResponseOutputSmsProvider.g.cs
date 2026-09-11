
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum AuthConfigResponseOutputSmsProvider
    {
        /// <summary>
        ///
        /// </summary>
        Messagebird,
        /// <summary>
        ///
        /// </summary>
        Textlocal,
        /// <summary>
        ///
        /// </summary>
        Twilio,
        /// <summary>
        ///
        /// </summary>
        TwilioVerify,
        /// <summary>
        ///
        /// </summary>
        Vonage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthConfigResponseOutputSmsProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthConfigResponseOutputSmsProvider value)
        {
            return value switch
            {
                AuthConfigResponseOutputSmsProvider.Messagebird => "messagebird",
                AuthConfigResponseOutputSmsProvider.Textlocal => "textlocal",
                AuthConfigResponseOutputSmsProvider.Twilio => "twilio",
                AuthConfigResponseOutputSmsProvider.TwilioVerify => "twilio_verify",
                AuthConfigResponseOutputSmsProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthConfigResponseOutputSmsProvider? ToEnum(string value)
        {
            return value switch
            {
                "messagebird" => AuthConfigResponseOutputSmsProvider.Messagebird,
                "textlocal" => AuthConfigResponseOutputSmsProvider.Textlocal,
                "twilio" => AuthConfigResponseOutputSmsProvider.Twilio,
                "twilio_verify" => AuthConfigResponseOutputSmsProvider.TwilioVerify,
                "vonage" => AuthConfigResponseOutputSmsProvider.Vonage,
                _ => null,
            };
        }
    }
}