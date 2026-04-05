
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1CreateProjectBodyRegionSelectionVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Specific,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1CreateProjectBodyRegionSelectionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1CreateProjectBodyRegionSelectionVariant1Type value)
        {
            return value switch
            {
                V1CreateProjectBodyRegionSelectionVariant1Type.Specific => "specific",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1CreateProjectBodyRegionSelectionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "specific" => V1CreateProjectBodyRegionSelectionVariant1Type.Specific,
                _ => null,
            };
        }
    }
}