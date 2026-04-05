
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAuthConfigBodySmsProvider
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
    public static class UpdateAuthConfigBodySmsProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAuthConfigBodySmsProvider value)
        {
            return value switch
            {
                UpdateAuthConfigBodySmsProvider.Messagebird => "messagebird",
                UpdateAuthConfigBodySmsProvider.Textlocal => "textlocal",
                UpdateAuthConfigBodySmsProvider.Twilio => "twilio",
                UpdateAuthConfigBodySmsProvider.TwilioVerify => "twilio_verify",
                UpdateAuthConfigBodySmsProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAuthConfigBodySmsProvider? ToEnum(string value)
        {
            return value switch
            {
                "messagebird" => UpdateAuthConfigBodySmsProvider.Messagebird,
                "textlocal" => UpdateAuthConfigBodySmsProvider.Textlocal,
                "twilio" => UpdateAuthConfigBodySmsProvider.Twilio,
                "twilio_verify" => UpdateAuthConfigBodySmsProvider.TwilioVerify,
                "vonage" => UpdateAuthConfigBodySmsProvider.Vonage,
                _ => null,
            };
        }
    }
}