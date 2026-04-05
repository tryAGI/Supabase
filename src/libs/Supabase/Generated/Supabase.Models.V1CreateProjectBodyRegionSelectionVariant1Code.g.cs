
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Specific region code. The codes supported are not a stable API, and should be retrieved from the /available-regions endpoint.
    /// </summary>
    public enum V1CreateProjectBodyRegionSelectionVariant1Code
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
    public static class V1CreateProjectBodyRegionSelectionVariant1CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1CreateProjectBodyRegionSelectionVariant1Code value)
        {
            return value switch
            {
                V1CreateProjectBodyRegionSelectionVariant1Code.ApEast1 => "ap-east-1",
                V1CreateProjectBodyRegionSelectionVariant1Code.ApNortheast1 => "ap-northeast-1",
                V1CreateProjectBodyRegionSelectionVariant1Code.ApNortheast2 => "ap-northeast-2",
                V1CreateProjectBodyRegionSelectionVariant1Code.ApSouth1 => "ap-south-1",
                V1CreateProjectBodyRegionSelectionVariant1Code.ApSoutheast1 => "ap-southeast-1",
                V1CreateProjectBodyRegionSelectionVariant1Code.ApSoutheast2 => "ap-southeast-2",
                V1CreateProjectBodyRegionSelectionVariant1Code.CaCentral1 => "ca-central-1",
                V1CreateProjectBodyRegionSelectionVariant1Code.EuCentral1 => "eu-central-1",
                V1CreateProjectBodyRegionSelectionVariant1Code.EuCentral2 => "eu-central-2",
                V1CreateProjectBodyRegionSelectionVariant1Code.EuNorth1 => "eu-north-1",
                V1CreateProjectBodyRegionSelectionVariant1Code.EuWest1 => "eu-west-1",
                V1CreateProjectBodyRegionSelectionVariant1Code.EuWest2 => "eu-west-2",
                V1CreateProjectBodyRegionSelectionVariant1Code.EuWest3 => "eu-west-3",
                V1CreateProjectBodyRegionSelectionVariant1Code.SaEast1 => "sa-east-1",
                V1CreateProjectBodyRegionSelectionVariant1Code.UsEast1 => "us-east-1",
                V1CreateProjectBodyRegionSelectionVariant1Code.UsEast2 => "us-east-2",
                V1CreateProjectBodyRegionSelectionVariant1Code.UsWest1 => "us-west-1",
                V1CreateProjectBodyRegionSelectionVariant1Code.UsWest2 => "us-west-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1CreateProjectBodyRegionSelectionVariant1Code? ToEnum(string value)
        {
            return value switch
            {
                "ap-east-1" => V1CreateProjectBodyRegionSelectionVariant1Code.ApEast1,
                "ap-northeast-1" => V1CreateProjectBodyRegionSelectionVariant1Code.ApNortheast1,
                "ap-northeast-2" => V1CreateProjectBodyRegionSelectionVariant1Code.ApNortheast2,
                "ap-south-1" => V1CreateProjectBodyRegionSelectionVariant1Code.ApSouth1,
                "ap-southeast-1" => V1CreateProjectBodyRegionSelectionVariant1Code.ApSoutheast1,
                "ap-southeast-2" => V1CreateProjectBodyRegionSelectionVariant1Code.ApSoutheast2,
                "ca-central-1" => V1CreateProjectBodyRegionSelectionVariant1Code.CaCentral1,
                "eu-central-1" => V1CreateProjectBodyRegionSelectionVariant1Code.EuCentral1,
                "eu-central-2" => V1CreateProjectBodyRegionSelectionVariant1Code.EuCentral2,
                "eu-north-1" => V1CreateProjectBodyRegionSelectionVariant1Code.EuNorth1,
                "eu-west-1" => V1CreateProjectBodyRegionSelectionVariant1Code.EuWest1,
                "eu-west-2" => V1CreateProjectBodyRegionSelectionVariant1Code.EuWest2,
                "eu-west-3" => V1CreateProjectBodyRegionSelectionVariant1Code.EuWest3,
                "sa-east-1" => V1CreateProjectBodyRegionSelectionVariant1Code.SaEast1,
                "us-east-1" => V1CreateProjectBodyRegionSelectionVariant1Code.UsEast1,
                "us-east-2" => V1CreateProjectBodyRegionSelectionVariant1Code.UsEast2,
                "us-west-1" => V1CreateProjectBodyRegionSelectionVariant1Code.UsWest1,
                "us-west-2" => V1CreateProjectBodyRegionSelectionVariant1Code.UsWest2,
                _ => null,
            };
        }
    }
}