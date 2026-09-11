
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1ProjectWithDatabaseResponseOutputStatus
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
    public static class V1ProjectWithDatabaseResponseOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectWithDatabaseResponseOutputStatus value)
        {
            return value switch
            {
                V1ProjectWithDatabaseResponseOutputStatus.ActiveHealthy => "ACTIVE_HEALTHY",
                V1ProjectWithDatabaseResponseOutputStatus.ActiveUnhealthy => "ACTIVE_UNHEALTHY",
                V1ProjectWithDatabaseResponseOutputStatus.ComingUp => "COMING_UP",
                V1ProjectWithDatabaseResponseOutputStatus.GoingDown => "GOING_DOWN",
                V1ProjectWithDatabaseResponseOutputStatus.Inactive => "INACTIVE",
                V1ProjectWithDatabaseResponseOutputStatus.InitFailed => "INIT_FAILED",
                V1ProjectWithDatabaseResponseOutputStatus.PauseFailed => "PAUSE_FAILED",
                V1ProjectWithDatabaseResponseOutputStatus.Pausing => "PAUSING",
                V1ProjectWithDatabaseResponseOutputStatus.Removed => "REMOVED",
                V1ProjectWithDatabaseResponseOutputStatus.Resizing => "RESIZING",
                V1ProjectWithDatabaseResponseOutputStatus.Restarting => "RESTARTING",
                V1ProjectWithDatabaseResponseOutputStatus.RestoreFailed => "RESTORE_FAILED",
                V1ProjectWithDatabaseResponseOutputStatus.Restoring => "RESTORING",
                V1ProjectWithDatabaseResponseOutputStatus.Unknown => "UNKNOWN",
                V1ProjectWithDatabaseResponseOutputStatus.Upgrading => "UPGRADING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectWithDatabaseResponseOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_HEALTHY" => V1ProjectWithDatabaseResponseOutputStatus.ActiveHealthy,
                "ACTIVE_UNHEALTHY" => V1ProjectWithDatabaseResponseOutputStatus.ActiveUnhealthy,
                "COMING_UP" => V1ProjectWithDatabaseResponseOutputStatus.ComingUp,
                "GOING_DOWN" => V1ProjectWithDatabaseResponseOutputStatus.GoingDown,
                "INACTIVE" => V1ProjectWithDatabaseResponseOutputStatus.Inactive,
                "INIT_FAILED" => V1ProjectWithDatabaseResponseOutputStatus.InitFailed,
                "PAUSE_FAILED" => V1ProjectWithDatabaseResponseOutputStatus.PauseFailed,
                "PAUSING" => V1ProjectWithDatabaseResponseOutputStatus.Pausing,
                "REMOVED" => V1ProjectWithDatabaseResponseOutputStatus.Removed,
                "RESIZING" => V1ProjectWithDatabaseResponseOutputStatus.Resizing,
                "RESTARTING" => V1ProjectWithDatabaseResponseOutputStatus.Restarting,
                "RESTORE_FAILED" => V1ProjectWithDatabaseResponseOutputStatus.RestoreFailed,
                "RESTORING" => V1ProjectWithDatabaseResponseOutputStatus.Restoring,
                "UNKNOWN" => V1ProjectWithDatabaseResponseOutputStatus.Unknown,
                "UPGRADING" => V1ProjectWithDatabaseResponseOutputStatus.Upgrading,
                _ => null,
            };
        }
    }
}