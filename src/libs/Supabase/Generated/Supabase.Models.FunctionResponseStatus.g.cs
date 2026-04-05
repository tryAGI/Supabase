
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionResponseStatus
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
    public static class FunctionResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionResponseStatus value)
        {
            return value switch
            {
                FunctionResponseStatus.Active => "ACTIVE",
                FunctionResponseStatus.Removed => "REMOVED",
                FunctionResponseStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => FunctionResponseStatus.Active,
                "REMOVED" => FunctionResponseStatus.Removed,
                "THROTTLED" => FunctionResponseStatus.Throttled,
                _ => null,
            };
        }
    }
}