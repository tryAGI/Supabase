
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoV1OutputAllSpecificItemStatus
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
    public static class RegionsInfoV1OutputAllSpecificItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoV1OutputAllSpecificItemStatus value)
        {
            return value switch
            {
                RegionsInfoV1OutputAllSpecificItemStatus.Capacity => "capacity",
                RegionsInfoV1OutputAllSpecificItemStatus.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoV1OutputAllSpecificItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "capacity" => RegionsInfoV1OutputAllSpecificItemStatus.Capacity,
                "other" => RegionsInfoV1OutputAllSpecificItemStatus.Other,
                _ => null,
            };
        }
    }
}