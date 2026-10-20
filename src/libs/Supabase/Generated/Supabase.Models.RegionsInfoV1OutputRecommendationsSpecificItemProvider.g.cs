
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoV1OutputRecommendationsSpecificItemProvider
    {
        /// <summary>
        ///
        /// </summary>
        Aws,
        /// <summary>
        ///
        /// </summary>
        AwsK8s,
        /// <summary>
        ///
        /// </summary>
        AwsNimbus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoV1OutputRecommendationsSpecificItemProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoV1OutputRecommendationsSpecificItemProvider value)
        {
            return value switch
            {
                RegionsInfoV1OutputRecommendationsSpecificItemProvider.Aws => "AWS",
                RegionsInfoV1OutputRecommendationsSpecificItemProvider.AwsK8s => "AWS_K8S",
                RegionsInfoV1OutputRecommendationsSpecificItemProvider.AwsNimbus => "AWS_NIMBUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoV1OutputRecommendationsSpecificItemProvider? ToEnum(string value)
        {
            return value switch
            {
                "AWS" => RegionsInfoV1OutputRecommendationsSpecificItemProvider.Aws,
                "AWS_K8S" => RegionsInfoV1OutputRecommendationsSpecificItemProvider.AwsK8s,
                "AWS_NIMBUS" => RegionsInfoV1OutputRecommendationsSpecificItemProvider.AwsNimbus,
                _ => null,
            };
        }
    }
}