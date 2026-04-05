
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum SigningKeyResponseStatus
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
    public static class SigningKeyResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SigningKeyResponseStatus value)
        {
            return value switch
            {
                SigningKeyResponseStatus.InUse => "in_use",
                SigningKeyResponseStatus.PreviouslyUsed => "previously_used",
                SigningKeyResponseStatus.Revoked => "revoked",
                SigningKeyResponseStatus.Standby => "standby",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SigningKeyResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_use" => SigningKeyResponseStatus.InUse,
                "previously_used" => SigningKeyResponseStatus.PreviouslyUsed,
                "revoked" => SigningKeyResponseStatus.Revoked,
                "standby" => SigningKeyResponseStatus.Standby,
                _ => null,
            };
        }
    }
}