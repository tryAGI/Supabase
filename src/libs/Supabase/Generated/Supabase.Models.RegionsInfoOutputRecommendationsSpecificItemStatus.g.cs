
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoOutputRecommendationsSpecificItemStatus
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
    public static class RegionsInfoOutputRecommendationsSpecificItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoOutputRecommendationsSpecificItemStatus value)
        {
            return value switch
            {
                RegionsInfoOutputRecommendationsSpecificItemStatus.Capacity => "capacity",
                RegionsInfoOutputRecommendationsSpecificItemStatus.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoOutputRecommendationsSpecificItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "capacity" => RegionsInfoOutputRecommendationsSpecificItemStatus.Capacity,
                "other" => RegionsInfoOutputRecommendationsSpecificItemStatus.Other,
                _ => null,
            };
        }
    }
}