
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum DiskResponseAttributesVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Gp3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiskResponseAttributesVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiskResponseAttributesVariant1Type value)
        {
            return value switch
            {
                DiskResponseAttributesVariant1Type.Gp3 => "gp3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiskResponseAttributesVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "gp3" => DiskResponseAttributesVariant1Type.Gp3,
                _ => null,
            };
        }
    }
}