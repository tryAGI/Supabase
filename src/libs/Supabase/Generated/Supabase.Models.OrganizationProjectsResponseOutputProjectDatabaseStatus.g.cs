
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum OrganizationProjectsResponseOutputProjectDatabaseStatus
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
    public static class OrganizationProjectsResponseOutputProjectDatabaseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectsResponseOutputProjectDatabaseStatus value)
        {
            return value switch
            {
                OrganizationProjectsResponseOutputProjectDatabaseStatus.ActiveHealthy => "ACTIVE_HEALTHY",
                OrganizationProjectsResponseOutputProjectDatabaseStatus.ActiveUnhealthy => "ACTIVE_UNHEALTHY",
                OrganizationProjectsResponseOutputProjectDatabaseStatus.ComingUp => "COMING_UP",
                OrganizationProjectsResponseOutputProjectDatabaseStatus.GoingDown => "GOING_DOWN",
                OrganizationProjectsResponseOutputProjectDatabaseStatus.InitFailed => "INIT_FAILED",
                OrganizationProjectsResponseOutputProjectDatabaseStatus.InitReadReplica => "INIT_READ_REPLICA",
                OrganizationProjectsResponseOutputProjectDatabaseStatus.InitReadReplicaFailed => "INIT_READ_REPLICA_FAILED",
                OrganizationProjectsResponseOutputProjectDatabaseStatus.Removed => "REMOVED",
                OrganizationProjectsResponseOutputProjectDatabaseStatus.Resizing => "RESIZING",
                OrganizationProjectsResponseOutputProjectDatabaseStatus.Restarting => "RESTARTING",
                OrganizationProjectsResponseOutputProjectDatabaseStatus.Restoring => "RESTORING",
                OrganizationProjectsResponseOutputProjectDatabaseStatus.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectsResponseOutputProjectDatabaseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_HEALTHY" => OrganizationProjectsResponseOutputProjectDatabaseStatus.ActiveHealthy,
                "ACTIVE_UNHEALTHY" => OrganizationProjectsResponseOutputProjectDatabaseStatus.ActiveUnhealthy,
                "COMING_UP" => OrganizationProjectsResponseOutputProjectDatabaseStatus.ComingUp,
                "GOING_DOWN" => OrganizationProjectsResponseOutputProjectDatabaseStatus.GoingDown,
                "INIT_FAILED" => OrganizationProjectsResponseOutputProjectDatabaseStatus.InitFailed,
                "INIT_READ_REPLICA" => OrganizationProjectsResponseOutputProjectDatabaseStatus.InitReadReplica,
                "INIT_READ_REPLICA_FAILED" => OrganizationProjectsResponseOutputProjectDatabaseStatus.InitReadReplicaFailed,
                "REMOVED" => OrganizationProjectsResponseOutputProjectDatabaseStatus.Removed,
                "RESIZING" => OrganizationProjectsResponseOutputProjectDatabaseStatus.Resizing,
                "RESTARTING" => OrganizationProjectsResponseOutputProjectDatabaseStatus.Restarting,
                "RESTORING" => OrganizationProjectsResponseOutputProjectDatabaseStatus.Restoring,
                "UNKNOWN" => OrganizationProjectsResponseOutputProjectDatabaseStatus.Unknown,
                _ => null,
            };
        }
    }
}