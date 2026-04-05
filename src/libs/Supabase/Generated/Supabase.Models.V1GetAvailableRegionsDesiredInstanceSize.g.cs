
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: nano
    /// </summary>
    public enum V1GetAvailableRegionsDesiredInstanceSize
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
    public static class V1GetAvailableRegionsDesiredInstanceSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1GetAvailableRegionsDesiredInstanceSize value)
        {
            return value switch
            {
                V1GetAvailableRegionsDesiredInstanceSize.x12xlarge => "12xlarge",
                V1GetAvailableRegionsDesiredInstanceSize.x16xlarge => "16xlarge",
                V1GetAvailableRegionsDesiredInstanceSize.x24xlarge => "24xlarge",
                V1GetAvailableRegionsDesiredInstanceSize.x24xlargeHighMemory => "24xlarge_high_memory",
                V1GetAvailableRegionsDesiredInstanceSize.x24xlargeOptimizedCpu => "24xlarge_optimized_cpu",
                V1GetAvailableRegionsDesiredInstanceSize.x24xlargeOptimizedMemory => "24xlarge_optimized_memory",
                V1GetAvailableRegionsDesiredInstanceSize.x2xlarge => "2xlarge",
                V1GetAvailableRegionsDesiredInstanceSize.x48xlarge => "48xlarge",
                V1GetAvailableRegionsDesiredInstanceSize.x48xlargeHighMemory => "48xlarge_high_memory",
                V1GetAvailableRegionsDesiredInstanceSize.x48xlargeOptimizedCpu => "48xlarge_optimized_cpu",
                V1GetAvailableRegionsDesiredInstanceSize.x48xlargeOptimizedMemory => "48xlarge_optimized_memory",
                V1GetAvailableRegionsDesiredInstanceSize.x4xlarge => "4xlarge",
                V1GetAvailableRegionsDesiredInstanceSize.x8xlarge => "8xlarge",
                V1GetAvailableRegionsDesiredInstanceSize.Large => "large",
                V1GetAvailableRegionsDesiredInstanceSize.Medium => "medium",
                V1GetAvailableRegionsDesiredInstanceSize.Micro => "micro",
                V1GetAvailableRegionsDesiredInstanceSize.Nano => "nano",
                V1GetAvailableRegionsDesiredInstanceSize.Small => "small",
                V1GetAvailableRegionsDesiredInstanceSize.Xlarge => "xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1GetAvailableRegionsDesiredInstanceSize? ToEnum(string value)
        {
            return value switch
            {
                "12xlarge" => V1GetAvailableRegionsDesiredInstanceSize.x12xlarge,
                "16xlarge" => V1GetAvailableRegionsDesiredInstanceSize.x16xlarge,
                "24xlarge" => V1GetAvailableRegionsDesiredInstanceSize.x24xlarge,
                "24xlarge_high_memory" => V1GetAvailableRegionsDesiredInstanceSize.x24xlargeHighMemory,
                "24xlarge_optimized_cpu" => V1GetAvailableRegionsDesiredInstanceSize.x24xlargeOptimizedCpu,
                "24xlarge_optimized_memory" => V1GetAvailableRegionsDesiredInstanceSize.x24xlargeOptimizedMemory,
                "2xlarge" => V1GetAvailableRegionsDesiredInstanceSize.x2xlarge,
                "48xlarge" => V1GetAvailableRegionsDesiredInstanceSize.x48xlarge,
                "48xlarge_high_memory" => V1GetAvailableRegionsDesiredInstanceSize.x48xlargeHighMemory,
                "48xlarge_optimized_cpu" => V1GetAvailableRegionsDesiredInstanceSize.x48xlargeOptimizedCpu,
                "48xlarge_optimized_memory" => V1GetAvailableRegionsDesiredInstanceSize.x48xlargeOptimizedMemory,
                "4xlarge" => V1GetAvailableRegionsDesiredInstanceSize.x4xlarge,
                "8xlarge" => V1GetAvailableRegionsDesiredInstanceSize.x8xlarge,
                "large" => V1GetAvailableRegionsDesiredInstanceSize.Large,
                "medium" => V1GetAvailableRegionsDesiredInstanceSize.Medium,
                "micro" => V1GetAvailableRegionsDesiredInstanceSize.Micro,
                "nano" => V1GetAvailableRegionsDesiredInstanceSize.Nano,
                "small" => V1GetAvailableRegionsDesiredInstanceSize.Small,
                "xlarge" => V1GetAvailableRegionsDesiredInstanceSize.Xlarge,
                _ => null,
            };
        }
    }
}