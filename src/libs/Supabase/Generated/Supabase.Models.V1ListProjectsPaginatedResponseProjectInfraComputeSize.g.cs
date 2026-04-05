
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ListProjectsPaginatedResponseProjectInfraComputeSize
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
    public static class V1ListProjectsPaginatedResponseProjectInfraComputeSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListProjectsPaginatedResponseProjectInfraComputeSize value)
        {
            return value switch
            {
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.x12xlarge => "12xlarge",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.x16xlarge => "16xlarge",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.x24xlarge => "24xlarge",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.x24xlargeHighMemory => "24xlarge_high_memory",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.x24xlargeOptimizedCpu => "24xlarge_optimized_cpu",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.x24xlargeOptimizedMemory => "24xlarge_optimized_memory",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.x2xlarge => "2xlarge",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.x48xlarge => "48xlarge",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.x48xlargeHighMemory => "48xlarge_high_memory",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.x48xlargeOptimizedCpu => "48xlarge_optimized_cpu",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.x48xlargeOptimizedMemory => "48xlarge_optimized_memory",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.x4xlarge => "4xlarge",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.x8xlarge => "8xlarge",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.Large => "large",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.Medium => "medium",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.Micro => "micro",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.Nano => "nano",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.Pico => "pico",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.Small => "small",
                V1ListProjectsPaginatedResponseProjectInfraComputeSize.Xlarge => "xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListProjectsPaginatedResponseProjectInfraComputeSize? ToEnum(string value)
        {
            return value switch
            {
                "12xlarge" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.x12xlarge,
                "16xlarge" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.x16xlarge,
                "24xlarge" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.x24xlarge,
                "24xlarge_high_memory" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.x24xlargeHighMemory,
                "24xlarge_optimized_cpu" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.x24xlargeOptimizedCpu,
                "24xlarge_optimized_memory" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.x24xlargeOptimizedMemory,
                "2xlarge" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.x2xlarge,
                "48xlarge" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.x48xlarge,
                "48xlarge_high_memory" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.x48xlargeHighMemory,
                "48xlarge_optimized_cpu" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.x48xlargeOptimizedCpu,
                "48xlarge_optimized_memory" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.x48xlargeOptimizedMemory,
                "4xlarge" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.x4xlarge,
                "8xlarge" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.x8xlarge,
                "large" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.Large,
                "medium" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.Medium,
                "micro" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.Micro,
                "nano" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.Nano,
                "pico" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.Pico,
                "small" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.Small,
                "xlarge" => V1ListProjectsPaginatedResponseProjectInfraComputeSize.Xlarge,
                _ => null,
            };
        }
    }
}