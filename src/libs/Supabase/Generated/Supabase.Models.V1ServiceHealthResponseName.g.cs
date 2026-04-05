
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ServiceHealthResponseName
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
    public static class V1ServiceHealthResponseNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ServiceHealthResponseName value)
        {
            return value switch
            {
                V1ServiceHealthResponseName.Auth => "auth",
                V1ServiceHealthResponseName.Db => "db",
                V1ServiceHealthResponseName.DbPostgresUser => "db_postgres_user",
                V1ServiceHealthResponseName.PgBouncer => "pg_bouncer",
                V1ServiceHealthResponseName.Pooler => "pooler",
                V1ServiceHealthResponseName.Realtime => "realtime",
                V1ServiceHealthResponseName.Rest => "rest",
                V1ServiceHealthResponseName.Storage => "storage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ServiceHealthResponseName? ToEnum(string value)
        {
            return value switch
            {
                "auth" => V1ServiceHealthResponseName.Auth,
                "db" => V1ServiceHealthResponseName.Db,
                "db_postgres_user" => V1ServiceHealthResponseName.DbPostgresUser,
                "pg_bouncer" => V1ServiceHealthResponseName.PgBouncer,
                "pooler" => V1ServiceHealthResponseName.Pooler,
                "realtime" => V1ServiceHealthResponseName.Realtime,
                "rest" => V1ServiceHealthResponseName.Rest,
                "storage" => V1ServiceHealthResponseName.Storage,
                _ => null,
            };
        }
    }
}