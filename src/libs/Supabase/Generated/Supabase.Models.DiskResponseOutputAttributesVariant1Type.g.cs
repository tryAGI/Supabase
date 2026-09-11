
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum DiskResponseOutputAttributesVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Gp3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiskResponseOutputAttributesVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiskResponseOutputAttributesVariant1Type value)
        {
            return value switch
            {
                DiskResponseOutputAttributesVariant1Type.Gp3 => "gp3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiskResponseOutputAttributesVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "gp3" => DiskResponseOutputAttributesVariant1Type.Gp3,
                _ => null,
            };
        }
    }
}