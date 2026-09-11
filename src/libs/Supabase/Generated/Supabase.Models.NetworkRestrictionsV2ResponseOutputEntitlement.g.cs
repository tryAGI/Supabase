
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum NetworkRestrictionsV2ResponseOutputEntitlement
    {
        /// <summary>
        ///
        /// </summary>
        Allowed,
        /// <summary>
        ///
        /// </summary>
        Disallowed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NetworkRestrictionsV2ResponseOutputEntitlementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkRestrictionsV2ResponseOutputEntitlement value)
        {
            return value switch
            {
                NetworkRestrictionsV2ResponseOutputEntitlement.Allowed => "allowed",
                NetworkRestrictionsV2ResponseOutputEntitlement.Disallowed => "disallowed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkRestrictionsV2ResponseOutputEntitlement? ToEnum(string value)
        {
            return value switch
            {
                "allowed" => NetworkRestrictionsV2ResponseOutputEntitlement.Allowed,
                "disallowed" => NetworkRestrictionsV2ResponseOutputEntitlement.Disallowed,
                _ => null,
            };
        }
    }
}