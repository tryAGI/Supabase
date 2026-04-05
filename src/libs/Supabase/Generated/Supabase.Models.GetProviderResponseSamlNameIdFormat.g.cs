
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProviderResponseSamlNameIdFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_oasis_names_tc_SAML_11_nameidFormat_emailAddress,
        /// <summary>
        /// 
        /// </summary>
        Urn_oasis_names_tc_SAML_11_nameidFormat_unspecified,
        /// <summary>
        /// 
        /// </summary>
        Urn_oasis_names_tc_SAML_20_nameidFormat_persistent,
        /// <summary>
        /// 
        /// </summary>
        Urn_oasis_names_tc_SAML_20_nameidFormat_transient,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProviderResponseSamlNameIdFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProviderResponseSamlNameIdFormat value)
        {
            return value switch
            {
                GetProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_11_nameidFormat_emailAddress => "urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress",
                GetProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_11_nameidFormat_unspecified => "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified",
                GetProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_20_nameidFormat_persistent => "urn:oasis:names:tc:SAML:2.0:nameid-format:persistent",
                GetProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_20_nameidFormat_transient => "urn:oasis:names:tc:SAML:2.0:nameid-format:transient",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProviderResponseSamlNameIdFormat? ToEnum(string value)
        {
            return value switch
            {
                "urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress" => GetProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_11_nameidFormat_emailAddress,
                "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified" => GetProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_11_nameidFormat_unspecified,
                "urn:oasis:names:tc:SAML:2.0:nameid-format:persistent" => GetProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_20_nameidFormat_persistent,
                "urn:oasis:names:tc:SAML:2.0:nameid-format:transient" => GetProviderResponseSamlNameIdFormat.Urn_oasis_names_tc_SAML_20_nameidFormat_transient,
                _ => null,
            };
        }
    }
}