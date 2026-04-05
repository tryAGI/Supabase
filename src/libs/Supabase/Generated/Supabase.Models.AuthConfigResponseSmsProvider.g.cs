
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthConfigResponseSmsProvider
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
    public static class AuthConfigResponseSmsProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthConfigResponseSmsProvider value)
        {
            return value switch
            {
                AuthConfigResponseSmsProvider.Messagebird => "messagebird",
                AuthConfigResponseSmsProvider.Textlocal => "textlocal",
                AuthConfigResponseSmsProvider.Twilio => "twilio",
                AuthConfigResponseSmsProvider.TwilioVerify => "twilio_verify",
                AuthConfigResponseSmsProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthConfigResponseSmsProvider? ToEnum(string value)
        {
            return value switch
            {
                "messagebird" => AuthConfigResponseSmsProvider.Messagebird,
                "textlocal" => AuthConfigResponseSmsProvider.Textlocal,
                "twilio" => AuthConfigResponseSmsProvider.Twilio,
                "twilio_verify" => AuthConfigResponseSmsProvider.TwilioVerify,
                "vonage" => AuthConfigResponseSmsProvider.Vonage,
                _ => null,
            };
        }
    }
}