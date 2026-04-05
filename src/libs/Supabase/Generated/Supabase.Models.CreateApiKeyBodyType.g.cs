
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateApiKeyBodyType
    {
        /// <summary>
        /// 
        /// </summary>
        Publishable,
        /// <summary>
        /// 
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateApiKeyBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeyBodyType value)
        {
            return value switch
            {
                CreateApiKeyBodyType.Publishable => "publishable",
                CreateApiKeyBodyType.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeyBodyType? ToEnum(string value)
        {
            return value switch
            {
                "publishable" => CreateApiKeyBodyType.Publishable,
                "secret" => CreateApiKeyBodyType.Secret,
                _ => null,
            };
        }
    }
}