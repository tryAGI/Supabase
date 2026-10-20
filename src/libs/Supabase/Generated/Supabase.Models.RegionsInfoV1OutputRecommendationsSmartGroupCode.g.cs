
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoV1OutputRecommendationsSmartGroupCode
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
    public static class RegionsInfoV1OutputRecommendationsSmartGroupCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoV1OutputRecommendationsSmartGroupCode value)
        {
            return value switch
            {
                RegionsInfoV1OutputRecommendationsSmartGroupCode.Americas => "americas",
                RegionsInfoV1OutputRecommendationsSmartGroupCode.Apac => "apac",
                RegionsInfoV1OutputRecommendationsSmartGroupCode.Emea => "emea",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoV1OutputRecommendationsSmartGroupCode? ToEnum(string value)
        {
            return value switch
            {
                "americas" => RegionsInfoV1OutputRecommendationsSmartGroupCode.Americas,
                "apac" => RegionsInfoV1OutputRecommendationsSmartGroupCode.Apac,
                "emea" => RegionsInfoV1OutputRecommendationsSmartGroupCode.Emea,
                _ => null,
            };
        }
    }
}