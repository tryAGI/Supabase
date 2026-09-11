
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1ServiceHealthResponseOutputName
    {
        /// <summary>
        ///
        /// </summary>
        Auth,
        /// <summary>
        ///
        /// </summary>
        Db,
        /// <summary>
        ///
        /// </summary>
        DbPostgresUser,
        /// <summary>
        ///
        /// </summary>
        PgBouncer,
        /// <summary>
        ///
        /// </summary>
        Pooler,
        /// <summary>
        ///
        /// </summary>
        Realtime,
        /// <summary>
        ///
        /// </summary>
        Rest,
        /// <summary>
        ///
        /// </summary>
        Storage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ServiceHealthResponseOutputNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ServiceHealthResponseOutputName value)
        {
            return value switch
            {
                V1ServiceHealthResponseOutputName.Auth => "auth",
                V1ServiceHealthResponseOutputName.Db => "db",
                V1ServiceHealthResponseOutputName.DbPostgresUser => "db_postgres_user",
                V1ServiceHealthResponseOutputName.PgBouncer => "pg_bouncer",
                V1ServiceHealthResponseOutputName.Pooler => "pooler",
                V1ServiceHealthResponseOutputName.Realtime => "realtime",
                V1ServiceHealthResponseOutputName.Rest => "rest",
                V1ServiceHealthResponseOutputName.Storage => "storage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ServiceHealthResponseOutputName? ToEnum(string value)
        {
            return value switch
            {
                "auth" => V1ServiceHealthResponseOutputName.Auth,
                "db" => V1ServiceHealthResponseOutputName.Db,
                "db_postgres_user" => V1ServiceHealthResponseOutputName.DbPostgresUser,
                "pg_bouncer" => V1ServiceHealthResponseOutputName.PgBouncer,
                "pooler" => V1ServiceHealthResponseOutputName.Pooler,
                "realtime" => V1ServiceHealthResponseOutputName.Realtime,
                "rest" => V1ServiceHealthResponseOutputName.Rest,
                "storage" => V1ServiceHealthResponseOutputName.Storage,
                _ => null,
            };
        }
    }
}