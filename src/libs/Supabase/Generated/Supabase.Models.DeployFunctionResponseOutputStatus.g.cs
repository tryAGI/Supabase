
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum DeployFunctionResponseOutputStatus
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
    public static class DeployFunctionResponseOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeployFunctionResponseOutputStatus value)
        {
            return value switch
            {
                DeployFunctionResponseOutputStatus.Active => "ACTIVE",
                DeployFunctionResponseOutputStatus.Removed => "REMOVED",
                DeployFunctionResponseOutputStatus.Throttled => "THROTTLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeployFunctionResponseOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => DeployFunctionResponseOutputStatus.Active,
                "REMOVED" => DeployFunctionResponseOutputStatus.Removed,
                "THROTTLED" => DeployFunctionResponseOutputStatus.Throttled,
                _ => null,
            };
        }
    }
}