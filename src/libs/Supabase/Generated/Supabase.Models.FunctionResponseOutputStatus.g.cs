
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionResponseOutputStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Removed,
        /// <summary>
        ///
        /// </summary>
        Throttled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionResponseOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionResponseOutputStatus value)
        {
            return value switch
            {
                FunctionResponseOutputStatus.Active => "ACTIVE",
                FunctionResponseOutputStatus.Removed => "REMOVED",
                FunctionResponseOutputStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionResponseOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => FunctionResponseOutputStatus.Active,
                "REMOVED" => FunctionResponseOutputStatus.Removed,
                "THROTTLED" => FunctionResponseOutputStatus.Throttled,
                _ => null,
            };
        }
    }
}