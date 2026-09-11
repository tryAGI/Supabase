
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoOutputAllSpecificItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Capacity,
        /// <summary>
        ///
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoOutputAllSpecificItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoOutputAllSpecificItemStatus value)
        {
            return value switch
            {
                RegionsInfoOutputAllSpecificItemStatus.Capacity => "capacity",
                RegionsInfoOutputAllSpecificItemStatus.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoOutputAllSpecificItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "capacity" => RegionsInfoOutputAllSpecificItemStatus.Capacity,
                "other" => RegionsInfoOutputAllSpecificItemStatus.Other,
                _ => null,
            };
        }
    }
}