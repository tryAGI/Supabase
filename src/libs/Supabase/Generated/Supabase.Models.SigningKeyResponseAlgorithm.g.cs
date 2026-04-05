
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum SigningKeyResponseAlgorithm
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
    public static class SigningKeyResponseAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SigningKeyResponseAlgorithm value)
        {
            return value switch
            {
                SigningKeyResponseAlgorithm.Es256 => "ES256",
                SigningKeyResponseAlgorithm.EdDSA => "EdDSA",
                SigningKeyResponseAlgorithm.Hs256 => "HS256",
                SigningKeyResponseAlgorithm.Rs256 => "RS256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SigningKeyResponseAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => SigningKeyResponseAlgorithm.Es256,
                "EdDSA" => SigningKeyResponseAlgorithm.EdDSA,
                "HS256" => SigningKeyResponseAlgorithm.Hs256,
                "RS256" => SigningKeyResponseAlgorithm.Rs256,
                _ => null,
            };
        }
    }
}