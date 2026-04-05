
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Release channel. If not provided, GA will be used.
    /// </summary>
    public enum CreateBranchBodyReleaseChannel
    {
        /// <summary>
        /// 
        /// </summary>
        Alpha,
        /// <summary>
        /// 
        /// </summary>
        Beta,
        /// <summary>
        /// 
        /// </summary>
        Ga,
        /// <summary>
        /// 
        /// </summary>
        Internal,
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Withdrawn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBranchBodyReleaseChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBranchBodyReleaseChannel value)
        {
            return value switch
            {
                CreateBranchBodyReleaseChannel.Alpha => "alpha",
                CreateBranchBodyReleaseChannel.Beta => "beta",
                CreateBranchBodyReleaseChannel.Ga => "ga",
                CreateBranchBodyReleaseChannel.Internal => "internal",
                CreateBranchBodyReleaseChannel.Preview => "preview",
                CreateBranchBodyReleaseChannel.Withdrawn => "withdrawn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBranchBodyReleaseChannel? ToEnum(string value)
        {
            return value switch
            {
                "alpha" => CreateBranchBodyReleaseChannel.Alpha,
                "beta" => CreateBranchBodyReleaseChannel.Beta,
                "ga" => CreateBranchBodyReleaseChannel.Ga,
                "internal" => CreateBranchBodyReleaseChannel.Internal,
                "preview" => CreateBranchBodyReleaseChannel.Preview,
                "withdrawn" => CreateBranchBodyReleaseChannel.Withdrawn,
                _ => null,
            };
        }
    }
}