
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant1E
    {
        /// <summary>
        /// 
        /// </summary>
        Aqab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyPrivateJwkVariant1EExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant1E value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant1E.Aqab => "AQAB",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant1E? ToEnum(string value)
        {
            return value switch
            {
                "AQAB" => CreateSigningKeyBodyPrivateJwkVariant1E.Aqab,
                _ => null,
            };
        }
    }
}