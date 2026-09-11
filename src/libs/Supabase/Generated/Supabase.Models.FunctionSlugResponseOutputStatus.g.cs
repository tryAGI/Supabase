
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionSlugResponseOutputStatus
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
    public static class FunctionSlugResponseOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionSlugResponseOutputStatus value)
        {
            return value switch
            {
                FunctionSlugResponseOutputStatus.Active => "ACTIVE",
                FunctionSlugResponseOutputStatus.Removed => "REMOVED",
                FunctionSlugResponseOutputStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionSlugResponseOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => FunctionSlugResponseOutputStatus.Active,
                "REMOVED" => FunctionSlugResponseOutputStatus.Removed,
                "THROTTLED" => FunctionSlugResponseOutputStatus.Throttled,
                _ => null,
            };
        }
    }
}