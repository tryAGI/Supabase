
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum DiskRequestBodyAttributesDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Gp3,
        /// <summary>
        /// 
        /// </summary>
        Io2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiskRequestBodyAttributesDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiskRequestBodyAttributesDiscriminatorType value)
        {
            return value switch
            {
                DiskRequestBodyAttributesDiscriminatorType.Gp3 => "gp3",
                DiskRequestBodyAttributesDiscriminatorType.Io2 => "io2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiskRequestBodyAttributesDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gp3" => DiskRequestBodyAttributesDiscriminatorType.Gp3,
                "io2" => DiskRequestBodyAttributesDiscriminatorType.Io2,
                _ => null,
            };
        }
    }
}