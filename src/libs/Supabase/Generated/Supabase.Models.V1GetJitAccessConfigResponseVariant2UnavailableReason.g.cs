
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1GetJitAccessConfigResponseVariant2UnavailableReason
    {
        /// <summary>
        ///
        /// </summary>
        PostgresUpgradeRequired,
        /// <summary>
        ///
        /// </summary>
        SslEnforcementRequired,
        /// <summary>
        ///
        /// </summary>
        TemporarilyUnavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1GetJitAccessConfigResponseVariant2UnavailableReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1GetJitAccessConfigResponseVariant2UnavailableReason value)
        {
            return value switch
            {
                V1GetJitAccessConfigResponseVariant2UnavailableReason.PostgresUpgradeRequired => "postgres_upgrade_required",
                V1GetJitAccessConfigResponseVariant2UnavailableReason.SslEnforcementRequired => "ssl_enforcement_required",
                V1GetJitAccessConfigResponseVariant2UnavailableReason.TemporarilyUnavailable => "temporarily_unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1GetJitAccessConfigResponseVariant2UnavailableReason? ToEnum(string value)
        {
            return value switch
            {
                "postgres_upgrade_required" => V1GetJitAccessConfigResponseVariant2UnavailableReason.PostgresUpgradeRequired,
                "ssl_enforcement_required" => V1GetJitAccessConfigResponseVariant2UnavailableReason.SslEnforcementRequired,
                "temporarily_unavailable" => V1GetJitAccessConfigResponseVariant2UnavailableReason.TemporarilyUnavailable,
                _ => null,
            };
        }
    }
}