
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum NetworkRestrictionsResponseEntitlement
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
    public static class NetworkRestrictionsResponseEntitlementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkRestrictionsResponseEntitlement value)
        {
            return value switch
            {
                NetworkRestrictionsResponseEntitlement.Allowed => "allowed",
                NetworkRestrictionsResponseEntitlement.Disallowed => "disallowed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkRestrictionsResponseEntitlement? ToEnum(string value)
        {
            return value switch
            {
                "allowed" => NetworkRestrictionsResponseEntitlement.Allowed,
                "disallowed" => NetworkRestrictionsResponseEntitlement.Disallowed,
                _ => null,
            };
        }
    }
}