
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegionsInfoRecommendationsSpecificItemProvider
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
        /// <summary>
        /// 
        /// </summary>
        Fly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoRecommendationsSpecificItemProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoRecommendationsSpecificItemProvider value)
        {
            return value switch
            {
                RegionsInfoRecommendationsSpecificItemProvider.Aws => "AWS",
                RegionsInfoRecommendationsSpecificItemProvider.AwsK8s => "AWS_K8S",
                RegionsInfoRecommendationsSpecificItemProvider.AwsNimbus => "AWS_NIMBUS",
                RegionsInfoRecommendationsSpecificItemProvider.Fly => "FLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoRecommendationsSpecificItemProvider? ToEnum(string value)
        {
            return value switch
            {
                "AWS" => RegionsInfoRecommendationsSpecificItemProvider.Aws,
                "AWS_K8S" => RegionsInfoRecommendationsSpecificItemProvider.AwsK8s,
                "AWS_NIMBUS" => RegionsInfoRecommendationsSpecificItemProvider.AwsNimbus,
                "FLY" => RegionsInfoRecommendationsSpecificItemProvider.Fly,
                _ => null,
            };
        }
    }
}