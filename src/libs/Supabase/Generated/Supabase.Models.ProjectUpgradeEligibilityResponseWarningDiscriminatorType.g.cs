
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseWarningDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        PgGraphqlIntrospectionChange,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseWarningDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseWarningDiscriminatorType value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseWarningDiscriminatorType.PgGraphqlIntrospectionChange => "pg_graphql_introspection_change",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseWarningDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "pg_graphql_introspection_change" => ProjectUpgradeEligibilityResponseWarningDiscriminatorType.PgGraphqlIntrospectionChange,
                _ => null,
            };
        }
    }
}