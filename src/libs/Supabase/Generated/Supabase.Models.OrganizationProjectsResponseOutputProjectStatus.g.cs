
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum OrganizationProjectsResponseOutputProjectStatus
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
    public static class OrganizationProjectsResponseOutputProjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectsResponseOutputProjectStatus value)
        {
            return value switch
            {
                OrganizationProjectsResponseOutputProjectStatus.ActiveHealthy => "ACTIVE_HEALTHY",
                OrganizationProjectsResponseOutputProjectStatus.ActiveUnhealthy => "ACTIVE_UNHEALTHY",
                OrganizationProjectsResponseOutputProjectStatus.ComingUp => "COMING_UP",
                OrganizationProjectsResponseOutputProjectStatus.GoingDown => "GOING_DOWN",
                OrganizationProjectsResponseOutputProjectStatus.Inactive => "INACTIVE",
                OrganizationProjectsResponseOutputProjectStatus.InitFailed => "INIT_FAILED",
                OrganizationProjectsResponseOutputProjectStatus.PauseFailed => "PAUSE_FAILED",
                OrganizationProjectsResponseOutputProjectStatus.Pausing => "PAUSING",
                OrganizationProjectsResponseOutputProjectStatus.Removed => "REMOVED",
                OrganizationProjectsResponseOutputProjectStatus.Resizing => "RESIZING",
                OrganizationProjectsResponseOutputProjectStatus.Restarting => "RESTARTING",
                OrganizationProjectsResponseOutputProjectStatus.RestoreFailed => "RESTORE_FAILED",
                OrganizationProjectsResponseOutputProjectStatus.Restoring => "RESTORING",
                OrganizationProjectsResponseOutputProjectStatus.Unknown => "UNKNOWN",
                OrganizationProjectsResponseOutputProjectStatus.Upgrading => "UPGRADING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectsResponseOutputProjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_HEALTHY" => OrganizationProjectsResponseOutputProjectStatus.ActiveHealthy,
                "ACTIVE_UNHEALTHY" => OrganizationProjectsResponseOutputProjectStatus.ActiveUnhealthy,
                "COMING_UP" => OrganizationProjectsResponseOutputProjectStatus.ComingUp,
                "GOING_DOWN" => OrganizationProjectsResponseOutputProjectStatus.GoingDown,
                "INACTIVE" => OrganizationProjectsResponseOutputProjectStatus.Inactive,
                "INIT_FAILED" => OrganizationProjectsResponseOutputProjectStatus.InitFailed,
                "PAUSE_FAILED" => OrganizationProjectsResponseOutputProjectStatus.PauseFailed,
                "PAUSING" => OrganizationProjectsResponseOutputProjectStatus.Pausing,
                "REMOVED" => OrganizationProjectsResponseOutputProjectStatus.Removed,
                "RESIZING" => OrganizationProjectsResponseOutputProjectStatus.Resizing,
                "RESTARTING" => OrganizationProjectsResponseOutputProjectStatus.Restarting,
                "RESTORE_FAILED" => OrganizationProjectsResponseOutputProjectStatus.RestoreFailed,
                "RESTORING" => OrganizationProjectsResponseOutputProjectStatus.Restoring,
                "UNKNOWN" => OrganizationProjectsResponseOutputProjectStatus.Unknown,
                "UPGRADING" => OrganizationProjectsResponseOutputProjectStatus.Upgrading,
                _ => null,
            };
        }
    }
}