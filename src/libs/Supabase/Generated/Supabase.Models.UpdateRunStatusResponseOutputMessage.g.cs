
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateRunStatusResponseOutputMessage
    {
        /// <summary>
        ///
        /// </summary>
        Ok,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRunStatusResponseOutputMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRunStatusResponseOutputMessage value)
        {
            return value switch
            {
                UpdateRunStatusResponseOutputMessage.Ok => "ok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRunStatusResponseOutputMessage? ToEnum(string value)
        {
            return value switch
            {
                "ok" => UpdateRunStatusResponseOutputMessage.Ok,
                _ => null,
            };
        }
    }
}