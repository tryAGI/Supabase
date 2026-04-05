
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateBranchBodyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        CreatingProject,
        /// <summary>
        /// 
        /// </summary>
        FunctionsDeployed,
        /// <summary>
        /// 
        /// </summary>
        FunctionsFailed,
        /// <summary>
        /// 
        /// </summary>
        MigrationsFailed,
        /// <summary>
        /// 
        /// </summary>
        MigrationsPassed,
        /// <summary>
        /// 
        /// </summary>
        RunningMigrations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateBranchBodyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateBranchBodyStatus value)
        {
            return value switch
            {
                UpdateBranchBodyStatus.CreatingProject => "CREATING_PROJECT",
                UpdateBranchBodyStatus.FunctionsDeployed => "FUNCTIONS_DEPLOYED",
                UpdateBranchBodyStatus.FunctionsFailed => "FUNCTIONS_FAILED",
                UpdateBranchBodyStatus.MigrationsFailed => "MIGRATIONS_FAILED",
                UpdateBranchBodyStatus.MigrationsPassed => "MIGRATIONS_PASSED",
                UpdateBranchBodyStatus.RunningMigrations => "RUNNING_MIGRATIONS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateBranchBodyStatus? ToEnum(string value)
        {
            return value switch
            {
                "CREATING_PROJECT" => UpdateBranchBodyStatus.CreatingProject,
                "FUNCTIONS_DEPLOYED" => UpdateBranchBodyStatus.FunctionsDeployed,
                "FUNCTIONS_FAILED" => UpdateBranchBodyStatus.FunctionsFailed,
                "MIGRATIONS_FAILED" => UpdateBranchBodyStatus.MigrationsFailed,
                "MIGRATIONS_PASSED" => UpdateBranchBodyStatus.MigrationsPassed,
                "RUNNING_MIGRATIONS" => UpdateBranchBodyStatus.RunningMigrations,
                _ => null,
            };
        }
    }
}