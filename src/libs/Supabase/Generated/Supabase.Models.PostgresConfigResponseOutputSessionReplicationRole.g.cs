
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum PostgresConfigResponseOutputSessionReplicationRole
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
    public static class PostgresConfigResponseOutputSessionReplicationRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostgresConfigResponseOutputSessionReplicationRole value)
        {
            return value switch
            {
                PostgresConfigResponseOutputSessionReplicationRole.Local => "local",
                PostgresConfigResponseOutputSessionReplicationRole.Origin => "origin",
                PostgresConfigResponseOutputSessionReplicationRole.Replica => "replica",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostgresConfigResponseOutputSessionReplicationRole? ToEnum(string value)
        {
            return value switch
            {
                "local" => PostgresConfigResponseOutputSessionReplicationRole.Local,
                "origin" => PostgresConfigResponseOutputSessionReplicationRole.Origin,
                "replica" => PostgresConfigResponseOutputSessionReplicationRole.Replica,
                _ => null,
            };
        }
    }
}