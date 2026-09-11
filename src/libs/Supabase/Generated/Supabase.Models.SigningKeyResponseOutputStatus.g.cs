
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum SigningKeyResponseOutputStatus
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
    public static class SigningKeyResponseOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SigningKeyResponseOutputStatus value)
        {
            return value switch
            {
                SigningKeyResponseOutputStatus.InUse => "in_use",
                SigningKeyResponseOutputStatus.PreviouslyUsed => "previously_used",
                SigningKeyResponseOutputStatus.Revoked => "revoked",
                SigningKeyResponseOutputStatus.Standby => "standby",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SigningKeyResponseOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_use" => SigningKeyResponseOutputStatus.InUse,
                "previously_used" => SigningKeyResponseOutputStatus.PreviouslyUsed,
                "revoked" => SigningKeyResponseOutputStatus.Revoked,
                "standby" => SigningKeyResponseOutputStatus.Standby,
                _ => null,
            };
        }
    }
}