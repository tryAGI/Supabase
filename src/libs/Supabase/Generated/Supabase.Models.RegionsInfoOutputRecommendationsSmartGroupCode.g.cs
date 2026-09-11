
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoOutputRecommendationsSmartGroupCode
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
    public static class RegionsInfoOutputRecommendationsSmartGroupCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoOutputRecommendationsSmartGroupCode value)
        {
            return value switch
            {
                RegionsInfoOutputRecommendationsSmartGroupCode.Americas => "americas",
                RegionsInfoOutputRecommendationsSmartGroupCode.Apac => "apac",
                RegionsInfoOutputRecommendationsSmartGroupCode.Emea => "emea",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoOutputRecommendationsSmartGroupCode? ToEnum(string value)
        {
            return value switch
            {
                "americas" => RegionsInfoOutputRecommendationsSmartGroupCode.Americas,
                "apac" => RegionsInfoOutputRecommendationsSmartGroupCode.Apac,
                "emea" => RegionsInfoOutputRecommendationsSmartGroupCode.Emea,
                _ => null,
            };
        }
    }
}