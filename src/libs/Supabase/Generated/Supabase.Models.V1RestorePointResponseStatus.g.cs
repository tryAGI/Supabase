
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1RestorePointResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Available,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Removed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1RestorePointResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1RestorePointResponseStatus value)
        {
            return value switch
            {
                V1RestorePointResponseStatus.Available => "AVAILABLE",
                V1RestorePointResponseStatus.Failed => "FAILED",
                V1RestorePointResponseStatus.Pending => "PENDING",
                V1RestorePointResponseStatus.Removed => "REMOVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1RestorePointResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "AVAILABLE" => V1RestorePointResponseStatus.Available,
                "FAILED" => V1RestorePointResponseStatus.Failed,
                "PENDING" => V1RestorePointResponseStatus.Pending,
                "REMOVED" => V1RestorePointResponseStatus.Removed,
                _ => null,
            };
        }
    }
}