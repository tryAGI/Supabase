
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateRunStatusResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        Ok,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRunStatusResponseMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRunStatusResponseMessage value)
        {
            return value switch
            {
                UpdateRunStatusResponseMessage.Ok => "ok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRunStatusResponseMessage? ToEnum(string value)
        {
            return value switch
            {
                "ok" => UpdateRunStatusResponseMessage.Ok,
                _ => null,
            };
        }
    }
}