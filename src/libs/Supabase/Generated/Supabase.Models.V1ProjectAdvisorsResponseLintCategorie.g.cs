
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ProjectAdvisorsResponseLintCategorie
    {
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
    public static class V1ProjectAdvisorsResponseLintCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectAdvisorsResponseLintCategorie value)
        {
            return value switch
            {
                V1ProjectAdvisorsResponseLintCategorie.Performance => "PERFORMANCE",
                V1ProjectAdvisorsResponseLintCategorie.Security => "SECURITY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectAdvisorsResponseLintCategorie? ToEnum(string value)
        {
            return value switch
            {
                "PERFORMANCE" => V1ProjectAdvisorsResponseLintCategorie.Performance,
                "SECURITY" => V1ProjectAdvisorsResponseLintCategorie.Security,
                _ => null,
            };
        }
    }
}