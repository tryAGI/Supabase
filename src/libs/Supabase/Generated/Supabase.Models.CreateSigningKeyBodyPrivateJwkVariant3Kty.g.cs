
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant3Kty
    {
        /// <summary>
        /// 
        /// </summary>
        Okp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyPrivateJwkVariant3KtyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant3Kty value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant3Kty.Okp => "OKP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant3Kty? ToEnum(string value)
        {
            return value switch
            {
                "OKP" => CreateSigningKeyBodyPrivateJwkVariant3Kty.Okp,
                _ => null,
            };
        }
    }
}