
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum BranchResponseOutputPreviewProjectStatus
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
    public static class BranchResponseOutputPreviewProjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchResponseOutputPreviewProjectStatus value)
        {
            return value switch
            {
                BranchResponseOutputPreviewProjectStatus.ActiveHealthy => "ACTIVE_HEALTHY",
                BranchResponseOutputPreviewProjectStatus.ActiveUnhealthy => "ACTIVE_UNHEALTHY",
                BranchResponseOutputPreviewProjectStatus.ComingUp => "COMING_UP",
                BranchResponseOutputPreviewProjectStatus.GoingDown => "GOING_DOWN",
                BranchResponseOutputPreviewProjectStatus.Inactive => "INACTIVE",
                BranchResponseOutputPreviewProjectStatus.InitFailed => "INIT_FAILED",
                BranchResponseOutputPreviewProjectStatus.PauseFailed => "PAUSE_FAILED",
                BranchResponseOutputPreviewProjectStatus.Pausing => "PAUSING",
                BranchResponseOutputPreviewProjectStatus.Removed => "REMOVED",
                BranchResponseOutputPreviewProjectStatus.Resizing => "RESIZING",
                BranchResponseOutputPreviewProjectStatus.Restarting => "RESTARTING",
                BranchResponseOutputPreviewProjectStatus.RestoreFailed => "RESTORE_FAILED",
                BranchResponseOutputPreviewProjectStatus.Restoring => "RESTORING",
                BranchResponseOutputPreviewProjectStatus.Unknown => "UNKNOWN",
                BranchResponseOutputPreviewProjectStatus.Upgrading => "UPGRADING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchResponseOutputPreviewProjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_HEALTHY" => BranchResponseOutputPreviewProjectStatus.ActiveHealthy,
                "ACTIVE_UNHEALTHY" => BranchResponseOutputPreviewProjectStatus.ActiveUnhealthy,
                "COMING_UP" => BranchResponseOutputPreviewProjectStatus.ComingUp,
                "GOING_DOWN" => BranchResponseOutputPreviewProjectStatus.GoingDown,
                "INACTIVE" => BranchResponseOutputPreviewProjectStatus.Inactive,
                "INIT_FAILED" => BranchResponseOutputPreviewProjectStatus.InitFailed,
                "PAUSE_FAILED" => BranchResponseOutputPreviewProjectStatus.PauseFailed,
                "PAUSING" => BranchResponseOutputPreviewProjectStatus.Pausing,
                "REMOVED" => BranchResponseOutputPreviewProjectStatus.Removed,
                "RESIZING" => BranchResponseOutputPreviewProjectStatus.Resizing,
                "RESTARTING" => BranchResponseOutputPreviewProjectStatus.Restarting,
                "RESTORE_FAILED" => BranchResponseOutputPreviewProjectStatus.RestoreFailed,
                "RESTORING" => BranchResponseOutputPreviewProjectStatus.Restoring,
                "UNKNOWN" => BranchResponseOutputPreviewProjectStatus.Unknown,
                "UPGRADING" => BranchResponseOutputPreviewProjectStatus.Upgrading,
                _ => null,
            };
        }
    }
}