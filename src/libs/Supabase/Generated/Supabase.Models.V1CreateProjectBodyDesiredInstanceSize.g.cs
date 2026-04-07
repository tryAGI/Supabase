
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Desired instance size. Omit this field to always default to the smallest possible size.
    /// </summary>
    public enum V1CreateProjectBodyDesiredInstanceSize
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
        Small,
        /// <summary>
        /// 
        /// </summary>
        Xlarge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1CreateProjectBodyDesiredInstanceSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1CreateProjectBodyDesiredInstanceSize value)
        {
            return value switch
            {
                V1CreateProjectBodyDesiredInstanceSize.x12xlarge => "12xlarge",
                V1CreateProjectBodyDesiredInstanceSize.x16xlarge => "16xlarge",
                V1CreateProjectBodyDesiredInstanceSize.x24xlarge => "24xlarge",
                V1CreateProjectBodyDesiredInstanceSize.x24xlargeHighMemory => "24xlarge_high_memory",
                V1CreateProjectBodyDesiredInstanceSize.x24xlargeOptimizedCpu => "24xlarge_optimized_cpu",
                V1CreateProjectBodyDesiredInstanceSize.x24xlargeOptimizedMemory => "24xlarge_optimized_memory",
                V1CreateProjectBodyDesiredInstanceSize.x2xlarge => "2xlarge",
                V1CreateProjectBodyDesiredInstanceSize.x48xlarge => "48xlarge",
                V1CreateProjectBodyDesiredInstanceSize.x48xlargeHighMemory => "48xlarge_high_memory",
                V1CreateProjectBodyDesiredInstanceSize.x48xlargeOptimizedCpu => "48xlarge_optimized_cpu",
                V1CreateProjectBodyDesiredInstanceSize.x48xlargeOptimizedMemory => "48xlarge_optimized_memory",
                V1CreateProjectBodyDesiredInstanceSize.x4xlarge => "4xlarge",
                V1CreateProjectBodyDesiredInstanceSize.x8xlarge => "8xlarge",
                V1CreateProjectBodyDesiredInstanceSize.Large => "large",
                V1CreateProjectBodyDesiredInstanceSize.Medium => "medium",
                V1CreateProjectBodyDesiredInstanceSize.Micro => "micro",
                V1CreateProjectBodyDesiredInstanceSize.Nano => "nano",
                V1CreateProjectBodyDesiredInstanceSize.Small => "small",
                V1CreateProjectBodyDesiredInstanceSize.Xlarge => "xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1CreateProjectBodyDesiredInstanceSize? ToEnum(string value)
        {
            return value switch
            {
                "12xlarge" => V1CreateProjectBodyDesiredInstanceSize.x12xlarge,
                "16xlarge" => V1CreateProjectBodyDesiredInstanceSize.x16xlarge,
                "24xlarge" => V1CreateProjectBodyDesiredInstanceSize.x24xlarge,
                "24xlarge_high_memory" => V1CreateProjectBodyDesiredInstanceSize.x24xlargeHighMemory,
                "24xlarge_optimized_cpu" => V1CreateProjectBodyDesiredInstanceSize.x24xlargeOptimizedCpu,
                "24xlarge_optimized_memory" => V1CreateProjectBodyDesiredInstanceSize.x24xlargeOptimizedMemory,
                "2xlarge" => V1CreateProjectBodyDesiredInstanceSize.x2xlarge,
                "48xlarge" => V1CreateProjectBodyDesiredInstanceSize.x48xlarge,
                "48xlarge_high_memory" => V1CreateProjectBodyDesiredInstanceSize.x48xlargeHighMemory,
                "48xlarge_optimized_cpu" => V1CreateProjectBodyDesiredInstanceSize.x48xlargeOptimizedCpu,
                "48xlarge_optimized_memory" => V1CreateProjectBodyDesiredInstanceSize.x48xlargeOptimizedMemory,
                "4xlarge" => V1CreateProjectBodyDesiredInstanceSize.x4xlarge,
                "8xlarge" => V1CreateProjectBodyDesiredInstanceSize.x8xlarge,
                "large" => V1CreateProjectBodyDesiredInstanceSize.Large,
                "medium" => V1CreateProjectBodyDesiredInstanceSize.Medium,
                "micro" => V1CreateProjectBodyDesiredInstanceSize.Micro,
                "nano" => V1CreateProjectBodyDesiredInstanceSize.Nano,
                "small" => V1CreateProjectBodyDesiredInstanceSize.Small,
                "xlarge" => V1CreateProjectBodyDesiredInstanceSize.Xlarge,
                _ => null,
            };
        }
    }
}