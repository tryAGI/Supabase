
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegionsInfoRecommendationsSmartGroupCode
    {
        /// <summary>
        /// 
        /// </summary>
        Americas,
        /// <summary>
        /// 
        /// </summary>
        Apac,
        /// <summary>
        /// 
        /// </summary>
        Emea,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoRecommendationsSmartGroupCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoRecommendationsSmartGroupCode value)
        {
            return value switch
            {
                RegionsInfoRecommendationsSmartGroupCode.Americas => "americas",
                RegionsInfoRecommendationsSmartGroupCode.Apac => "apac",
                RegionsInfoRecommendationsSmartGroupCode.Emea => "emea",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoRecommendationsSmartGroupCode? ToEnum(string value)
        {
            return value switch
            {
                "americas" => RegionsInfoRecommendationsSmartGroupCode.Americas,
                "apac" => RegionsInfoRecommendationsSmartGroupCode.Apac,
                "emea" => RegionsInfoRecommendationsSmartGroupCode.Emea,
                _ => null,
            };
        }
    }
}