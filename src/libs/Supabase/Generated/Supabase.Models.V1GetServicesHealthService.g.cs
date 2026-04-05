
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1GetServicesHealthService
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
    public static class V1GetServicesHealthServiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1GetServicesHealthService value)
        {
            return value switch
            {
                V1GetServicesHealthService.Auth => "auth",
                V1GetServicesHealthService.Db => "db",
                V1GetServicesHealthService.DbPostgresUser => "db_postgres_user",
                V1GetServicesHealthService.PgBouncer => "pg_bouncer",
                V1GetServicesHealthService.Pooler => "pooler",
                V1GetServicesHealthService.Realtime => "realtime",
                V1GetServicesHealthService.Rest => "rest",
                V1GetServicesHealthService.Storage => "storage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1GetServicesHealthService? ToEnum(string value)
        {
            return value switch
            {
                "auth" => V1GetServicesHealthService.Auth,
                "db" => V1GetServicesHealthService.Db,
                "db_postgres_user" => V1GetServicesHealthService.DbPostgresUser,
                "pg_bouncer" => V1GetServicesHealthService.PgBouncer,
                "pooler" => V1GetServicesHealthService.Pooler,
                "realtime" => V1GetServicesHealthService.Realtime,
                "rest" => V1GetServicesHealthService.Rest,
                "storage" => V1GetServicesHealthService.Storage,
                _ => null,
            };
        }
    }
}