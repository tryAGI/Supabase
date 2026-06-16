
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectAddonsResponseAvailableAddonVariantIdVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        EtlPipelineDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectAddonsResponseAvailableAddonVariantIdVariant8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectAddonsResponseAvailableAddonVariantIdVariant8 value)
        {
            return value switch
            {
                ListProjectAddonsResponseAvailableAddonVariantIdVariant8.EtlPipelineDefault => "etl_pipeline_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectAddonsResponseAvailableAddonVariantIdVariant8? ToEnum(string value)
        {
            return value switch
            {
                "etl_pipeline_default" => ListProjectAddonsResponseAvailableAddonVariantIdVariant8.EtlPipelineDefault,
                _ => null,
            };
        }
    }
}