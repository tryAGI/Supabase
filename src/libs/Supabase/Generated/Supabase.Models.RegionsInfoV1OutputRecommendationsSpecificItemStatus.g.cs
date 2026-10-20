
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoV1OutputRecommendationsSpecificItemStatus
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
    public static class RegionsInfoV1OutputRecommendationsSpecificItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoV1OutputRecommendationsSpecificItemStatus value)
        {
            return value switch
            {
                RegionsInfoV1OutputRecommendationsSpecificItemStatus.Capacity => "capacity",
                RegionsInfoV1OutputRecommendationsSpecificItemStatus.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoV1OutputRecommendationsSpecificItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "capacity" => RegionsInfoV1OutputRecommendationsSpecificItemStatus.Capacity,
                "other" => RegionsInfoV1OutputRecommendationsSpecificItemStatus.Other,
                _ => null,
            };
        }
    }
}