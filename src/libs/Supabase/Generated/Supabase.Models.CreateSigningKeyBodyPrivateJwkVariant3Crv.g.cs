
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant3Crv
    {
        /// <summary>
        /// 
        /// </summary>
        Ed25519,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyPrivateJwkVariant3CrvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant3Crv value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant3Crv.Ed25519 => "Ed25519",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant3Crv? ToEnum(string value)
        {
            return value switch
            {
                "Ed25519" => CreateSigningKeyBodyPrivateJwkVariant3Crv.Ed25519,
                _ => null,
            };
        }
    }
}