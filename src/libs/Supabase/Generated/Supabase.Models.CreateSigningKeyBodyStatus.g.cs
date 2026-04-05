
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InUse,
        /// <summary>
        /// 
        /// </summary>
        Standby,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyStatus value)
        {
            return value switch
            {
                CreateSigningKeyBodyStatus.InUse => "in_use",
                CreateSigningKeyBodyStatus.Standby => "standby",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_use" => CreateSigningKeyBodyStatus.InUse,
                "standby" => CreateSigningKeyBodyStatus.Standby,
                _ => null,
            };
        }
    }
}