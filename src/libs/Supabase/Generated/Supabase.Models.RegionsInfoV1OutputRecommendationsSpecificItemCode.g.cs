
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoV1OutputRecommendationsSpecificItemCode
    {
        /// <summary>
        ///
        /// </summary>
        ApEast1,
        /// <summary>
        ///
        /// </summary>
        ApNortheast1,
        /// <summary>
        ///
        /// </summary>
        ApNortheast2,
        /// <summary>
        ///
        /// </summary>
        ApSouth1,
        /// <summary>
        ///
        /// </summary>
        ApSoutheast1,
        /// <summary>
        ///
        /// </summary>
        ApSoutheast2,
        /// <summary>
        ///
        /// </summary>
        CaCentral1,
        /// <summary>
        ///
        /// </summary>
        EuCentral1,
        /// <summary>
        ///
        /// </summary>
        EuCentral2,
        /// <summary>
        ///
        /// </summary>
        EuNorth1,
        /// <summary>
        ///
        /// </summary>
        EuWest1,
        /// <summary>
        ///
        /// </summary>
        EuWest2,
        /// <summary>
        ///
        /// </summary>
        EuWest3,
        /// <summary>
        ///
        /// </summary>
        SaEast1,
        /// <summary>
        ///
        /// </summary>
        UsEast1,
        /// <summary>
        ///
        /// </summary>
        UsEast2,
        /// <summary>
        ///
        /// </summary>
        UsWest1,
        /// <summary>
        ///
        /// </summary>
        UsWest2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegionsInfoV1OutputRecommendationsSpecificItemCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoV1OutputRecommendationsSpecificItemCode value)
        {
            return value switch
            {
                RegionsInfoV1OutputRecommendationsSpecificItemCode.ApEast1 => "ap-east-1",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.ApNortheast1 => "ap-northeast-1",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.ApNortheast2 => "ap-northeast-2",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.ApSouth1 => "ap-south-1",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.ApSoutheast1 => "ap-southeast-1",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.ApSoutheast2 => "ap-southeast-2",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.CaCentral1 => "ca-central-1",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.EuCentral1 => "eu-central-1",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.EuCentral2 => "eu-central-2",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.EuNorth1 => "eu-north-1",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.EuWest1 => "eu-west-1",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.EuWest2 => "eu-west-2",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.EuWest3 => "eu-west-3",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.SaEast1 => "sa-east-1",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.UsEast1 => "us-east-1",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.UsEast2 => "us-east-2",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.UsWest1 => "us-west-1",
                RegionsInfoV1OutputRecommendationsSpecificItemCode.UsWest2 => "us-west-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoV1OutputRecommendationsSpecificItemCode? ToEnum(string value)
        {
            return value switch
            {
                "ap-east-1" => RegionsInfoV1OutputRecommendationsSpecificItemCode.ApEast1,
                "ap-northeast-1" => RegionsInfoV1OutputRecommendationsSpecificItemCode.ApNortheast1,
                "ap-northeast-2" => RegionsInfoV1OutputRecommendationsSpecificItemCode.ApNortheast2,
                "ap-south-1" => RegionsInfoV1OutputRecommendationsSpecificItemCode.ApSouth1,
                "ap-southeast-1" => RegionsInfoV1OutputRecommendationsSpecificItemCode.ApSoutheast1,
                "ap-southeast-2" => RegionsInfoV1OutputRecommendationsSpecificItemCode.ApSoutheast2,
                "ca-central-1" => RegionsInfoV1OutputRecommendationsSpecificItemCode.CaCentral1,
                "eu-central-1" => RegionsInfoV1OutputRecommendationsSpecificItemCode.EuCentral1,
                "eu-central-2" => RegionsInfoV1OutputRecommendationsSpecificItemCode.EuCentral2,
                "eu-north-1" => RegionsInfoV1OutputRecommendationsSpecificItemCode.EuNorth1,
                "eu-west-1" => RegionsInfoV1OutputRecommendationsSpecificItemCode.EuWest1,
                "eu-west-2" => RegionsInfoV1OutputRecommendationsSpecificItemCode.EuWest2,
                "eu-west-3" => RegionsInfoV1OutputRecommendationsSpecificItemCode.EuWest3,
                "sa-east-1" => RegionsInfoV1OutputRecommendationsSpecificItemCode.SaEast1,
                "us-east-1" => RegionsInfoV1OutputRecommendationsSpecificItemCode.UsEast1,
                "us-east-2" => RegionsInfoV1OutputRecommendationsSpecificItemCode.UsEast2,
                "us-west-1" => RegionsInfoV1OutputRecommendationsSpecificItemCode.UsWest1,
                "us-west-2" => RegionsInfoV1OutputRecommendationsSpecificItemCode.UsWest2,
                _ => null,
            };
        }
    }
}