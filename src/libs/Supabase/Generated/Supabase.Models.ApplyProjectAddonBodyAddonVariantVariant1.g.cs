
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyProjectAddonBodyAddonVariantVariant1
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
    public static class ApplyProjectAddonBodyAddonVariantVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyProjectAddonBodyAddonVariantVariant1 value)
        {
            return value switch
            {
                ApplyProjectAddonBodyAddonVariantVariant1.Ci12xlarge => "ci_12xlarge",
                ApplyProjectAddonBodyAddonVariantVariant1.Ci16xlarge => "ci_16xlarge",
                ApplyProjectAddonBodyAddonVariantVariant1.Ci24xlarge => "ci_24xlarge",
                ApplyProjectAddonBodyAddonVariantVariant1.Ci24xlargeHighMemory => "ci_24xlarge_high_memory",
                ApplyProjectAddonBodyAddonVariantVariant1.Ci24xlargeOptimizedCpu => "ci_24xlarge_optimized_cpu",
                ApplyProjectAddonBodyAddonVariantVariant1.Ci24xlargeOptimizedMemory => "ci_24xlarge_optimized_memory",
                ApplyProjectAddonBodyAddonVariantVariant1.Ci2xlarge => "ci_2xlarge",
                ApplyProjectAddonBodyAddonVariantVariant1.Ci48xlarge => "ci_48xlarge",
                ApplyProjectAddonBodyAddonVariantVariant1.Ci48xlargeHighMemory => "ci_48xlarge_high_memory",
                ApplyProjectAddonBodyAddonVariantVariant1.Ci48xlargeOptimizedCpu => "ci_48xlarge_optimized_cpu",
                ApplyProjectAddonBodyAddonVariantVariant1.Ci48xlargeOptimizedMemory => "ci_48xlarge_optimized_memory",
                ApplyProjectAddonBodyAddonVariantVariant1.Ci4xlarge => "ci_4xlarge",
                ApplyProjectAddonBodyAddonVariantVariant1.Ci8xlarge => "ci_8xlarge",
                ApplyProjectAddonBodyAddonVariantVariant1.CiLarge => "ci_large",
                ApplyProjectAddonBodyAddonVariantVariant1.CiMedium => "ci_medium",
                ApplyProjectAddonBodyAddonVariantVariant1.CiMicro => "ci_micro",
                ApplyProjectAddonBodyAddonVariantVariant1.CiSmall => "ci_small",
                ApplyProjectAddonBodyAddonVariantVariant1.CiXlarge => "ci_xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyProjectAddonBodyAddonVariantVariant1? ToEnum(string value)
        {
            return value switch
            {
                "ci_12xlarge" => ApplyProjectAddonBodyAddonVariantVariant1.Ci12xlarge,
                "ci_16xlarge" => ApplyProjectAddonBodyAddonVariantVariant1.Ci16xlarge,
                "ci_24xlarge" => ApplyProjectAddonBodyAddonVariantVariant1.Ci24xlarge,
                "ci_24xlarge_high_memory" => ApplyProjectAddonBodyAddonVariantVariant1.Ci24xlargeHighMemory,
                "ci_24xlarge_optimized_cpu" => ApplyProjectAddonBodyAddonVariantVariant1.Ci24xlargeOptimizedCpu,
                "ci_24xlarge_optimized_memory" => ApplyProjectAddonBodyAddonVariantVariant1.Ci24xlargeOptimizedMemory,
                "ci_2xlarge" => ApplyProjectAddonBodyAddonVariantVariant1.Ci2xlarge,
                "ci_48xlarge" => ApplyProjectAddonBodyAddonVariantVariant1.Ci48xlarge,
                "ci_48xlarge_high_memory" => ApplyProjectAddonBodyAddonVariantVariant1.Ci48xlargeHighMemory,
                "ci_48xlarge_optimized_cpu" => ApplyProjectAddonBodyAddonVariantVariant1.Ci48xlargeOptimizedCpu,
                "ci_48xlarge_optimized_memory" => ApplyProjectAddonBodyAddonVariantVariant1.Ci48xlargeOptimizedMemory,
                "ci_4xlarge" => ApplyProjectAddonBodyAddonVariantVariant1.Ci4xlarge,
                "ci_8xlarge" => ApplyProjectAddonBodyAddonVariantVariant1.Ci8xlarge,
                "ci_large" => ApplyProjectAddonBodyAddonVariantVariant1.CiLarge,
                "ci_medium" => ApplyProjectAddonBodyAddonVariantVariant1.CiMedium,
                "ci_micro" => ApplyProjectAddonBodyAddonVariantVariant1.CiMicro,
                "ci_small" => ApplyProjectAddonBodyAddonVariantVariant1.CiSmall,
                "ci_xlarge" => ApplyProjectAddonBodyAddonVariantVariant1.CiXlarge,
                _ => null,
            };
        }
    }
}