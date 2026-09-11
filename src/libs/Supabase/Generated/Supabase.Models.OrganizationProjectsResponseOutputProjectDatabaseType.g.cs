
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum OrganizationProjectsResponseOutputProjectDatabaseType
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
    public static class OrganizationProjectsResponseOutputProjectDatabaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectsResponseOutputProjectDatabaseType value)
        {
            return value switch
            {
                OrganizationProjectsResponseOutputProjectDatabaseType.Primary => "PRIMARY",
                OrganizationProjectsResponseOutputProjectDatabaseType.ReadReplica => "READ_REPLICA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectsResponseOutputProjectDatabaseType? ToEnum(string value)
        {
            return value switch
            {
                "PRIMARY" => OrganizationProjectsResponseOutputProjectDatabaseType.Primary,
                "READ_REPLICA" => OrganizationProjectsResponseOutputProjectDatabaseType.ReadReplica,
                _ => null,
            };
        }
    }
}