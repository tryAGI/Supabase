
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum BranchResponseStatus
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
    public static class BranchResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchResponseStatus value)
        {
            return value switch
            {
                BranchResponseStatus.CreatingProject => "CREATING_PROJECT",
                BranchResponseStatus.FunctionsDeployed => "FUNCTIONS_DEPLOYED",
                BranchResponseStatus.FunctionsFailed => "FUNCTIONS_FAILED",
                BranchResponseStatus.MigrationsFailed => "MIGRATIONS_FAILED",
                BranchResponseStatus.MigrationsPassed => "MIGRATIONS_PASSED",
                BranchResponseStatus.RunningMigrations => "RUNNING_MIGRATIONS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CREATING_PROJECT" => BranchResponseStatus.CreatingProject,
                "FUNCTIONS_DEPLOYED" => BranchResponseStatus.FunctionsDeployed,
                "FUNCTIONS_FAILED" => BranchResponseStatus.FunctionsFailed,
                "MIGRATIONS_FAILED" => BranchResponseStatus.MigrationsFailed,
                "MIGRATIONS_PASSED" => BranchResponseStatus.MigrationsPassed,
                "RUNNING_MIGRATIONS" => BranchResponseStatus.RunningMigrations,
                _ => null,
            };
        }
    }
}