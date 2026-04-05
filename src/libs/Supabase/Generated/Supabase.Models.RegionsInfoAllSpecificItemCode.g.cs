
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegionsInfoAllSpecificItemCode
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
    public static class RegionsInfoAllSpecificItemCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoAllSpecificItemCode value)
        {
            return value switch
            {
                RegionsInfoAllSpecificItemCode.ApEast1 => "ap-east-1",
                RegionsInfoAllSpecificItemCode.ApNortheast1 => "ap-northeast-1",
                RegionsInfoAllSpecificItemCode.ApNortheast2 => "ap-northeast-2",
                RegionsInfoAllSpecificItemCode.ApSouth1 => "ap-south-1",
                RegionsInfoAllSpecificItemCode.ApSoutheast1 => "ap-southeast-1",
                RegionsInfoAllSpecificItemCode.ApSoutheast2 => "ap-southeast-2",
                RegionsInfoAllSpecificItemCode.CaCentral1 => "ca-central-1",
                RegionsInfoAllSpecificItemCode.EuCentral1 => "eu-central-1",
                RegionsInfoAllSpecificItemCode.EuCentral2 => "eu-central-2",
                RegionsInfoAllSpecificItemCode.EuNorth1 => "eu-north-1",
                RegionsInfoAllSpecificItemCode.EuWest1 => "eu-west-1",
                RegionsInfoAllSpecificItemCode.EuWest2 => "eu-west-2",
                RegionsInfoAllSpecificItemCode.EuWest3 => "eu-west-3",
                RegionsInfoAllSpecificItemCode.SaEast1 => "sa-east-1",
                RegionsInfoAllSpecificItemCode.UsEast1 => "us-east-1",
                RegionsInfoAllSpecificItemCode.UsEast2 => "us-east-2",
                RegionsInfoAllSpecificItemCode.UsWest1 => "us-west-1",
                RegionsInfoAllSpecificItemCode.UsWest2 => "us-west-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoAllSpecificItemCode? ToEnum(string value)
        {
            return value switch
            {
                "ap-east-1" => RegionsInfoAllSpecificItemCode.ApEast1,
                "ap-northeast-1" => RegionsInfoAllSpecificItemCode.ApNortheast1,
                "ap-northeast-2" => RegionsInfoAllSpecificItemCode.ApNortheast2,
                "ap-south-1" => RegionsInfoAllSpecificItemCode.ApSouth1,
                "ap-southeast-1" => RegionsInfoAllSpecificItemCode.ApSoutheast1,
                "ap-southeast-2" => RegionsInfoAllSpecificItemCode.ApSoutheast2,
                "ca-central-1" => RegionsInfoAllSpecificItemCode.CaCentral1,
                "eu-central-1" => RegionsInfoAllSpecificItemCode.EuCentral1,
                "eu-central-2" => RegionsInfoAllSpecificItemCode.EuCentral2,
                "eu-north-1" => RegionsInfoAllSpecificItemCode.EuNorth1,
                "eu-west-1" => RegionsInfoAllSpecificItemCode.EuWest1,
                "eu-west-2" => RegionsInfoAllSpecificItemCode.EuWest2,
                "eu-west-3" => RegionsInfoAllSpecificItemCode.EuWest3,
                "sa-east-1" => RegionsInfoAllSpecificItemCode.SaEast1,
                "us-east-1" => RegionsInfoAllSpecificItemCode.UsEast1,
                "us-east-2" => RegionsInfoAllSpecificItemCode.UsEast2,
                "us-west-1" => RegionsInfoAllSpecificItemCode.UsWest1,
                "us-west-2" => RegionsInfoAllSpecificItemCode.UsWest2,
                _ => null,
            };
        }
    }
}