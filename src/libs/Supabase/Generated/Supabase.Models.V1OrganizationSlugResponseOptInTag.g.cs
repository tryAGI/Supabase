
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1OrganizationSlugResponseOptInTag
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
    public static class V1OrganizationSlugResponseOptInTagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1OrganizationSlugResponseOptInTag value)
        {
            return value switch
            {
                V1OrganizationSlugResponseOptInTag.AiDataGeneratorOptIn => "AI_DATA_GENERATOR_OPT_IN",
                V1OrganizationSlugResponseOptInTag.AiLogGeneratorOptIn => "AI_LOG_GENERATOR_OPT_IN",
                V1OrganizationSlugResponseOptInTag.AiSqlGeneratorOptIn => "AI_SQL_GENERATOR_OPT_IN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1OrganizationSlugResponseOptInTag? ToEnum(string value)
        {
            return value switch
            {
                "AI_DATA_GENERATOR_OPT_IN" => V1OrganizationSlugResponseOptInTag.AiDataGeneratorOptIn,
                "AI_LOG_GENERATOR_OPT_IN" => V1OrganizationSlugResponseOptInTag.AiLogGeneratorOptIn,
                "AI_SQL_GENERATOR_OPT_IN" => V1OrganizationSlugResponseOptInTag.AiSqlGeneratorOptIn,
                _ => null,
            };
        }
    }
}