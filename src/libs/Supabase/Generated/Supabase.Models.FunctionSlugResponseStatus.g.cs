
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionSlugResponseStatus
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
    public static class FunctionSlugResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionSlugResponseStatus value)
        {
            return value switch
            {
                FunctionSlugResponseStatus.Active => "ACTIVE",
                FunctionSlugResponseStatus.Removed => "REMOVED",
                FunctionSlugResponseStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionSlugResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => FunctionSlugResponseStatus.Active,
                "REMOVED" => FunctionSlugResponseStatus.Removed,
                "THROTTLED" => FunctionSlugResponseStatus.Throttled,
                _ => null,
            };
        }
    }
}