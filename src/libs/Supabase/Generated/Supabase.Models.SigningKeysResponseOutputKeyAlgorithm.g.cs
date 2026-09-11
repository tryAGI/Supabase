
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum SigningKeysResponseOutputKeyAlgorithm
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
    public static class SigningKeysResponseOutputKeyAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SigningKeysResponseOutputKeyAlgorithm value)
        {
            return value switch
            {
                SigningKeysResponseOutputKeyAlgorithm.Es256 => "ES256",
                SigningKeysResponseOutputKeyAlgorithm.EdDSA => "EdDSA",
                SigningKeysResponseOutputKeyAlgorithm.Hs256 => "HS256",
                SigningKeysResponseOutputKeyAlgorithm.Rs256 => "RS256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SigningKeysResponseOutputKeyAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => SigningKeysResponseOutputKeyAlgorithm.Es256,
                "EdDSA" => SigningKeysResponseOutputKeyAlgorithm.EdDSA,
                "HS256" => SigningKeysResponseOutputKeyAlgorithm.Hs256,
                "RS256" => SigningKeysResponseOutputKeyAlgorithm.Rs256,
                _ => null,
            };
        }
    }
}