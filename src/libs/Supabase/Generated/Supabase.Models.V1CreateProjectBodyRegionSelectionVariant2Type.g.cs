
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1CreateProjectBodyRegionSelectionVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        SmartGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1CreateProjectBodyRegionSelectionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1CreateProjectBodyRegionSelectionVariant2Type value)
        {
            return value switch
            {
                V1CreateProjectBodyRegionSelectionVariant2Type.SmartGroup => "smartGroup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1CreateProjectBodyRegionSelectionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "smartGroup" => V1CreateProjectBodyRegionSelectionVariant2Type.SmartGroup,
                _ => null,
            };
        }
    }
}