
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1ProjectResponseOutputStatus
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
    public static class V1ProjectResponseOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectResponseOutputStatus value)
        {
            return value switch
            {
                V1ProjectResponseOutputStatus.ActiveHealthy => "ACTIVE_HEALTHY",
                V1ProjectResponseOutputStatus.ActiveUnhealthy => "ACTIVE_UNHEALTHY",
                V1ProjectResponseOutputStatus.ComingUp => "COMING_UP",
                V1ProjectResponseOutputStatus.GoingDown => "GOING_DOWN",
                V1ProjectResponseOutputStatus.Inactive => "INACTIVE",
                V1ProjectResponseOutputStatus.InitFailed => "INIT_FAILED",
                V1ProjectResponseOutputStatus.PauseFailed => "PAUSE_FAILED",
                V1ProjectResponseOutputStatus.Pausing => "PAUSING",
                V1ProjectResponseOutputStatus.Removed => "REMOVED",
                V1ProjectResponseOutputStatus.Resizing => "RESIZING",
                V1ProjectResponseOutputStatus.Restarting => "RESTARTING",
                V1ProjectResponseOutputStatus.RestoreFailed => "RESTORE_FAILED",
                V1ProjectResponseOutputStatus.Restoring => "RESTORING",
                V1ProjectResponseOutputStatus.Unknown => "UNKNOWN",
                V1ProjectResponseOutputStatus.Upgrading => "UPGRADING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectResponseOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_HEALTHY" => V1ProjectResponseOutputStatus.ActiveHealthy,
                "ACTIVE_UNHEALTHY" => V1ProjectResponseOutputStatus.ActiveUnhealthy,
                "COMING_UP" => V1ProjectResponseOutputStatus.ComingUp,
                "GOING_DOWN" => V1ProjectResponseOutputStatus.GoingDown,
                "INACTIVE" => V1ProjectResponseOutputStatus.Inactive,
                "INIT_FAILED" => V1ProjectResponseOutputStatus.InitFailed,
                "PAUSE_FAILED" => V1ProjectResponseOutputStatus.PauseFailed,
                "PAUSING" => V1ProjectResponseOutputStatus.Pausing,
                "REMOVED" => V1ProjectResponseOutputStatus.Removed,
                "RESIZING" => V1ProjectResponseOutputStatus.Resizing,
                "RESTARTING" => V1ProjectResponseOutputStatus.Restarting,
                "RESTORE_FAILED" => V1ProjectResponseOutputStatus.RestoreFailed,
                "RESTORING" => V1ProjectResponseOutputStatus.Restoring,
                "UNKNOWN" => V1ProjectResponseOutputStatus.Unknown,
                "UPGRADING" => V1ProjectResponseOutputStatus.Upgrading,
                _ => null,
            };
        }
    }
}