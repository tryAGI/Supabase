
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSigningKeyBodyPrivateJwkVariant4Use
    {
        /// <summary>
        /// 
        /// </summary>
        Sig,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSigningKeyBodyPrivateJwkVariant4UseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSigningKeyBodyPrivateJwkVariant4Use value)
        {
            return value switch
            {
                CreateSigningKeyBodyPrivateJwkVariant4Use.Sig => "sig",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSigningKeyBodyPrivateJwkVariant4Use? ToEnum(string value)
        {
            return value switch
            {
                "sig" => CreateSigningKeyBodyPrivateJwkVariant4Use.Sig,
                _ => null,
            };
        }
    }
}