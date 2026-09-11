
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoOutputRecommendationsSpecificItemCode
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
    public static class RegionsInfoOutputRecommendationsSpecificItemCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoOutputRecommendationsSpecificItemCode value)
        {
            return value switch
            {
                RegionsInfoOutputRecommendationsSpecificItemCode.ApEast1 => "ap-east-1",
                RegionsInfoOutputRecommendationsSpecificItemCode.ApNortheast1 => "ap-northeast-1",
                RegionsInfoOutputRecommendationsSpecificItemCode.ApNortheast2 => "ap-northeast-2",
                RegionsInfoOutputRecommendationsSpecificItemCode.ApSouth1 => "ap-south-1",
                RegionsInfoOutputRecommendationsSpecificItemCode.ApSoutheast1 => "ap-southeast-1",
                RegionsInfoOutputRecommendationsSpecificItemCode.ApSoutheast2 => "ap-southeast-2",
                RegionsInfoOutputRecommendationsSpecificItemCode.CaCentral1 => "ca-central-1",
                RegionsInfoOutputRecommendationsSpecificItemCode.EuCentral1 => "eu-central-1",
                RegionsInfoOutputRecommendationsSpecificItemCode.EuCentral2 => "eu-central-2",
                RegionsInfoOutputRecommendationsSpecificItemCode.EuNorth1 => "eu-north-1",
                RegionsInfoOutputRecommendationsSpecificItemCode.EuWest1 => "eu-west-1",
                RegionsInfoOutputRecommendationsSpecificItemCode.EuWest2 => "eu-west-2",
                RegionsInfoOutputRecommendationsSpecificItemCode.EuWest3 => "eu-west-3",
                RegionsInfoOutputRecommendationsSpecificItemCode.SaEast1 => "sa-east-1",
                RegionsInfoOutputRecommendationsSpecificItemCode.UsEast1 => "us-east-1",
                RegionsInfoOutputRecommendationsSpecificItemCode.UsEast2 => "us-east-2",
                RegionsInfoOutputRecommendationsSpecificItemCode.UsWest1 => "us-west-1",
                RegionsInfoOutputRecommendationsSpecificItemCode.UsWest2 => "us-west-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoOutputRecommendationsSpecificItemCode? ToEnum(string value)
        {
            return value switch
            {
                "ap-east-1" => RegionsInfoOutputRecommendationsSpecificItemCode.ApEast1,
                "ap-northeast-1" => RegionsInfoOutputRecommendationsSpecificItemCode.ApNortheast1,
                "ap-northeast-2" => RegionsInfoOutputRecommendationsSpecificItemCode.ApNortheast2,
                "ap-south-1" => RegionsInfoOutputRecommendationsSpecificItemCode.ApSouth1,
                "ap-southeast-1" => RegionsInfoOutputRecommendationsSpecificItemCode.ApSoutheast1,
                "ap-southeast-2" => RegionsInfoOutputRecommendationsSpecificItemCode.ApSoutheast2,
                "ca-central-1" => RegionsInfoOutputRecommendationsSpecificItemCode.CaCentral1,
                "eu-central-1" => RegionsInfoOutputRecommendationsSpecificItemCode.EuCentral1,
                "eu-central-2" => RegionsInfoOutputRecommendationsSpecificItemCode.EuCentral2,
                "eu-north-1" => RegionsInfoOutputRecommendationsSpecificItemCode.EuNorth1,
                "eu-west-1" => RegionsInfoOutputRecommendationsSpecificItemCode.EuWest1,
                "eu-west-2" => RegionsInfoOutputRecommendationsSpecificItemCode.EuWest2,
                "eu-west-3" => RegionsInfoOutputRecommendationsSpecificItemCode.EuWest3,
                "sa-east-1" => RegionsInfoOutputRecommendationsSpecificItemCode.SaEast1,
                "us-east-1" => RegionsInfoOutputRecommendationsSpecificItemCode.UsEast1,
                "us-east-2" => RegionsInfoOutputRecommendationsSpecificItemCode.UsEast2,
                "us-west-1" => RegionsInfoOutputRecommendationsSpecificItemCode.UsWest1,
                "us-west-2" => RegionsInfoOutputRecommendationsSpecificItemCode.UsWest2,
                _ => null,
            };
        }
    }
}