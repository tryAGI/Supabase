
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoOutputRecommendationsSpecificItemType
    {
        /// <summary>
        ///
        /// </summary>
        Specific,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoOutputRecommendationsSpecificItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoOutputRecommendationsSpecificItemType value)
        {
            return value switch
            {
                RegionsInfoOutputRecommendationsSpecificItemType.Specific => "specific",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoOutputRecommendationsSpecificItemType? ToEnum(string value)
        {
            return value switch
            {
                "specific" => RegionsInfoOutputRecommendationsSpecificItemType.Specific,
                _ => null,
            };
        }
    }
}