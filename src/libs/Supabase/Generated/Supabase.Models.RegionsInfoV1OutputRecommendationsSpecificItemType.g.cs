
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoV1OutputRecommendationsSpecificItemType
    {
        /// <summary>
        ///
        /// </summary>
        Specific,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoV1OutputRecommendationsSpecificItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoV1OutputRecommendationsSpecificItemType value)
        {
            return value switch
            {
                RegionsInfoV1OutputRecommendationsSpecificItemType.Specific => "specific",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoV1OutputRecommendationsSpecificItemType? ToEnum(string value)
        {
            return value switch
            {
                "specific" => RegionsInfoV1OutputRecommendationsSpecificItemType.Specific,
                _ => null,
            };
        }
    }
}