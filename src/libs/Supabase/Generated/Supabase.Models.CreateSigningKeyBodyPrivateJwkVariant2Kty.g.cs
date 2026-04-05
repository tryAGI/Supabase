
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant2Kty
    {
        /// <summary>
        /// 
        /// </summary>
        Ec,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyPrivateJwkVariant2KtyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant2Kty value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant2Kty.Ec => "EC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant2Kty? ToEnum(string value)
        {
            return value switch
            {
                "EC" => CreateSigningKeyBodyPrivateJwkVariant2Kty.Ec,
                _ => null,
            };
        }
    }
}