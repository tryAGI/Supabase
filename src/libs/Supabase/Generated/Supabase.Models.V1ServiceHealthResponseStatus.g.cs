
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ServiceHealthResponseStatus
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
    public static class V1ServiceHealthResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ServiceHealthResponseStatus value)
        {
            return value switch
            {
                V1ServiceHealthResponseStatus.ActiveHealthy => "ACTIVE_HEALTHY",
                V1ServiceHealthResponseStatus.ComingUp => "COMING_UP",
                V1ServiceHealthResponseStatus.Unhealthy => "UNHEALTHY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ServiceHealthResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_HEALTHY" => V1ServiceHealthResponseStatus.ActiveHealthy,
                "COMING_UP" => V1ServiceHealthResponseStatus.ComingUp,
                "UNHEALTHY" => V1ServiceHealthResponseStatus.Unhealthy,
                _ => null,
            };
        }
    }
}