
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Region you want your read replica to reside in<br/>
    /// Example: us-east-1
    /// </summary>
    public enum SetUpReadReplicaBodyReadReplicaRegion
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
    public static class SetUpReadReplicaBodyReadReplicaRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetUpReadReplicaBodyReadReplicaRegion value)
        {
            return value switch
            {
                SetUpReadReplicaBodyReadReplicaRegion.ApEast1 => "ap-east-1",
                SetUpReadReplicaBodyReadReplicaRegion.ApNortheast1 => "ap-northeast-1",
                SetUpReadReplicaBodyReadReplicaRegion.ApNortheast2 => "ap-northeast-2",
                SetUpReadReplicaBodyReadReplicaRegion.ApSouth1 => "ap-south-1",
                SetUpReadReplicaBodyReadReplicaRegion.ApSoutheast1 => "ap-southeast-1",
                SetUpReadReplicaBodyReadReplicaRegion.ApSoutheast2 => "ap-southeast-2",
                SetUpReadReplicaBodyReadReplicaRegion.CaCentral1 => "ca-central-1",
                SetUpReadReplicaBodyReadReplicaRegion.EuCentral1 => "eu-central-1",
                SetUpReadReplicaBodyReadReplicaRegion.EuCentral2 => "eu-central-2",
                SetUpReadReplicaBodyReadReplicaRegion.EuNorth1 => "eu-north-1",
                SetUpReadReplicaBodyReadReplicaRegion.EuWest1 => "eu-west-1",
                SetUpReadReplicaBodyReadReplicaRegion.EuWest2 => "eu-west-2",
                SetUpReadReplicaBodyReadReplicaRegion.EuWest3 => "eu-west-3",
                SetUpReadReplicaBodyReadReplicaRegion.SaEast1 => "sa-east-1",
                SetUpReadReplicaBodyReadReplicaRegion.UsEast1 => "us-east-1",
                SetUpReadReplicaBodyReadReplicaRegion.UsEast2 => "us-east-2",
                SetUpReadReplicaBodyReadReplicaRegion.UsWest1 => "us-west-1",
                SetUpReadReplicaBodyReadReplicaRegion.UsWest2 => "us-west-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetUpReadReplicaBodyReadReplicaRegion? ToEnum(string value)
        {
            return value switch
            {
                "ap-east-1" => SetUpReadReplicaBodyReadReplicaRegion.ApEast1,
                "ap-northeast-1" => SetUpReadReplicaBodyReadReplicaRegion.ApNortheast1,
                "ap-northeast-2" => SetUpReadReplicaBodyReadReplicaRegion.ApNortheast2,
                "ap-south-1" => SetUpReadReplicaBodyReadReplicaRegion.ApSouth1,
                "ap-southeast-1" => SetUpReadReplicaBodyReadReplicaRegion.ApSoutheast1,
                "ap-southeast-2" => SetUpReadReplicaBodyReadReplicaRegion.ApSoutheast2,
                "ca-central-1" => SetUpReadReplicaBodyReadReplicaRegion.CaCentral1,
                "eu-central-1" => SetUpReadReplicaBodyReadReplicaRegion.EuCentral1,
                "eu-central-2" => SetUpReadReplicaBodyReadReplicaRegion.EuCentral2,
                "eu-north-1" => SetUpReadReplicaBodyReadReplicaRegion.EuNorth1,
                "eu-west-1" => SetUpReadReplicaBodyReadReplicaRegion.EuWest1,
                "eu-west-2" => SetUpReadReplicaBodyReadReplicaRegion.EuWest2,
                "eu-west-3" => SetUpReadReplicaBodyReadReplicaRegion.EuWest3,
                "sa-east-1" => SetUpReadReplicaBodyReadReplicaRegion.SaEast1,
                "us-east-1" => SetUpReadReplicaBodyReadReplicaRegion.UsEast1,
                "us-east-2" => SetUpReadReplicaBodyReadReplicaRegion.UsEast2,
                "us-west-1" => SetUpReadReplicaBodyReadReplicaRegion.UsWest1,
                "us-west-2" => SetUpReadReplicaBodyReadReplicaRegion.UsWest2,
                _ => null,
            };
        }
    }
}