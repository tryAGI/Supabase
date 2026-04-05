
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegionsInfoRecommendationsSmartGroupType
    {
        /// <summary>
        /// 
        /// </summary>
        SmartGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoRecommendationsSmartGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoRecommendationsSmartGroupType value)
        {
            return value switch
            {
                RegionsInfoRecommendationsSmartGroupType.SmartGroup => "smartGroup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoRecommendationsSmartGroupType? ToEnum(string value)
        {
            return value switch
            {
                "smartGroup" => RegionsInfoRecommendationsSmartGroupType.SmartGroup,
                _ => null,
            };
        }
    }
}