
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum NetworkRestrictionsV2ResponseEntitlement
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
    public static class NetworkRestrictionsV2ResponseEntitlementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkRestrictionsV2ResponseEntitlement value)
        {
            return value switch
            {
                NetworkRestrictionsV2ResponseEntitlement.Allowed => "allowed",
                NetworkRestrictionsV2ResponseEntitlement.Disallowed => "disallowed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkRestrictionsV2ResponseEntitlement? ToEnum(string value)
        {
            return value switch
            {
                "allowed" => NetworkRestrictionsV2ResponseEntitlement.Allowed,
                "disallowed" => NetworkRestrictionsV2ResponseEntitlement.Disallowed,
                _ => null,
            };
        }
    }
}