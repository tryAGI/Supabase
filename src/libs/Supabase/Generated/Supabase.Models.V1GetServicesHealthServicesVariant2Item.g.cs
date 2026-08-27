
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1GetServicesHealthServicesVariant2Item
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
    public static class V1GetServicesHealthServicesVariant2ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1GetServicesHealthServicesVariant2Item value)
        {
            return value switch
            {
                V1GetServicesHealthServicesVariant2Item.Auth => "auth",
                V1GetServicesHealthServicesVariant2Item.Db => "db",
                V1GetServicesHealthServicesVariant2Item.DbPostgresUser => "db_postgres_user",
                V1GetServicesHealthServicesVariant2Item.PgBouncer => "pg_bouncer",
                V1GetServicesHealthServicesVariant2Item.Pooler => "pooler",
                V1GetServicesHealthServicesVariant2Item.Realtime => "realtime",
                V1GetServicesHealthServicesVariant2Item.Rest => "rest",
                V1GetServicesHealthServicesVariant2Item.Storage => "storage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1GetServicesHealthServicesVariant2Item? ToEnum(string value)
        {
            return value switch
            {
                "auth" => V1GetServicesHealthServicesVariant2Item.Auth,
                "db" => V1GetServicesHealthServicesVariant2Item.Db,
                "db_postgres_user" => V1GetServicesHealthServicesVariant2Item.DbPostgresUser,
                "pg_bouncer" => V1GetServicesHealthServicesVariant2Item.PgBouncer,
                "pooler" => V1GetServicesHealthServicesVariant2Item.Pooler,
                "realtime" => V1GetServicesHealthServicesVariant2Item.Realtime,
                "rest" => V1GetServicesHealthServicesVariant2Item.Rest,
                "storage" => V1GetServicesHealthServicesVariant2Item.Storage,
                _ => null,
            };
        }
    }
}