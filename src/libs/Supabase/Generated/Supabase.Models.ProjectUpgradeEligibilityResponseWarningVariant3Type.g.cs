
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseWarningVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        OperatorEstimatorGate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseWarningVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseWarningVariant3Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseWarningVariant3Type.OperatorEstimatorGate => "operator_estimator_gate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseWarningVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "operator_estimator_gate" => ProjectUpgradeEligibilityResponseWarningVariant3Type.OperatorEstimatorGate,
                _ => null,
            };
        }
    }
}