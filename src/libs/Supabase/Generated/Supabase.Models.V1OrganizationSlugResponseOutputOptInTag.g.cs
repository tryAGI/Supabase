
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1OrganizationSlugResponseOutputOptInTag
    {
        /// <summary>
        ///
        /// </summary>
        AiDataGeneratorOptIn,
        /// <summary>
        ///
        /// </summary>
        AiLogGeneratorOptIn,
        /// <summary>
        ///
        /// </summary>
        AiSqlGeneratorOptIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1OrganizationSlugResponseOutputOptInTagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1OrganizationSlugResponseOutputOptInTag value)
        {
            return value switch
            {
                V1OrganizationSlugResponseOutputOptInTag.AiDataGeneratorOptIn => "AI_DATA_GENERATOR_OPT_IN",
                V1OrganizationSlugResponseOutputOptInTag.AiLogGeneratorOptIn => "AI_LOG_GENERATOR_OPT_IN",
                V1OrganizationSlugResponseOutputOptInTag.AiSqlGeneratorOptIn => "AI_SQL_GENERATOR_OPT_IN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1OrganizationSlugResponseOutputOptInTag? ToEnum(string value)
        {
            return value switch
            {
                "AI_DATA_GENERATOR_OPT_IN" => V1OrganizationSlugResponseOutputOptInTag.AiDataGeneratorOptIn,
                "AI_LOG_GENERATOR_OPT_IN" => V1OrganizationSlugResponseOutputOptInTag.AiLogGeneratorOptIn,
                "AI_SQL_GENERATOR_OPT_IN" => V1OrganizationSlugResponseOutputOptInTag.AiSqlGeneratorOptIn,
                _ => null,
            };
        }
    }
}