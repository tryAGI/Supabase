
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum SigningKeysResponseKeyStatus
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
    public static class SigningKeysResponseKeyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SigningKeysResponseKeyStatus value)
        {
            return value switch
            {
                SigningKeysResponseKeyStatus.InUse => "in_use",
                SigningKeysResponseKeyStatus.PreviouslyUsed => "previously_used",
                SigningKeysResponseKeyStatus.Revoked => "revoked",
                SigningKeysResponseKeyStatus.Standby => "standby",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SigningKeysResponseKeyStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_use" => SigningKeysResponseKeyStatus.InUse,
                "previously_used" => SigningKeysResponseKeyStatus.PreviouslyUsed,
                "revoked" => SigningKeysResponseKeyStatus.Revoked,
                "standby" => SigningKeysResponseKeyStatus.Standby,
                _ => null,
            };
        }
    }
}