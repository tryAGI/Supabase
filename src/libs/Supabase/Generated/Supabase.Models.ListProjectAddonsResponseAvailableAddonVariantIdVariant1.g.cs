
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectAddonsResponseAvailableAddonVariantIdVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Ci12xlarge,
        /// <summary>
        /// 
        /// </summary>
        Ci16xlarge,
        /// <summary>
        /// 
        /// </summary>
        Ci24xlarge,
        /// <summary>
        /// 
        /// </summary>
        Ci24xlargeHighMemory,
        /// <summary>
        /// 
        /// </summary>
        Ci24xlargeOptimizedCpu,
        /// <summary>
        /// 
        /// </summary>
        Ci24xlargeOptimizedMemory,
        /// <summary>
        /// 
        /// </summary>
        Ci2xlarge,
        /// <summary>
        /// 
        /// </summary>
        Ci48xlarge,
        /// <summary>
        /// 
        /// </summary>
        Ci48xlargeHighMemory,
        /// <summary>
        /// 
        /// </summary>
        Ci48xlargeOptimizedCpu,
        /// <summary>
        /// 
        /// </summary>
        Ci48xlargeOptimizedMemory,
        /// <summary>
        /// 
        /// </summary>
        Ci4xlarge,
        /// <summary>
        /// 
        /// </summary>
        Ci8xlarge,
        /// <summary>
        /// 
        /// </summary>
        CiLarge,
        /// <summary>
        /// 
        /// </summary>
        CiMedium,
        /// <summary>
        /// 
        /// </summary>
        CiMicro,
        /// <summary>
        /// 
        /// </summary>
        CiSmall,
        /// <summary>
        /// 
        /// </summary>
        CiXlarge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseAvailableAddonVariantIdVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseAvailableAddonVariantIdVariant1 value)
        {
            return value switch
            {
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci12xlarge => "ci_12xlarge",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci16xlarge => "ci_16xlarge",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci24xlarge => "ci_24xlarge",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci24xlargeHighMemory => "ci_24xlarge_high_memory",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci24xlargeOptimizedCpu => "ci_24xlarge_optimized_cpu",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci24xlargeOptimizedMemory => "ci_24xlarge_optimized_memory",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci2xlarge => "ci_2xlarge",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci48xlarge => "ci_48xlarge",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci48xlargeHighMemory => "ci_48xlarge_high_memory",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci48xlargeOptimizedCpu => "ci_48xlarge_optimized_cpu",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci48xlargeOptimizedMemory => "ci_48xlarge_optimized_memory",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci4xlarge => "ci_4xlarge",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci8xlarge => "ci_8xlarge",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.CiLarge => "ci_large",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.CiMedium => "ci_medium",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.CiMicro => "ci_micro",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.CiSmall => "ci_small",
                ListProjectAddonsResponseAvailableAddonVariantIdVariant1.CiXlarge => "ci_xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseAvailableAddonVariantIdVariant1? ToEnum(string value)
        {
            return value switch
            {
                "ci_12xlarge" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci12xlarge,
                "ci_16xlarge" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci16xlarge,
                "ci_24xlarge" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci24xlarge,
                "ci_24xlarge_high_memory" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci24xlargeHighMemory,
                "ci_24xlarge_optimized_cpu" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci24xlargeOptimizedCpu,
                "ci_24xlarge_optimized_memory" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci24xlargeOptimizedMemory,
                "ci_2xlarge" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci2xlarge,
                "ci_48xlarge" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci48xlarge,
                "ci_48xlarge_high_memory" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci48xlargeHighMemory,
                "ci_48xlarge_optimized_cpu" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci48xlargeOptimizedCpu,
                "ci_48xlarge_optimized_memory" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci48xlargeOptimizedMemory,
                "ci_4xlarge" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci4xlarge,
                "ci_8xlarge" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.Ci8xlarge,
                "ci_large" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.CiLarge,
                "ci_medium" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.CiMedium,
                "ci_micro" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.CiMicro,
                "ci_small" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.CiSmall,
                "ci_xlarge" => ListProjectAddonsResponseAvailableAddonVariantIdVariant1.CiXlarge,
                _ => null,
            };
        }
    }
}