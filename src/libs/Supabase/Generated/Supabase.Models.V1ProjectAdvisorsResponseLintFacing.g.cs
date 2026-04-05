
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ProjectAdvisorsResponseLintFacing
    {
        /// <summary>
        /// 
        /// </summary>
        External,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ProjectAdvisorsResponseLintFacingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectAdvisorsResponseLintFacing value)
        {
            return value switch
            {
                V1ProjectAdvisorsResponseLintFacing.External => "EXTERNAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectAdvisorsResponseLintFacing? ToEnum(string value)
        {
            return value switch
            {
                "EXTERNAL" => V1ProjectAdvisorsResponseLintFacing.External,
                _ => null,
            };
        }
    }
}