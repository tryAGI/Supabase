
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoV1OutputAllSpecificItemProvider
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
    public static class RegionsInfoV1OutputAllSpecificItemProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoV1OutputAllSpecificItemProvider value)
        {
            return value switch
            {
                RegionsInfoV1OutputAllSpecificItemProvider.Aws => "AWS",
                RegionsInfoV1OutputAllSpecificItemProvider.AwsK8s => "AWS_K8S",
                RegionsInfoV1OutputAllSpecificItemProvider.AwsNimbus => "AWS_NIMBUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoV1OutputAllSpecificItemProvider? ToEnum(string value)
        {
            return value switch
            {
                "AWS" => RegionsInfoV1OutputAllSpecificItemProvider.Aws,
                "AWS_K8S" => RegionsInfoV1OutputAllSpecificItemProvider.AwsK8s,
                "AWS_NIMBUS" => RegionsInfoV1OutputAllSpecificItemProvider.AwsNimbus,
                _ => null,
            };
        }
    }
}