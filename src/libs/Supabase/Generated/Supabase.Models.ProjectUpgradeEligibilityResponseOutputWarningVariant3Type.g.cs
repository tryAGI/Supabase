
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputWarningVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        OperatorEstimatorGate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseOutputWarningVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputWarningVariant3Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputWarningVariant3Type.OperatorEstimatorGate => "operator_estimator_gate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputWarningVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "operator_estimator_gate" => ProjectUpgradeEligibilityResponseOutputWarningVariant3Type.OperatorEstimatorGate,
                _ => null,
            };
        }
    }
}