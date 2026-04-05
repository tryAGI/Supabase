
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUpgradeEligibilityResponseValidationErrorVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        UserDefinedObjectsInInternalSchemas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUpgradeEligibilityResponseValidationErrorVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUpgradeEligibilityResponseValidationErrorVariant7Type value)
        {
            return value switch
            {
                ProjectUpgradeEligibilityResponseValidationErrorVariant7Type.UserDefinedObjectsInInternalSchemas => "user_defined_objects_in_internal_schemas",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUpgradeEligibilityResponseValidationErrorVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "user_defined_objects_in_internal_schemas" => ProjectUpgradeEligibilityResponseValidationErrorVariant7Type.UserDefinedObjectsInInternalSchemas,
                _ => null,
            };
        }
    }
}