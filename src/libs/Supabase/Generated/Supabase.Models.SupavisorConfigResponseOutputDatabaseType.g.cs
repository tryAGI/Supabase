
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum SupavisorConfigResponseOutputDatabaseType
    {
        /// <summary>
        ///
        /// </summary>
        Primary,
        /// <summary>
        ///
        /// </summary>
        ReadReplica,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SupavisorConfigResponseOutputDatabaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupavisorConfigResponseOutputDatabaseType value)
        {
            return value switch
            {
                SupavisorConfigResponseOutputDatabaseType.Primary => "PRIMARY",
                SupavisorConfigResponseOutputDatabaseType.ReadReplica => "READ_REPLICA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupavisorConfigResponseOutputDatabaseType? ToEnum(string value)
        {
            return value switch
            {
                "PRIMARY" => SupavisorConfigResponseOutputDatabaseType.Primary,
                "READ_REPLICA" => SupavisorConfigResponseOutputDatabaseType.ReadReplica,
                _ => null,
            };
        }
    }
}