
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdatePostgresConfigBodySessionReplicationRole
    {
        /// <summary>
        /// 
        /// </summary>
        Local,
        /// <summary>
        /// 
        /// </summary>
        Origin,
        /// <summary>
        /// 
        /// </summary>
        Replica,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdatePostgresConfigBodySessionReplicationRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePostgresConfigBodySessionReplicationRole value)
        {
            return value switch
            {
                UpdatePostgresConfigBodySessionReplicationRole.Local => "local",
                UpdatePostgresConfigBodySessionReplicationRole.Origin => "origin",
                UpdatePostgresConfigBodySessionReplicationRole.Replica => "replica",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePostgresConfigBodySessionReplicationRole? ToEnum(string value)
        {
            return value switch
            {
                "local" => UpdatePostgresConfigBodySessionReplicationRole.Local,
                "origin" => UpdatePostgresConfigBodySessionReplicationRole.Origin,
                "replica" => UpdatePostgresConfigBodySessionReplicationRole.Replica,
                _ => null,
            };
        }
    }
}