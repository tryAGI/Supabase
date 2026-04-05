
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant3Alg
    {
        /// <summary>
        /// 
        /// </summary>
        EdDSA,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyPrivateJwkVariant3AlgExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant3Alg value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant3Alg.EdDSA => "EdDSA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant3Alg? ToEnum(string value)
        {
            return value switch
            {
                "EdDSA" => CreateSigningKeyBodyPrivateJwkVariant3Alg.EdDSA,
                _ => null,
            };
        }
    }
}