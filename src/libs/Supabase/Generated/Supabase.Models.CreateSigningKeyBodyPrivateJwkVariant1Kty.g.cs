
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant1Kty
    {
        /// <summary>
        /// 
        /// </summary>
        Rsa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyPrivateJwkVariant1KtyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant1Kty value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant1Kty.Rsa => "RSA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant1Kty? ToEnum(string value)
        {
            return value switch
            {
                "RSA" => CreateSigningKeyBodyPrivateJwkVariant1Kty.Rsa,
                _ => null,
            };
        }
    }
}