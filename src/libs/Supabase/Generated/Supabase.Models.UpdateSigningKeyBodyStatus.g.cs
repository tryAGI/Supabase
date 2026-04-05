
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateSigningKeyBodyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InUse,
        /// <summary>
        /// 
        /// </summary>
        PreviouslyUsed,
        /// <summary>
        /// 
        /// </summary>
        Revoked,
        /// <summary>
        /// 
        /// </summary>
        Standby,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSigningKeyBodyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSigningKeyBodyStatus value)
        {
            return value switch
            {
                UpdateSigningKeyBodyStatus.InUse => "in_use",
                UpdateSigningKeyBodyStatus.PreviouslyUsed => "previously_used",
                UpdateSigningKeyBodyStatus.Revoked => "revoked",
                UpdateSigningKeyBodyStatus.Standby => "standby",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSigningKeyBodyStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_use" => UpdateSigningKeyBodyStatus.InUse,
                "previously_used" => UpdateSigningKeyBodyStatus.PreviouslyUsed,
                "revoked" => UpdateSigningKeyBodyStatus.Revoked,
                "standby" => UpdateSigningKeyBodyStatus.Standby,
                _ => null,
            };
        }
    }
}