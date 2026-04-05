
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrganizationProjectsResponseProjectDatabaseInfraComputeSize
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
    public static class OrganizationProjectsResponseProjectDatabaseInfraComputeSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectsResponseProjectDatabaseInfraComputeSize value)
        {
            return value switch
            {
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x12xlarge => "12xlarge",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x16xlarge => "16xlarge",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x24xlarge => "24xlarge",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x24xlargeHighMemory => "24xlarge_high_memory",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x24xlargeOptimizedCpu => "24xlarge_optimized_cpu",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x24xlargeOptimizedMemory => "24xlarge_optimized_memory",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x2xlarge => "2xlarge",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x48xlarge => "48xlarge",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x48xlargeHighMemory => "48xlarge_high_memory",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x48xlargeOptimizedCpu => "48xlarge_optimized_cpu",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x48xlargeOptimizedMemory => "48xlarge_optimized_memory",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x4xlarge => "4xlarge",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x8xlarge => "8xlarge",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.Large => "large",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.Medium => "medium",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.Micro => "micro",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.Nano => "nano",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.Pico => "pico",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.Small => "small",
                OrganizationProjectsResponseProjectDatabaseInfraComputeSize.Xlarge => "xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectsResponseProjectDatabaseInfraComputeSize? ToEnum(string value)
        {
            return value switch
            {
                "12xlarge" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x12xlarge,
                "16xlarge" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x16xlarge,
                "24xlarge" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x24xlarge,
                "24xlarge_high_memory" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x24xlargeHighMemory,
                "24xlarge_optimized_cpu" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x24xlargeOptimizedCpu,
                "24xlarge_optimized_memory" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x24xlargeOptimizedMemory,
                "2xlarge" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x2xlarge,
                "48xlarge" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x48xlarge,
                "48xlarge_high_memory" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x48xlargeHighMemory,
                "48xlarge_optimized_cpu" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x48xlargeOptimizedCpu,
                "48xlarge_optimized_memory" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x48xlargeOptimizedMemory,
                "4xlarge" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x4xlarge,
                "8xlarge" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.x8xlarge,
                "large" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.Large,
                "medium" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.Medium,
                "micro" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.Micro,
                "nano" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.Nano,
                "pico" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.Pico,
                "small" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.Small,
                "xlarge" => OrganizationProjectsResponseProjectDatabaseInfraComputeSize.Xlarge,
                _ => null,
            };
        }
    }
}