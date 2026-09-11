
#nullable enable

namespace Supabase
{
    /// <summary>
    /// This field is deprecated. List action runs to get branch status instead.
    /// </summary>
    public enum BranchResponseOutputStatus
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
    public static class BranchResponseOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BranchResponseOutputStatus value)
        {
            return value switch
            {
                BranchResponseOutputStatus.CreatingProject => "CREATING_PROJECT",
                BranchResponseOutputStatus.FunctionsDeployed => "FUNCTIONS_DEPLOYED",
                BranchResponseOutputStatus.FunctionsFailed => "FUNCTIONS_FAILED",
                BranchResponseOutputStatus.MigrationsFailed => "MIGRATIONS_FAILED",
                BranchResponseOutputStatus.MigrationsPassed => "MIGRATIONS_PASSED",
                BranchResponseOutputStatus.RunningMigrations => "RUNNING_MIGRATIONS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BranchResponseOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "CREATING_PROJECT" => BranchResponseOutputStatus.CreatingProject,
                "FUNCTIONS_DEPLOYED" => BranchResponseOutputStatus.FunctionsDeployed,
                "FUNCTIONS_FAILED" => BranchResponseOutputStatus.FunctionsFailed,
                "MIGRATIONS_FAILED" => BranchResponseOutputStatus.MigrationsFailed,
                "MIGRATIONS_PASSED" => BranchResponseOutputStatus.MigrationsPassed,
                "RUNNING_MIGRATIONS" => BranchResponseOutputStatus.RunningMigrations,
                _ => null,
            };
        }
    }
}