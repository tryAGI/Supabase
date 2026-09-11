
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoOutputRecommendationsSpecificItemProvider
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
    public static class RegionsInfoOutputRecommendationsSpecificItemProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoOutputRecommendationsSpecificItemProvider value)
        {
            return value switch
            {
                RegionsInfoOutputRecommendationsSpecificItemProvider.Aws => "AWS",
                RegionsInfoOutputRecommendationsSpecificItemProvider.AwsK8s => "AWS_K8S",
                RegionsInfoOutputRecommendationsSpecificItemProvider.AwsNimbus => "AWS_NIMBUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoOutputRecommendationsSpecificItemProvider? ToEnum(string value)
        {
            return value switch
            {
                "AWS" => RegionsInfoOutputRecommendationsSpecificItemProvider.Aws,
                "AWS_K8S" => RegionsInfoOutputRecommendationsSpecificItemProvider.AwsK8s,
                "AWS_NIMBUS" => RegionsInfoOutputRecommendationsSpecificItemProvider.AwsNimbus,
                _ => null,
            };
        }
    }
}