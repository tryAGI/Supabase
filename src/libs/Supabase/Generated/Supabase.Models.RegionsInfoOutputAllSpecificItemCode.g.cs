
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum RegionsInfoOutputAllSpecificItemCode
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
    public static class RegionsInfoOutputAllSpecificItemCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegionsInfoOutputAllSpecificItemCode value)
        {
            return value switch
            {
                RegionsInfoOutputAllSpecificItemCode.ApEast1 => "ap-east-1",
                RegionsInfoOutputAllSpecificItemCode.ApNortheast1 => "ap-northeast-1",
                RegionsInfoOutputAllSpecificItemCode.ApNortheast2 => "ap-northeast-2",
                RegionsInfoOutputAllSpecificItemCode.ApSouth1 => "ap-south-1",
                RegionsInfoOutputAllSpecificItemCode.ApSoutheast1 => "ap-southeast-1",
                RegionsInfoOutputAllSpecificItemCode.ApSoutheast2 => "ap-southeast-2",
                RegionsInfoOutputAllSpecificItemCode.CaCentral1 => "ca-central-1",
                RegionsInfoOutputAllSpecificItemCode.EuCentral1 => "eu-central-1",
                RegionsInfoOutputAllSpecificItemCode.EuCentral2 => "eu-central-2",
                RegionsInfoOutputAllSpecificItemCode.EuNorth1 => "eu-north-1",
                RegionsInfoOutputAllSpecificItemCode.EuWest1 => "eu-west-1",
                RegionsInfoOutputAllSpecificItemCode.EuWest2 => "eu-west-2",
                RegionsInfoOutputAllSpecificItemCode.EuWest3 => "eu-west-3",
                RegionsInfoOutputAllSpecificItemCode.SaEast1 => "sa-east-1",
                RegionsInfoOutputAllSpecificItemCode.UsEast1 => "us-east-1",
                RegionsInfoOutputAllSpecificItemCode.UsEast2 => "us-east-2",
                RegionsInfoOutputAllSpecificItemCode.UsWest1 => "us-west-1",
                RegionsInfoOutputAllSpecificItemCode.UsWest2 => "us-west-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegionsInfoOutputAllSpecificItemCode? ToEnum(string value)
        {
            return value switch
            {
                "ap-east-1" => RegionsInfoOutputAllSpecificItemCode.ApEast1,
                "ap-northeast-1" => RegionsInfoOutputAllSpecificItemCode.ApNortheast1,
                "ap-northeast-2" => RegionsInfoOutputAllSpecificItemCode.ApNortheast2,
                "ap-south-1" => RegionsInfoOutputAllSpecificItemCode.ApSouth1,
                "ap-southeast-1" => RegionsInfoOutputAllSpecificItemCode.ApSoutheast1,
                "ap-southeast-2" => RegionsInfoOutputAllSpecificItemCode.ApSoutheast2,
                "ca-central-1" => RegionsInfoOutputAllSpecificItemCode.CaCentral1,
                "eu-central-1" => RegionsInfoOutputAllSpecificItemCode.EuCentral1,
                "eu-central-2" => RegionsInfoOutputAllSpecificItemCode.EuCentral2,
                "eu-north-1" => RegionsInfoOutputAllSpecificItemCode.EuNorth1,
                "eu-west-1" => RegionsInfoOutputAllSpecificItemCode.EuWest1,
                "eu-west-2" => RegionsInfoOutputAllSpecificItemCode.EuWest2,
                "eu-west-3" => RegionsInfoOutputAllSpecificItemCode.EuWest3,
                "sa-east-1" => RegionsInfoOutputAllSpecificItemCode.SaEast1,
                "us-east-1" => RegionsInfoOutputAllSpecificItemCode.UsEast1,
                "us-east-2" => RegionsInfoOutputAllSpecificItemCode.UsEast2,
                "us-west-1" => RegionsInfoOutputAllSpecificItemCode.UsWest1,
                "us-west-2" => RegionsInfoOutputAllSpecificItemCode.UsWest2,
                _ => null,
            };
        }
    }
}