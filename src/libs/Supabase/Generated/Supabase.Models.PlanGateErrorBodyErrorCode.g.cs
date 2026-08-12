
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Machine-readable marker for plan-gated denials
    /// </summary>
    public enum PlanGateErrorBodyErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        EntitlementRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlanGateErrorBodyErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlanGateErrorBodyErrorCode value)
        {
            return value switch
            {
                PlanGateErrorBodyErrorCode.EntitlementRequired => "entitlement_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlanGateErrorBodyErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "entitlement_required" => PlanGateErrorBodyErrorCode.EntitlementRequired,
                _ => null,
            };
        }
    }
}