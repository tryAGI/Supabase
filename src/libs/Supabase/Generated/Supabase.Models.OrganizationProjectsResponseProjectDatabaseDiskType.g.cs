
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrganizationProjectsResponseProjectDatabaseDiskType
    {
        /// <summary>
        /// 
        /// </summary>
        Gp3,
        /// <summary>
        /// 
        /// </summary>
        Io2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationProjectsResponseProjectDatabaseDiskTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectsResponseProjectDatabaseDiskType value)
        {
            return value switch
            {
                OrganizationProjectsResponseProjectDatabaseDiskType.Gp3 => "gp3",
                OrganizationProjectsResponseProjectDatabaseDiskType.Io2 => "io2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectsResponseProjectDatabaseDiskType? ToEnum(string value)
        {
            return value switch
            {
                "gp3" => OrganizationProjectsResponseProjectDatabaseDiskType.Gp3,
                "io2" => OrganizationProjectsResponseProjectDatabaseDiskType.Io2,
                _ => null,
            };
        }
    }
}