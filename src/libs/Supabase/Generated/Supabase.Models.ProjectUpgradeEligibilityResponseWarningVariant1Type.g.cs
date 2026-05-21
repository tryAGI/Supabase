
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseWarningVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        PgGraphqlIntrospectionChange,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseWarningVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseWarningVariant1Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseWarningVariant1Type.PgGraphqlIntrospectionChange => "pg_graphql_introspection_change",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseWarningVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "pg_graphql_introspection_change" => ProjectUpgradeEligibilityResponseWarningVariant1Type.PgGraphqlIntrospectionChange,
                _ => null,
            };
        }
    }
}