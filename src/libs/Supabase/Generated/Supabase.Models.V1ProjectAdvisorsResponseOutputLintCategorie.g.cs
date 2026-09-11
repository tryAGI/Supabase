
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1ProjectAdvisorsResponseOutputLintCategorie
    {
        /// <summary>
        ///
        /// </summary>
        Health,
        /// <summary>
        ///
        /// </summary>
        Performance,
        /// <summary>
        ///
        /// </summary>
        Security,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ProjectAdvisorsResponseOutputLintCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectAdvisorsResponseOutputLintCategorie value)
        {
            return value switch
            {
                V1ProjectAdvisorsResponseOutputLintCategorie.Health => "HEALTH",
                V1ProjectAdvisorsResponseOutputLintCategorie.Performance => "PERFORMANCE",
                V1ProjectAdvisorsResponseOutputLintCategorie.Security => "SECURITY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectAdvisorsResponseOutputLintCategorie? ToEnum(string value)
        {
            return value switch
            {
                "HEALTH" => V1ProjectAdvisorsResponseOutputLintCategorie.Health,
                "PERFORMANCE" => V1ProjectAdvisorsResponseOutputLintCategorie.Performance,
                "SECURITY" => V1ProjectAdvisorsResponseOutputLintCategorie.Security,
                _ => null,
            };
        }
    }
}