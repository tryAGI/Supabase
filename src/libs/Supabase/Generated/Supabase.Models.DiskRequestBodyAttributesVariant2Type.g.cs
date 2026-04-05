
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum DiskRequestBodyAttributesVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Io2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiskRequestBodyAttributesVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiskRequestBodyAttributesVariant2Type value)
        {
            return value switch
            {
                DiskRequestBodyAttributesVariant2Type.Io2 => "io2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiskRequestBodyAttributesVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "io2" => DiskRequestBodyAttributesVariant2Type.Io2,
                _ => null,
            };
        }
    }
}