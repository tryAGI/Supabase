
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum SupavisorConfigResponseDatabaseType
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
    public static class SupavisorConfigResponseDatabaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupavisorConfigResponseDatabaseType value)
        {
            return value switch
            {
                SupavisorConfigResponseDatabaseType.Primary => "PRIMARY",
                SupavisorConfigResponseDatabaseType.ReadReplica => "READ_REPLICA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupavisorConfigResponseDatabaseType? ToEnum(string value)
        {
            return value switch
            {
                "PRIMARY" => SupavisorConfigResponseDatabaseType.Primary,
                "READ_REPLICA" => SupavisorConfigResponseDatabaseType.ReadReplica,
                _ => null,
            };
        }
    }
}