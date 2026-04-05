
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum SigningKeysResponseKeyAlgorithm
    {
        /// <summary>
        /// 
        /// </summary>
        Es256,
        /// <summary>
        /// 
        /// </summary>
        EdDSA,
        /// <summary>
        /// 
        /// </summary>
        Hs256,
        /// <summary>
        /// 
        /// </summary>
        Rs256,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SigningKeysResponseKeyAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SigningKeysResponseKeyAlgorithm value)
        {
            return value switch
            {
                SigningKeysResponseKeyAlgorithm.Es256 => "ES256",
                SigningKeysResponseKeyAlgorithm.EdDSA => "EdDSA",
                SigningKeysResponseKeyAlgorithm.Hs256 => "HS256",
                SigningKeysResponseKeyAlgorithm.Rs256 => "RS256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SigningKeysResponseKeyAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => SigningKeysResponseKeyAlgorithm.Es256,
                "EdDSA" => SigningKeysResponseKeyAlgorithm.EdDSA,
                "HS256" => SigningKeysResponseKeyAlgorithm.Hs256,
                "RS256" => SigningKeysResponseKeyAlgorithm.Rs256,
                _ => null,
            };
        }
    }
}