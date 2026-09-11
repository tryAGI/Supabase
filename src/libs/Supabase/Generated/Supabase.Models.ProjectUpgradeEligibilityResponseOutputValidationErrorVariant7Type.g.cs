
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7Type
    {
        /// <summary>
        ///
        /// </summary>
        UserDefinedObjectsInInternalSchemas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7Type.UserDefinedObjectsInInternalSchemas => "user_defined_objects_in_internal_schemas",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "user_defined_objects_in_internal_schemas" => ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7Type.UserDefinedObjectsInInternalSchemas,
                _ => null,
            };
        }
    }
}