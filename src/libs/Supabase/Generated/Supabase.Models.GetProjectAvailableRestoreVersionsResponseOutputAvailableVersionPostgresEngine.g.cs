
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionPostgresEngine
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
    public static class GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionPostgresEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionPostgresEngine value)
        {
            return value switch
            {
                GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionPostgresEngine.x13 => "13",
                GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionPostgresEngine.x14 => "14",
                GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionPostgresEngine.x15 => "15",
                GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionPostgresEngine.x17 => "17",
                GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionPostgresEngine.x17Oriole => "17-oriole",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionPostgresEngine? ToEnum(string value)
        {
            return value switch
            {
                "13" => GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionPostgresEngine.x13,
                "14" => GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionPostgresEngine.x14,
                "15" => GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionPostgresEngine.x15,
                "17" => GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionPostgresEngine.x17,
                "17-oriole" => GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionPostgresEngine.x17Oriole,
                _ => null,
            };
        }
    }
}