
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostgresConfigResponseSessionReplicationRole
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
    public static class PostgresConfigResponseSessionReplicationRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostgresConfigResponseSessionReplicationRole value)
        {
            return value switch
            {
                PostgresConfigResponseSessionReplicationRole.Local => "local",
                PostgresConfigResponseSessionReplicationRole.Origin => "origin",
                PostgresConfigResponseSessionReplicationRole.Replica => "replica",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostgresConfigResponseSessionReplicationRole? ToEnum(string value)
        {
            return value switch
            {
                "local" => PostgresConfigResponseSessionReplicationRole.Local,
                "origin" => PostgresConfigResponseSessionReplicationRole.Origin,
                "replica" => PostgresConfigResponseSessionReplicationRole.Replica,
                _ => null,
            };
        }
    }
}