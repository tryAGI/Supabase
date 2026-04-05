
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrganizationProjectsResponseProjectDatabaseStatus
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
        InitFailed,
        /// <summary>
        /// 
        /// </summary>
        InitReadReplica,
        /// <summary>
        /// 
        /// </summary>
        InitReadReplicaFailed,
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
        Restoring,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationProjectsResponseProjectDatabaseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectsResponseProjectDatabaseStatus value)
        {
            return value switch
            {
                OrganizationProjectsResponseProjectDatabaseStatus.ActiveHealthy => "ACTIVE_HEALTHY",
                OrganizationProjectsResponseProjectDatabaseStatus.ActiveUnhealthy => "ACTIVE_UNHEALTHY",
                OrganizationProjectsResponseProjectDatabaseStatus.ComingUp => "COMING_UP",
                OrganizationProjectsResponseProjectDatabaseStatus.GoingDown => "GOING_DOWN",
                OrganizationProjectsResponseProjectDatabaseStatus.InitFailed => "INIT_FAILED",
                OrganizationProjectsResponseProjectDatabaseStatus.InitReadReplica => "INIT_READ_REPLICA",
                OrganizationProjectsResponseProjectDatabaseStatus.InitReadReplicaFailed => "INIT_READ_REPLICA_FAILED",
                OrganizationProjectsResponseProjectDatabaseStatus.Removed => "REMOVED",
                OrganizationProjectsResponseProjectDatabaseStatus.Resizing => "RESIZING",
                OrganizationProjectsResponseProjectDatabaseStatus.Restarting => "RESTARTING",
                OrganizationProjectsResponseProjectDatabaseStatus.Restoring => "RESTORING",
                OrganizationProjectsResponseProjectDatabaseStatus.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectsResponseProjectDatabaseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_HEALTHY" => OrganizationProjectsResponseProjectDatabaseStatus.ActiveHealthy,
                "ACTIVE_UNHEALTHY" => OrganizationProjectsResponseProjectDatabaseStatus.ActiveUnhealthy,
                "COMING_UP" => OrganizationProjectsResponseProjectDatabaseStatus.ComingUp,
                "GOING_DOWN" => OrganizationProjectsResponseProjectDatabaseStatus.GoingDown,
                "INIT_FAILED" => OrganizationProjectsResponseProjectDatabaseStatus.InitFailed,
                "INIT_READ_REPLICA" => OrganizationProjectsResponseProjectDatabaseStatus.InitReadReplica,
                "INIT_READ_REPLICA_FAILED" => OrganizationProjectsResponseProjectDatabaseStatus.InitReadReplicaFailed,
                "REMOVED" => OrganizationProjectsResponseProjectDatabaseStatus.Removed,
                "RESIZING" => OrganizationProjectsResponseProjectDatabaseStatus.Resizing,
                "RESTARTING" => OrganizationProjectsResponseProjectDatabaseStatus.Restarting,
                "RESTORING" => OrganizationProjectsResponseProjectDatabaseStatus.Restoring,
                "UNKNOWN" => OrganizationProjectsResponseProjectDatabaseStatus.Unknown,
                _ => null,
            };
        }
    }
}