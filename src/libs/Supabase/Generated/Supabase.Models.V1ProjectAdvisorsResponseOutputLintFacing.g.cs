
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1ProjectAdvisorsResponseOutputLintFacing
    {
        /// <summary>
        ///
        /// </summary>
        External,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ProjectAdvisorsResponseOutputLintFacingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectAdvisorsResponseOutputLintFacing value)
        {
            return value switch
            {
                V1ProjectAdvisorsResponseOutputLintFacing.External => "EXTERNAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectAdvisorsResponseOutputLintFacing? ToEnum(string value)
        {
            return value switch
            {
                "EXTERNAL" => V1ProjectAdvisorsResponseOutputLintFacing.External,
                _ => null,
            };
        }
    }
}