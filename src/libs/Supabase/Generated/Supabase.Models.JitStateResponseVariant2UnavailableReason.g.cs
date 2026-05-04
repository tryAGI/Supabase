
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum JitStateResponseVariant2UnavailableReason
    {
        /// <summary>
        /// 
        /// </summary>
        ManualMigrationRequired,
        /// <summary>
        /// 
        /// </summary>
        PostgresUpgradeRequired,
        /// <summary>
        /// 
        /// </summary>
        TemporarilyUnavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JitStateResponseVariant2UnavailableReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JitStateResponseVariant2UnavailableReason value)
        {
            return value switch
            {
                JitStateResponseVariant2UnavailableReason.ManualMigrationRequired => "manual_migration_required",
                JitStateResponseVariant2UnavailableReason.PostgresUpgradeRequired => "postgres_upgrade_required",
                JitStateResponseVariant2UnavailableReason.TemporarilyUnavailable => "temporarily_unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JitStateResponseVariant2UnavailableReason? ToEnum(string value)
        {
            return value switch
            {
                "manual_migration_required" => JitStateResponseVariant2UnavailableReason.ManualMigrationRequired,
                "postgres_upgrade_required" => JitStateResponseVariant2UnavailableReason.PostgresUpgradeRequired,
                "temporarily_unavailable" => JitStateResponseVariant2UnavailableReason.TemporarilyUnavailable,
                _ => null,
            };
        }
    }
}