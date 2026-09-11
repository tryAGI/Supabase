
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum SigningKeyResponseOutputAlgorithm
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
    public static class SigningKeyResponseOutputAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SigningKeyResponseOutputAlgorithm value)
        {
            return value switch
            {
                SigningKeyResponseOutputAlgorithm.Es256 => "ES256",
                SigningKeyResponseOutputAlgorithm.EdDSA => "EdDSA",
                SigningKeyResponseOutputAlgorithm.Hs256 => "HS256",
                SigningKeyResponseOutputAlgorithm.Rs256 => "RS256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SigningKeyResponseOutputAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => SigningKeyResponseOutputAlgorithm.Es256,
                "EdDSA" => SigningKeyResponseOutputAlgorithm.EdDSA,
                "HS256" => SigningKeyResponseOutputAlgorithm.Hs256,
                "RS256" => SigningKeyResponseOutputAlgorithm.Rs256,
                _ => null,
            };
        }
    }
}