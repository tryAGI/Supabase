
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ProjectWithDatabaseResponseStatus
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
    public static class V1ProjectWithDatabaseResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectWithDatabaseResponseStatus value)
        {
            return value switch
            {
                V1ProjectWithDatabaseResponseStatus.ActiveHealthy => "ACTIVE_HEALTHY",
                V1ProjectWithDatabaseResponseStatus.ActiveUnhealthy => "ACTIVE_UNHEALTHY",
                V1ProjectWithDatabaseResponseStatus.ComingUp => "COMING_UP",
                V1ProjectWithDatabaseResponseStatus.GoingDown => "GOING_DOWN",
                V1ProjectWithDatabaseResponseStatus.Inactive => "INACTIVE",
                V1ProjectWithDatabaseResponseStatus.InitFailed => "INIT_FAILED",
                V1ProjectWithDatabaseResponseStatus.PauseFailed => "PAUSE_FAILED",
                V1ProjectWithDatabaseResponseStatus.Pausing => "PAUSING",
                V1ProjectWithDatabaseResponseStatus.Removed => "REMOVED",
                V1ProjectWithDatabaseResponseStatus.Resizing => "RESIZING",
                V1ProjectWithDatabaseResponseStatus.Restarting => "RESTARTING",
                V1ProjectWithDatabaseResponseStatus.RestoreFailed => "RESTORE_FAILED",
                V1ProjectWithDatabaseResponseStatus.Restoring => "RESTORING",
                V1ProjectWithDatabaseResponseStatus.Unknown => "UNKNOWN",
                V1ProjectWithDatabaseResponseStatus.Upgrading => "UPGRADING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectWithDatabaseResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_HEALTHY" => V1ProjectWithDatabaseResponseStatus.ActiveHealthy,
                "ACTIVE_UNHEALTHY" => V1ProjectWithDatabaseResponseStatus.ActiveUnhealthy,
                "COMING_UP" => V1ProjectWithDatabaseResponseStatus.ComingUp,
                "GOING_DOWN" => V1ProjectWithDatabaseResponseStatus.GoingDown,
                "INACTIVE" => V1ProjectWithDatabaseResponseStatus.Inactive,
                "INIT_FAILED" => V1ProjectWithDatabaseResponseStatus.InitFailed,
                "PAUSE_FAILED" => V1ProjectWithDatabaseResponseStatus.PauseFailed,
                "PAUSING" => V1ProjectWithDatabaseResponseStatus.Pausing,
                "REMOVED" => V1ProjectWithDatabaseResponseStatus.Removed,
                "RESIZING" => V1ProjectWithDatabaseResponseStatus.Resizing,
                "RESTARTING" => V1ProjectWithDatabaseResponseStatus.Restarting,
                "RESTORE_FAILED" => V1ProjectWithDatabaseResponseStatus.RestoreFailed,
                "RESTORING" => V1ProjectWithDatabaseResponseStatus.Restoring,
                "UNKNOWN" => V1ProjectWithDatabaseResponseStatus.Unknown,
                "UPGRADING" => V1ProjectWithDatabaseResponseStatus.Upgrading,
                _ => null,
            };
        }
    }
}