
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ProjectResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        ActiveHealthy,
        /// <summary>
        /// 
        /// </summary>
        ActiveUnhealthy,
        /// <summary>
        /// 
        /// </summary>
        ComingUp,
        /// <summary>
        /// 
        /// </summary>
        GoingDown,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        InitFailed,
        /// <summary>
        /// 
        /// </summary>
        PauseFailed,
        /// <summary>
        /// 
        /// </summary>
        Pausing,
        /// <summary>
        /// 
        /// </summary>
        Removed,
        /// <summary>
        /// 
        /// </summary>
        Resizing,
        /// <summary>
        /// 
        /// </summary>
        Restarting,
        /// <summary>
        /// 
        /// </summary>
        RestoreFailed,
        /// <summary>
        /// 
        /// </summary>
        Restoring,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Upgrading,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ProjectResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectResponseStatus value)
        {
            return value switch
            {
                V1ProjectResponseStatus.ActiveHealthy => "ACTIVE_HEALTHY",
                V1ProjectResponseStatus.ActiveUnhealthy => "ACTIVE_UNHEALTHY",
                V1ProjectResponseStatus.ComingUp => "COMING_UP",
                V1ProjectResponseStatus.GoingDown => "GOING_DOWN",
                V1ProjectResponseStatus.Inactive => "INACTIVE",
                V1ProjectResponseStatus.InitFailed => "INIT_FAILED",
                V1ProjectResponseStatus.PauseFailed => "PAUSE_FAILED",
                V1ProjectResponseStatus.Pausing => "PAUSING",
                V1ProjectResponseStatus.Removed => "REMOVED",
                V1ProjectResponseStatus.Resizing => "RESIZING",
                V1ProjectResponseStatus.Restarting => "RESTARTING",
                V1ProjectResponseStatus.RestoreFailed => "RESTORE_FAILED",
                V1ProjectResponseStatus.Restoring => "RESTORING",
                V1ProjectResponseStatus.Unknown => "UNKNOWN",
                V1ProjectResponseStatus.Upgrading => "UPGRADING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_HEALTHY" => V1ProjectResponseStatus.ActiveHealthy,
                "ACTIVE_UNHEALTHY" => V1ProjectResponseStatus.ActiveUnhealthy,
                "COMING_UP" => V1ProjectResponseStatus.ComingUp,
                "GOING_DOWN" => V1ProjectResponseStatus.GoingDown,
                "INACTIVE" => V1ProjectResponseStatus.Inactive,
                "INIT_FAILED" => V1ProjectResponseStatus.InitFailed,
                "PAUSE_FAILED" => V1ProjectResponseStatus.PauseFailed,
                "PAUSING" => V1ProjectResponseStatus.Pausing,
                "REMOVED" => V1ProjectResponseStatus.Removed,
                "RESIZING" => V1ProjectResponseStatus.Resizing,
                "RESTARTING" => V1ProjectResponseStatus.Restarting,
                "RESTORE_FAILED" => V1ProjectResponseStatus.RestoreFailed,
                "RESTORING" => V1ProjectResponseStatus.Restoring,
                "UNKNOWN" => V1ProjectResponseStatus.Unknown,
                "UPGRADING" => V1ProjectResponseStatus.Upgrading,
                _ => null,
            };
        }
    }
}