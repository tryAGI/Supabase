
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegionsInfoAllSpecificItemProvider
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
    public static class RegionsInfoAllSpecificItemProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoAllSpecificItemProvider value)
        {
            return value switch
            {
                RegionsInfoAllSpecificItemProvider.Aws => "AWS",
                RegionsInfoAllSpecificItemProvider.AwsK8s => "AWS_K8S",
                RegionsInfoAllSpecificItemProvider.AwsNimbus => "AWS_NIMBUS",
                RegionsInfoAllSpecificItemProvider.Fly => "FLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoAllSpecificItemProvider? ToEnum(string value)
        {
            return value switch
            {
                "AWS" => RegionsInfoAllSpecificItemProvider.Aws,
                "AWS_K8S" => RegionsInfoAllSpecificItemProvider.AwsK8s,
                "AWS_NIMBUS" => RegionsInfoAllSpecificItemProvider.AwsNimbus,
                "FLY" => RegionsInfoAllSpecificItemProvider.Fly,
                _ => null,
            };
        }
    }
}