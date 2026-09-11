
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoOutputAllSpecificItemProvider
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
    public static class RegionsInfoOutputAllSpecificItemProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoOutputAllSpecificItemProvider value)
        {
            return value switch
            {
                RegionsInfoOutputAllSpecificItemProvider.Aws => "AWS",
                RegionsInfoOutputAllSpecificItemProvider.AwsK8s => "AWS_K8S",
                RegionsInfoOutputAllSpecificItemProvider.AwsNimbus => "AWS_NIMBUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoOutputAllSpecificItemProvider? ToEnum(string value)
        {
            return value switch
            {
                "AWS" => RegionsInfoOutputAllSpecificItemProvider.Aws,
                "AWS_K8S" => RegionsInfoOutputAllSpecificItemProvider.AwsK8s,
                "AWS_NIMBUS" => RegionsInfoOutputAllSpecificItemProvider.AwsNimbus,
                _ => null,
            };
        }
    }
}