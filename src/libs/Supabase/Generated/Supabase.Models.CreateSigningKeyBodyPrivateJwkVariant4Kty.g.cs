
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant4Kty
    {
        /// <summary>
        /// 
        /// </summary>
        Oct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyPrivateJwkVariant4KtyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant4Kty value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant4Kty.Oct => "oct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant4Kty? ToEnum(string value)
        {
            return value switch
            {
                "oct" => CreateSigningKeyBodyPrivateJwkVariant4Kty.Oct,
                _ => null,
            };
        }
    }
}