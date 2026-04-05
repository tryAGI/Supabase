
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum BranchDetailResponseStatus
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
    public static class BranchDetailResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchDetailResponseStatus value)
        {
            return value switch
            {
                BranchDetailResponseStatus.ActiveHealthy => "ACTIVE_HEALTHY",
                BranchDetailResponseStatus.ActiveUnhealthy => "ACTIVE_UNHEALTHY",
                BranchDetailResponseStatus.ComingUp => "COMING_UP",
                BranchDetailResponseStatus.GoingDown => "GOING_DOWN",
                BranchDetailResponseStatus.Inactive => "INACTIVE",
                BranchDetailResponseStatus.InitFailed => "INIT_FAILED",
                BranchDetailResponseStatus.PauseFailed => "PAUSE_FAILED",
                BranchDetailResponseStatus.Pausing => "PAUSING",
                BranchDetailResponseStatus.Removed => "REMOVED",
                BranchDetailResponseStatus.Resizing => "RESIZING",
                BranchDetailResponseStatus.Restarting => "RESTARTING",
                BranchDetailResponseStatus.RestoreFailed => "RESTORE_FAILED",
                BranchDetailResponseStatus.Restoring => "RESTORING",
                BranchDetailResponseStatus.Unknown => "UNKNOWN",
                BranchDetailResponseStatus.Upgrading => "UPGRADING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchDetailResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_HEALTHY" => BranchDetailResponseStatus.ActiveHealthy,
                "ACTIVE_UNHEALTHY" => BranchDetailResponseStatus.ActiveUnhealthy,
                "COMING_UP" => BranchDetailResponseStatus.ComingUp,
                "GOING_DOWN" => BranchDetailResponseStatus.GoingDown,
                "INACTIVE" => BranchDetailResponseStatus.Inactive,
                "INIT_FAILED" => BranchDetailResponseStatus.InitFailed,
                "PAUSE_FAILED" => BranchDetailResponseStatus.PauseFailed,
                "PAUSING" => BranchDetailResponseStatus.Pausing,
                "REMOVED" => BranchDetailResponseStatus.Removed,
                "RESIZING" => BranchDetailResponseStatus.Resizing,
                "RESTARTING" => BranchDetailResponseStatus.Restarting,
                "RESTORE_FAILED" => BranchDetailResponseStatus.RestoreFailed,
                "RESTORING" => BranchDetailResponseStatus.Restoring,
                "UNKNOWN" => BranchDetailResponseStatus.Unknown,
                "UPGRADING" => BranchDetailResponseStatus.Upgrading,
                _ => null,
            };
        }
    }
}