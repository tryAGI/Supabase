
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine
    {
        /// <summary>
        /// 
        /// </summary>
        x13,
        /// <summary>
        /// 
        /// </summary>
        x14,
        /// <summary>
        /// 
        /// </summary>
        x15,
        /// <summary>
        /// 
        /// </summary>
        x17,
        /// <summary>
        /// 
        /// </summary>
        x17Oriole,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine value)
        {
            return value switch
            {
                GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine.x13 => "13",
                GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine.x14 => "14",
                GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine.x15 => "15",
                GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine.x17 => "17",
                GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine.x17Oriole => "17-oriole",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine? ToEnum(string value)
        {
            return value switch
            {
                "13" => GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine.x13,
                "14" => GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine.x14,
                "15" => GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine.x15,
                "17" => GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine.x17,
                "17-oriole" => GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine.x17Oriole,
                _ => null,
            };
        }
    }
}