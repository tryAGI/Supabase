
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrganizationProjectsResponseProjectDatabaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Primary,
        /// <summary>
        /// 
        /// </summary>
        ReadReplica,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationProjectsResponseProjectDatabaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectsResponseProjectDatabaseType value)
        {
            return value switch
            {
                OrganizationProjectsResponseProjectDatabaseType.Primary => "PRIMARY",
                OrganizationProjectsResponseProjectDatabaseType.ReadReplica => "READ_REPLICA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectsResponseProjectDatabaseType? ToEnum(string value)
        {
            return value switch
            {
                "PRIMARY" => OrganizationProjectsResponseProjectDatabaseType.Primary,
                "READ_REPLICA" => OrganizationProjectsResponseProjectDatabaseType.ReadReplica,
                _ => null,
            };
        }
    }
}