
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrganizationProjectsResponseProjectStatus
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
    public static class OrganizationProjectsResponseProjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectsResponseProjectStatus value)
        {
            return value switch
            {
                OrganizationProjectsResponseProjectStatus.ActiveHealthy => "ACTIVE_HEALTHY",
                OrganizationProjectsResponseProjectStatus.ActiveUnhealthy => "ACTIVE_UNHEALTHY",
                OrganizationProjectsResponseProjectStatus.ComingUp => "COMING_UP",
                OrganizationProjectsResponseProjectStatus.GoingDown => "GOING_DOWN",
                OrganizationProjectsResponseProjectStatus.Inactive => "INACTIVE",
                OrganizationProjectsResponseProjectStatus.InitFailed => "INIT_FAILED",
                OrganizationProjectsResponseProjectStatus.PauseFailed => "PAUSE_FAILED",
                OrganizationProjectsResponseProjectStatus.Pausing => "PAUSING",
                OrganizationProjectsResponseProjectStatus.Removed => "REMOVED",
                OrganizationProjectsResponseProjectStatus.Resizing => "RESIZING",
                OrganizationProjectsResponseProjectStatus.Restarting => "RESTARTING",
                OrganizationProjectsResponseProjectStatus.RestoreFailed => "RESTORE_FAILED",
                OrganizationProjectsResponseProjectStatus.Restoring => "RESTORING",
                OrganizationProjectsResponseProjectStatus.Unknown => "UNKNOWN",
                OrganizationProjectsResponseProjectStatus.Upgrading => "UPGRADING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectsResponseProjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_HEALTHY" => OrganizationProjectsResponseProjectStatus.ActiveHealthy,
                "ACTIVE_UNHEALTHY" => OrganizationProjectsResponseProjectStatus.ActiveUnhealthy,
                "COMING_UP" => OrganizationProjectsResponseProjectStatus.ComingUp,
                "GOING_DOWN" => OrganizationProjectsResponseProjectStatus.GoingDown,
                "INACTIVE" => OrganizationProjectsResponseProjectStatus.Inactive,
                "INIT_FAILED" => OrganizationProjectsResponseProjectStatus.InitFailed,
                "PAUSE_FAILED" => OrganizationProjectsResponseProjectStatus.PauseFailed,
                "PAUSING" => OrganizationProjectsResponseProjectStatus.Pausing,
                "REMOVED" => OrganizationProjectsResponseProjectStatus.Removed,
                "RESIZING" => OrganizationProjectsResponseProjectStatus.Resizing,
                "RESTARTING" => OrganizationProjectsResponseProjectStatus.Restarting,
                "RESTORE_FAILED" => OrganizationProjectsResponseProjectStatus.RestoreFailed,
                "RESTORING" => OrganizationProjectsResponseProjectStatus.Restoring,
                "UNKNOWN" => OrganizationProjectsResponseProjectStatus.Unknown,
                "UPGRADING" => OrganizationProjectsResponseProjectStatus.Upgrading,
                _ => null,
            };
        }
    }
}