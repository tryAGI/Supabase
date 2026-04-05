
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegionsInfoRecommendationsSpecificItemStatus
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
    public static class RegionsInfoRecommendationsSpecificItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoRecommendationsSpecificItemStatus value)
        {
            return value switch
            {
                RegionsInfoRecommendationsSpecificItemStatus.Capacity => "capacity",
                RegionsInfoRecommendationsSpecificItemStatus.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoRecommendationsSpecificItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "capacity" => RegionsInfoRecommendationsSpecificItemStatus.Capacity,
                "other" => RegionsInfoRecommendationsSpecificItemStatus.Other,
                _ => null,
            };
        }
    }
}