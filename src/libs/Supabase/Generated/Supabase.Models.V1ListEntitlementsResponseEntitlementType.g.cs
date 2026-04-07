
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ListEntitlementsResponseEntitlementType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Numeric,
        /// <summary>
        /// 
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ListEntitlementsResponseEntitlementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListEntitlementsResponseEntitlementType value)
        {
            return value switch
            {
                V1ListEntitlementsResponseEntitlementType.Boolean => "boolean",
                V1ListEntitlementsResponseEntitlementType.Numeric => "numeric",
                V1ListEntitlementsResponseEntitlementType.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListEntitlementsResponseEntitlementType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => V1ListEntitlementsResponseEntitlementType.Boolean,
                "numeric" => V1ListEntitlementsResponseEntitlementType.Numeric,
                "set" => V1ListEntitlementsResponseEntitlementType.Set,
                _ => null,
            };
        }
    }
}