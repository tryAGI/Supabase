
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1ProjectAdvisorsResponseOutputLintLevel
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
    public static class V1ProjectAdvisorsResponseOutputLintLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectAdvisorsResponseOutputLintLevel value)
        {
            return value switch
            {
                V1ProjectAdvisorsResponseOutputLintLevel.Error => "ERROR",
                V1ProjectAdvisorsResponseOutputLintLevel.Info => "INFO",
                V1ProjectAdvisorsResponseOutputLintLevel.Warn => "WARN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectAdvisorsResponseOutputLintLevel? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => V1ProjectAdvisorsResponseOutputLintLevel.Error,
                "INFO" => V1ProjectAdvisorsResponseOutputLintLevel.Info,
                "WARN" => V1ProjectAdvisorsResponseOutputLintLevel.Warn,
                _ => null,
            };
        }
    }
}