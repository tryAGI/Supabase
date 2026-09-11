
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1ServiceHealthResponseOutputStatus
    {
        /// <summary>
        ///
        /// </summary>
        ActiveHealthy,
        /// <summary>
        ///
        /// </summary>
        ComingUp,
        /// <summary>
        ///
        /// </summary>
        Unhealthy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ServiceHealthResponseOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ServiceHealthResponseOutputStatus value)
        {
            return value switch
            {
                V1ServiceHealthResponseOutputStatus.ActiveHealthy => "ACTIVE_HEALTHY",
                V1ServiceHealthResponseOutputStatus.ComingUp => "COMING_UP",
                V1ServiceHealthResponseOutputStatus.Unhealthy => "UNHEALTHY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ServiceHealthResponseOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_HEALTHY" => V1ServiceHealthResponseOutputStatus.ActiveHealthy,
                "COMING_UP" => V1ServiceHealthResponseOutputStatus.ComingUp,
                "UNHEALTHY" => V1ServiceHealthResponseOutputStatus.Unhealthy,
                _ => null,
            };
        }
    }
}