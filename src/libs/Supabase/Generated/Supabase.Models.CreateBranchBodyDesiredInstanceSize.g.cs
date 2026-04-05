
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBranchBodyDesiredInstanceSize
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
    public static class CreateBranchBodyDesiredInstanceSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBranchBodyDesiredInstanceSize value)
        {
            return value switch
            {
                CreateBranchBodyDesiredInstanceSize.x12xlarge => "12xlarge",
                CreateBranchBodyDesiredInstanceSize.x16xlarge => "16xlarge",
                CreateBranchBodyDesiredInstanceSize.x24xlarge => "24xlarge",
                CreateBranchBodyDesiredInstanceSize.x24xlargeHighMemory => "24xlarge_high_memory",
                CreateBranchBodyDesiredInstanceSize.x24xlargeOptimizedCpu => "24xlarge_optimized_cpu",
                CreateBranchBodyDesiredInstanceSize.x24xlargeOptimizedMemory => "24xlarge_optimized_memory",
                CreateBranchBodyDesiredInstanceSize.x2xlarge => "2xlarge",
                CreateBranchBodyDesiredInstanceSize.x48xlarge => "48xlarge",
                CreateBranchBodyDesiredInstanceSize.x48xlargeHighMemory => "48xlarge_high_memory",
                CreateBranchBodyDesiredInstanceSize.x48xlargeOptimizedCpu => "48xlarge_optimized_cpu",
                CreateBranchBodyDesiredInstanceSize.x48xlargeOptimizedMemory => "48xlarge_optimized_memory",
                CreateBranchBodyDesiredInstanceSize.x4xlarge => "4xlarge",
                CreateBranchBodyDesiredInstanceSize.x8xlarge => "8xlarge",
                CreateBranchBodyDesiredInstanceSize.Large => "large",
                CreateBranchBodyDesiredInstanceSize.Medium => "medium",
                CreateBranchBodyDesiredInstanceSize.Micro => "micro",
                CreateBranchBodyDesiredInstanceSize.Nano => "nano",
                CreateBranchBodyDesiredInstanceSize.Pico => "pico",
                CreateBranchBodyDesiredInstanceSize.Small => "small",
                CreateBranchBodyDesiredInstanceSize.Xlarge => "xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBranchBodyDesiredInstanceSize? ToEnum(string value)
        {
            return value switch
            {
                "12xlarge" => CreateBranchBodyDesiredInstanceSize.x12xlarge,
                "16xlarge" => CreateBranchBodyDesiredInstanceSize.x16xlarge,
                "24xlarge" => CreateBranchBodyDesiredInstanceSize.x24xlarge,
                "24xlarge_high_memory" => CreateBranchBodyDesiredInstanceSize.x24xlargeHighMemory,
                "24xlarge_optimized_cpu" => CreateBranchBodyDesiredInstanceSize.x24xlargeOptimizedCpu,
                "24xlarge_optimized_memory" => CreateBranchBodyDesiredInstanceSize.x24xlargeOptimizedMemory,
                "2xlarge" => CreateBranchBodyDesiredInstanceSize.x2xlarge,
                "48xlarge" => CreateBranchBodyDesiredInstanceSize.x48xlarge,
                "48xlarge_high_memory" => CreateBranchBodyDesiredInstanceSize.x48xlargeHighMemory,
                "48xlarge_optimized_cpu" => CreateBranchBodyDesiredInstanceSize.x48xlargeOptimizedCpu,
                "48xlarge_optimized_memory" => CreateBranchBodyDesiredInstanceSize.x48xlargeOptimizedMemory,
                "4xlarge" => CreateBranchBodyDesiredInstanceSize.x4xlarge,
                "8xlarge" => CreateBranchBodyDesiredInstanceSize.x8xlarge,
                "large" => CreateBranchBodyDesiredInstanceSize.Large,
                "medium" => CreateBranchBodyDesiredInstanceSize.Medium,
                "micro" => CreateBranchBodyDesiredInstanceSize.Micro,
                "nano" => CreateBranchBodyDesiredInstanceSize.Nano,
                "pico" => CreateBranchBodyDesiredInstanceSize.Pico,
                "small" => CreateBranchBodyDesiredInstanceSize.Small,
                "xlarge" => CreateBranchBodyDesiredInstanceSize.Xlarge,
                _ => null,
            };
        }
    }
}