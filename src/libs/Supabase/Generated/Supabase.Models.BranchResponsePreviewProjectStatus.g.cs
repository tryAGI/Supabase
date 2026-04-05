
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum BranchResponsePreviewProjectStatus
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
    public static class BranchResponsePreviewProjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchResponsePreviewProjectStatus value)
        {
            return value switch
            {
                BranchResponsePreviewProjectStatus.ActiveHealthy => "ACTIVE_HEALTHY",
                BranchResponsePreviewProjectStatus.ActiveUnhealthy => "ACTIVE_UNHEALTHY",
                BranchResponsePreviewProjectStatus.ComingUp => "COMING_UP",
                BranchResponsePreviewProjectStatus.GoingDown => "GOING_DOWN",
                BranchResponsePreviewProjectStatus.Inactive => "INACTIVE",
                BranchResponsePreviewProjectStatus.InitFailed => "INIT_FAILED",
                BranchResponsePreviewProjectStatus.PauseFailed => "PAUSE_FAILED",
                BranchResponsePreviewProjectStatus.Pausing => "PAUSING",
                BranchResponsePreviewProjectStatus.Removed => "REMOVED",
                BranchResponsePreviewProjectStatus.Resizing => "RESIZING",
                BranchResponsePreviewProjectStatus.Restarting => "RESTARTING",
                BranchResponsePreviewProjectStatus.RestoreFailed => "RESTORE_FAILED",
                BranchResponsePreviewProjectStatus.Restoring => "RESTORING",
                BranchResponsePreviewProjectStatus.Unknown => "UNKNOWN",
                BranchResponsePreviewProjectStatus.Upgrading => "UPGRADING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchResponsePreviewProjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_HEALTHY" => BranchResponsePreviewProjectStatus.ActiveHealthy,
                "ACTIVE_UNHEALTHY" => BranchResponsePreviewProjectStatus.ActiveUnhealthy,
                "COMING_UP" => BranchResponsePreviewProjectStatus.ComingUp,
                "GOING_DOWN" => BranchResponsePreviewProjectStatus.GoingDown,
                "INACTIVE" => BranchResponsePreviewProjectStatus.Inactive,
                "INIT_FAILED" => BranchResponsePreviewProjectStatus.InitFailed,
                "PAUSE_FAILED" => BranchResponsePreviewProjectStatus.PauseFailed,
                "PAUSING" => BranchResponsePreviewProjectStatus.Pausing,
                "REMOVED" => BranchResponsePreviewProjectStatus.Removed,
                "RESIZING" => BranchResponsePreviewProjectStatus.Resizing,
                "RESTARTING" => BranchResponsePreviewProjectStatus.Restarting,
                "RESTORE_FAILED" => BranchResponsePreviewProjectStatus.RestoreFailed,
                "RESTORING" => BranchResponsePreviewProjectStatus.Restoring,
                "UNKNOWN" => BranchResponsePreviewProjectStatus.Unknown,
                "UPGRADING" => BranchResponsePreviewProjectStatus.Upgrading,
                _ => null,
            };
        }
    }
}