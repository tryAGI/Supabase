
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize
    {
        /// <summary>
        ///
        /// </summary>
        x12xlarge,
        /// <summary>
        ///
        /// </summary>
        x16xlarge,
        /// <summary>
        ///
        /// </summary>
        x24xlarge,
        /// <summary>
        ///
        /// </summary>
        x24xlargeHighMemory,
        /// <summary>
        ///
        /// </summary>
        x24xlargeOptimizedCpu,
        /// <summary>
        ///
        /// </summary>
        x24xlargeOptimizedMemory,
        /// <summary>
        ///
        /// </summary>
        x2xlarge,
        /// <summary>
        ///
        /// </summary>
        x48xlarge,
        /// <summary>
        ///
        /// </summary>
        x48xlargeHighMemory,
        /// <summary>
        ///
        /// </summary>
        x48xlargeOptimizedCpu,
        /// <summary>
        ///
        /// </summary>
        x48xlargeOptimizedMemory,
        /// <summary>
        ///
        /// </summary>
        x4xlarge,
        /// <summary>
        ///
        /// </summary>
        x8xlarge,
        /// <summary>
        ///
        /// </summary>
        Large,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Micro,
        /// <summary>
        ///
        /// </summary>
        Nano,
        /// <summary>
        ///
        /// </summary>
        Pico,
        /// <summary>
        ///
        /// </summary>
        Small,
        /// <summary>
        ///
        /// </summary>
        Xlarge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize value)
        {
            return value switch
            {
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x12xlarge => "12xlarge",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x16xlarge => "16xlarge",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x24xlarge => "24xlarge",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x24xlargeHighMemory => "24xlarge_high_memory",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x24xlargeOptimizedCpu => "24xlarge_optimized_cpu",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x24xlargeOptimizedMemory => "24xlarge_optimized_memory",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x2xlarge => "2xlarge",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x48xlarge => "48xlarge",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x48xlargeHighMemory => "48xlarge_high_memory",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x48xlargeOptimizedCpu => "48xlarge_optimized_cpu",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x48xlargeOptimizedMemory => "48xlarge_optimized_memory",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x4xlarge => "4xlarge",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x8xlarge => "8xlarge",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.Large => "large",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.Medium => "medium",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.Micro => "micro",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.Nano => "nano",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.Pico => "pico",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.Small => "small",
                OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.Xlarge => "xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize? ToEnum(string value)
        {
            return value switch
            {
                "12xlarge" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x12xlarge,
                "16xlarge" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x16xlarge,
                "24xlarge" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x24xlarge,
                "24xlarge_high_memory" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x24xlargeHighMemory,
                "24xlarge_optimized_cpu" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x24xlargeOptimizedCpu,
                "24xlarge_optimized_memory" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x24xlargeOptimizedMemory,
                "2xlarge" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x2xlarge,
                "48xlarge" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x48xlarge,
                "48xlarge_high_memory" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x48xlargeHighMemory,
                "48xlarge_optimized_cpu" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x48xlargeOptimizedCpu,
                "48xlarge_optimized_memory" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x48xlargeOptimizedMemory,
                "4xlarge" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x4xlarge,
                "8xlarge" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.x8xlarge,
                "large" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.Large,
                "medium" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.Medium,
                "micro" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.Micro,
                "nano" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.Nano,
                "pico" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.Pico,
                "small" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.Small,
                "xlarge" => OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize.Xlarge,
                _ => null,
            };
        }
    }
}