
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectAddonsResponseAvailableAddonVariantIdVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        AuthMfaWebAuthnDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseAvailableAddonVariantIdVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseAvailableAddonVariantIdVariant6 value)
        {
            return value switch
            {
                ListProjectAddonsResponseAvailableAddonVariantIdVariant6.AuthMfaWebAuthnDefault => "auth_mfa_web_authn_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseAvailableAddonVariantIdVariant6? ToEnum(string value)
        {
            return value switch
            {
                "auth_mfa_web_authn_default" => ListProjectAddonsResponseAvailableAddonVariantIdVariant6.AuthMfaWebAuthnDefault,
                _ => null,
            };
        }
    }
}