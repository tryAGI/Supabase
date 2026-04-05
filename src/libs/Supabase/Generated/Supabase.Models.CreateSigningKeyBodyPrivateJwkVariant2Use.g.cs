
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant2Use
    {
        /// <summary>
        /// 
        /// </summary>
        Sig,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyPrivateJwkVariant2UseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant2Use value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant2Use.Sig => "sig",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant2Use? ToEnum(string value)
        {
            return value switch
            {
                "sig" => CreateSigningKeyBodyPrivateJwkVariant2Use.Sig,
                _ => null,
            };
        }
    }
}