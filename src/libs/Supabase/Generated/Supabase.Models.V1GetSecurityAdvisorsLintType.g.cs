
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: sql
    /// </summary>
    public enum V1GetSecurityAdvisorsLintType
    {
        /// <summary>
        /// 
        /// </summary>
        Sql,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1GetSecurityAdvisorsLintTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1GetSecurityAdvisorsLintType value)
        {
            return value switch
            {
                V1GetSecurityAdvisorsLintType.Sql => "sql",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1GetSecurityAdvisorsLintType? ToEnum(string value)
        {
            return value switch
            {
                "sql" => V1GetSecurityAdvisorsLintType.Sql,
                _ => null,
            };
        }
    }
}