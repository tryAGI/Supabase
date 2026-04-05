
#nullable enable

namespace Supabase
{
    /// <summary>
    /// What type of provider will be created
    /// </summary>
    public enum CreateProviderBodyType
    {
        /// <summary>
        /// 
        /// </summary>
        Saml,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProviderBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProviderBodyType value)
        {
            return value switch
            {
                CreateProviderBodyType.Saml => "saml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProviderBodyType? ToEnum(string value)
        {
            return value switch
            {
                "saml" => CreateProviderBodyType.Saml,
                _ => null,
            };
        }
    }
}