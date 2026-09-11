
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum SigningKeysResponseOutputKeyStatus
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
    public static class SigningKeysResponseOutputKeyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SigningKeysResponseOutputKeyStatus value)
        {
            return value switch
            {
                SigningKeysResponseOutputKeyStatus.InUse => "in_use",
                SigningKeysResponseOutputKeyStatus.PreviouslyUsed => "previously_used",
                SigningKeysResponseOutputKeyStatus.Revoked => "revoked",
                SigningKeysResponseOutputKeyStatus.Standby => "standby",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SigningKeysResponseOutputKeyStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_use" => SigningKeysResponseOutputKeyStatus.InUse,
                "previously_used" => SigningKeysResponseOutputKeyStatus.PreviouslyUsed,
                "revoked" => SigningKeysResponseOutputKeyStatus.Revoked,
                "standby" => SigningKeysResponseOutputKeyStatus.Standby,
                _ => null,
            };
        }
    }
}