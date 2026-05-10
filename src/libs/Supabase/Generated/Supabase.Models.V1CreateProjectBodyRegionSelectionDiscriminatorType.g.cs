
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1CreateProjectBodyRegionSelectionDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        SmartGroup,
        /// <summary>
        /// 
        /// </summary>
        Specific,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1CreateProjectBodyRegionSelectionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1CreateProjectBodyRegionSelectionDiscriminatorType value)
        {
            return value switch
            {
                V1CreateProjectBodyRegionSelectionDiscriminatorType.SmartGroup => "smartGroup",
                V1CreateProjectBodyRegionSelectionDiscriminatorType.Specific => "specific",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1CreateProjectBodyRegionSelectionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "smartGroup" => V1CreateProjectBodyRegionSelectionDiscriminatorType.SmartGroup,
                "specific" => V1CreateProjectBodyRegionSelectionDiscriminatorType.Specific,
                _ => null,
            };
        }
    }
}