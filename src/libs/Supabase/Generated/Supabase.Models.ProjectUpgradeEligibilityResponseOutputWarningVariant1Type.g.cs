
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputWarningVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        PgGraphqlIntrospectionChange,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseOutputWarningVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputWarningVariant1Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputWarningVariant1Type.PgGraphqlIntrospectionChange => "pg_graphql_introspection_change",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputWarningVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "pg_graphql_introspection_change" => ProjectUpgradeEligibilityResponseOutputWarningVariant1Type.PgGraphqlIntrospectionChange,
                _ => null,
            };
        }
    }
}