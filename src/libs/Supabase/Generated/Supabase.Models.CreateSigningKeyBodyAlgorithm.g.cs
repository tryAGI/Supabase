
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyAlgorithm
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
    public static class CreateSigningKeyBodyAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyAlgorithm value)
        {
            return value switch
            {
                CreateSigningKeyBodyAlgorithm.Es256 => "ES256",
                CreateSigningKeyBodyAlgorithm.EdDSA => "EdDSA",
                CreateSigningKeyBodyAlgorithm.Hs256 => "HS256",
                CreateSigningKeyBodyAlgorithm.Rs256 => "RS256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => CreateSigningKeyBodyAlgorithm.Es256,
                "EdDSA" => CreateSigningKeyBodyAlgorithm.EdDSA,
                "HS256" => CreateSigningKeyBodyAlgorithm.Hs256,
                "RS256" => CreateSigningKeyBodyAlgorithm.Rs256,
                _ => null,
            };
        }
    }
}