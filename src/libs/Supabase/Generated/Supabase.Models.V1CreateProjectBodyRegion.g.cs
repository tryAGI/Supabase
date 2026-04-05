
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Region you want your server to reside in. Use region_selection instead.<br/>
    /// Example: us-east-1
    /// </summary>
    public enum V1CreateProjectBodyRegion
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
    public static class V1CreateProjectBodyRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1CreateProjectBodyRegion value)
        {
            return value switch
            {
                V1CreateProjectBodyRegion.ApEast1 => "ap-east-1",
                V1CreateProjectBodyRegion.ApNortheast1 => "ap-northeast-1",
                V1CreateProjectBodyRegion.ApNortheast2 => "ap-northeast-2",
                V1CreateProjectBodyRegion.ApSouth1 => "ap-south-1",
                V1CreateProjectBodyRegion.ApSoutheast1 => "ap-southeast-1",
                V1CreateProjectBodyRegion.ApSoutheast2 => "ap-southeast-2",
                V1CreateProjectBodyRegion.CaCentral1 => "ca-central-1",
                V1CreateProjectBodyRegion.EuCentral1 => "eu-central-1",
                V1CreateProjectBodyRegion.EuCentral2 => "eu-central-2",
                V1CreateProjectBodyRegion.EuNorth1 => "eu-north-1",
                V1CreateProjectBodyRegion.EuWest1 => "eu-west-1",
                V1CreateProjectBodyRegion.EuWest2 => "eu-west-2",
                V1CreateProjectBodyRegion.EuWest3 => "eu-west-3",
                V1CreateProjectBodyRegion.SaEast1 => "sa-east-1",
                V1CreateProjectBodyRegion.UsEast1 => "us-east-1",
                V1CreateProjectBodyRegion.UsEast2 => "us-east-2",
                V1CreateProjectBodyRegion.UsWest1 => "us-west-1",
                V1CreateProjectBodyRegion.UsWest2 => "us-west-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1CreateProjectBodyRegion? ToEnum(string value)
        {
            return value switch
            {
                "ap-east-1" => V1CreateProjectBodyRegion.ApEast1,
                "ap-northeast-1" => V1CreateProjectBodyRegion.ApNortheast1,
                "ap-northeast-2" => V1CreateProjectBodyRegion.ApNortheast2,
                "ap-south-1" => V1CreateProjectBodyRegion.ApSouth1,
                "ap-southeast-1" => V1CreateProjectBodyRegion.ApSoutheast1,
                "ap-southeast-2" => V1CreateProjectBodyRegion.ApSoutheast2,
                "ca-central-1" => V1CreateProjectBodyRegion.CaCentral1,
                "eu-central-1" => V1CreateProjectBodyRegion.EuCentral1,
                "eu-central-2" => V1CreateProjectBodyRegion.EuCentral2,
                "eu-north-1" => V1CreateProjectBodyRegion.EuNorth1,
                "eu-west-1" => V1CreateProjectBodyRegion.EuWest1,
                "eu-west-2" => V1CreateProjectBodyRegion.EuWest2,
                "eu-west-3" => V1CreateProjectBodyRegion.EuWest3,
                "sa-east-1" => V1CreateProjectBodyRegion.SaEast1,
                "us-east-1" => V1CreateProjectBodyRegion.UsEast1,
                "us-east-2" => V1CreateProjectBodyRegion.UsEast2,
                "us-west-1" => V1CreateProjectBodyRegion.UsWest1,
                "us-west-2" => V1CreateProjectBodyRegion.UsWest2,
                _ => null,
            };
        }
    }
}