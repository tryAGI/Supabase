
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegionsInfoRecommendationsSpecificItemCode
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
    public static class RegionsInfoRecommendationsSpecificItemCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoRecommendationsSpecificItemCode value)
        {
            return value switch
            {
                RegionsInfoRecommendationsSpecificItemCode.ApEast1 => "ap-east-1",
                RegionsInfoRecommendationsSpecificItemCode.ApNortheast1 => "ap-northeast-1",
                RegionsInfoRecommendationsSpecificItemCode.ApNortheast2 => "ap-northeast-2",
                RegionsInfoRecommendationsSpecificItemCode.ApSouth1 => "ap-south-1",
                RegionsInfoRecommendationsSpecificItemCode.ApSoutheast1 => "ap-southeast-1",
                RegionsInfoRecommendationsSpecificItemCode.ApSoutheast2 => "ap-southeast-2",
                RegionsInfoRecommendationsSpecificItemCode.CaCentral1 => "ca-central-1",
                RegionsInfoRecommendationsSpecificItemCode.EuCentral1 => "eu-central-1",
                RegionsInfoRecommendationsSpecificItemCode.EuCentral2 => "eu-central-2",
                RegionsInfoRecommendationsSpecificItemCode.EuNorth1 => "eu-north-1",
                RegionsInfoRecommendationsSpecificItemCode.EuWest1 => "eu-west-1",
                RegionsInfoRecommendationsSpecificItemCode.EuWest2 => "eu-west-2",
                RegionsInfoRecommendationsSpecificItemCode.EuWest3 => "eu-west-3",
                RegionsInfoRecommendationsSpecificItemCode.SaEast1 => "sa-east-1",
                RegionsInfoRecommendationsSpecificItemCode.UsEast1 => "us-east-1",
                RegionsInfoRecommendationsSpecificItemCode.UsEast2 => "us-east-2",
                RegionsInfoRecommendationsSpecificItemCode.UsWest1 => "us-west-1",
                RegionsInfoRecommendationsSpecificItemCode.UsWest2 => "us-west-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoRecommendationsSpecificItemCode? ToEnum(string value)
        {
            return value switch
            {
                "ap-east-1" => RegionsInfoRecommendationsSpecificItemCode.ApEast1,
                "ap-northeast-1" => RegionsInfoRecommendationsSpecificItemCode.ApNortheast1,
                "ap-northeast-2" => RegionsInfoRecommendationsSpecificItemCode.ApNortheast2,
                "ap-south-1" => RegionsInfoRecommendationsSpecificItemCode.ApSouth1,
                "ap-southeast-1" => RegionsInfoRecommendationsSpecificItemCode.ApSoutheast1,
                "ap-southeast-2" => RegionsInfoRecommendationsSpecificItemCode.ApSoutheast2,
                "ca-central-1" => RegionsInfoRecommendationsSpecificItemCode.CaCentral1,
                "eu-central-1" => RegionsInfoRecommendationsSpecificItemCode.EuCentral1,
                "eu-central-2" => RegionsInfoRecommendationsSpecificItemCode.EuCentral2,
                "eu-north-1" => RegionsInfoRecommendationsSpecificItemCode.EuNorth1,
                "eu-west-1" => RegionsInfoRecommendationsSpecificItemCode.EuWest1,
                "eu-west-2" => RegionsInfoRecommendationsSpecificItemCode.EuWest2,
                "eu-west-3" => RegionsInfoRecommendationsSpecificItemCode.EuWest3,
                "sa-east-1" => RegionsInfoRecommendationsSpecificItemCode.SaEast1,
                "us-east-1" => RegionsInfoRecommendationsSpecificItemCode.UsEast1,
                "us-east-2" => RegionsInfoRecommendationsSpecificItemCode.UsEast2,
                "us-west-1" => RegionsInfoRecommendationsSpecificItemCode.UsWest1,
                "us-west-2" => RegionsInfoRecommendationsSpecificItemCode.UsWest2,
                _ => null,
            };
        }
    }
}