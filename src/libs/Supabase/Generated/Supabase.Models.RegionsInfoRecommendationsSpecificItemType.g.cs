
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegionsInfoRecommendationsSpecificItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Specific,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoRecommendationsSpecificItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoRecommendationsSpecificItemType value)
        {
            return value switch
            {
                RegionsInfoRecommendationsSpecificItemType.Specific => "specific",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoRecommendationsSpecificItemType? ToEnum(string value)
        {
            return value switch
            {
                "specific" => RegionsInfoRecommendationsSpecificItemType.Specific,
                _ => null,
            };
        }
    }
}