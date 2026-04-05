
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ProjectAdvisorsResponseLintLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ProjectAdvisorsResponseLintLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectAdvisorsResponseLintLevel value)
        {
            return value switch
            {
                V1ProjectAdvisorsResponseLintLevel.Error => "ERROR",
                V1ProjectAdvisorsResponseLintLevel.Info => "INFO",
                V1ProjectAdvisorsResponseLintLevel.Warn => "WARN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectAdvisorsResponseLintLevel? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => V1ProjectAdvisorsResponseLintLevel.Error,
                "INFO" => V1ProjectAdvisorsResponseLintLevel.Info,
                "WARN" => V1ProjectAdvisorsResponseLintLevel.Warn,
                _ => null,
            };
        }
    }
}