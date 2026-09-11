
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum BranchDetailResponseOutputStatus
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
    public static class BranchDetailResponseOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchDetailResponseOutputStatus value)
        {
            return value switch
            {
                BranchDetailResponseOutputStatus.ActiveHealthy => "ACTIVE_HEALTHY",
                BranchDetailResponseOutputStatus.ActiveUnhealthy => "ACTIVE_UNHEALTHY",
                BranchDetailResponseOutputStatus.ComingUp => "COMING_UP",
                BranchDetailResponseOutputStatus.GoingDown => "GOING_DOWN",
                BranchDetailResponseOutputStatus.Inactive => "INACTIVE",
                BranchDetailResponseOutputStatus.InitFailed => "INIT_FAILED",
                BranchDetailResponseOutputStatus.PauseFailed => "PAUSE_FAILED",
                BranchDetailResponseOutputStatus.Pausing => "PAUSING",
                BranchDetailResponseOutputStatus.Removed => "REMOVED",
                BranchDetailResponseOutputStatus.Resizing => "RESIZING",
                BranchDetailResponseOutputStatus.Restarting => "RESTARTING",
                BranchDetailResponseOutputStatus.RestoreFailed => "RESTORE_FAILED",
                BranchDetailResponseOutputStatus.Restoring => "RESTORING",
                BranchDetailResponseOutputStatus.Unknown => "UNKNOWN",
                BranchDetailResponseOutputStatus.Upgrading => "UPGRADING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchDetailResponseOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_HEALTHY" => BranchDetailResponseOutputStatus.ActiveHealthy,
                "ACTIVE_UNHEALTHY" => BranchDetailResponseOutputStatus.ActiveUnhealthy,
                "COMING_UP" => BranchDetailResponseOutputStatus.ComingUp,
                "GOING_DOWN" => BranchDetailResponseOutputStatus.GoingDown,
                "INACTIVE" => BranchDetailResponseOutputStatus.Inactive,
                "INIT_FAILED" => BranchDetailResponseOutputStatus.InitFailed,
                "PAUSE_FAILED" => BranchDetailResponseOutputStatus.PauseFailed,
                "PAUSING" => BranchDetailResponseOutputStatus.Pausing,
                "REMOVED" => BranchDetailResponseOutputStatus.Removed,
                "RESIZING" => BranchDetailResponseOutputStatus.Resizing,
                "RESTARTING" => BranchDetailResponseOutputStatus.Restarting,
                "RESTORE_FAILED" => BranchDetailResponseOutputStatus.RestoreFailed,
                "RESTORING" => BranchDetailResponseOutputStatus.Restoring,
                "UNKNOWN" => BranchDetailResponseOutputStatus.Unknown,
                "UPGRADING" => BranchDetailResponseOutputStatus.Upgrading,
                _ => null,
            };
        }
    }
}