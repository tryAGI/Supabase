
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoV1OutputRecommendationsSmartGroupType
    {
        /// <summary>
        ///
        /// </summary>
        SmartGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoV1OutputRecommendationsSmartGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoV1OutputRecommendationsSmartGroupType value)
        {
            return value switch
            {
                RegionsInfoV1OutputRecommendationsSmartGroupType.SmartGroup => "smartGroup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoV1OutputRecommendationsSmartGroupType? ToEnum(string value)
        {
            return value switch
            {
                "smartGroup" => RegionsInfoV1OutputRecommendationsSmartGroupType.SmartGroup,
                _ => null,
            };
        }
    }
}