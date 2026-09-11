
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoOutputRecommendationsSmartGroupType
    {
        /// <summary>
        ///
        /// </summary>
        SmartGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoOutputRecommendationsSmartGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoOutputRecommendationsSmartGroupType value)
        {
            return value switch
            {
                RegionsInfoOutputRecommendationsSmartGroupType.SmartGroup => "smartGroup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoOutputRecommendationsSmartGroupType? ToEnum(string value)
        {
            return value switch
            {
                "smartGroup" => RegionsInfoOutputRecommendationsSmartGroupType.SmartGroup,
                _ => null,
            };
        }
    }
}