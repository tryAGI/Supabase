
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeployFunctionResponseStatus
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
    public static class DeployFunctionResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeployFunctionResponseStatus value)
        {
            return value switch
            {
                DeployFunctionResponseStatus.Active => "ACTIVE",
                DeployFunctionResponseStatus.Removed => "REMOVED",
                DeployFunctionResponseStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeployFunctionResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => DeployFunctionResponseStatus.Active,
                "REMOVED" => DeployFunctionResponseStatus.Removed,
                "THROTTLED" => DeployFunctionResponseStatus.Throttled,
                _ => null,
            };
        }
    }
}