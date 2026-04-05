
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ProjectAdvisorsResponseLintMetadataType
    {
        /// <summary>
        /// 
        /// </summary>
        Auth,
        /// <summary>
        /// 
        /// </summary>
        Compliance,
        /// <summary>
        /// 
        /// </summary>
        Extension,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        Table,
        /// <summary>
        /// 
        /// </summary>
        View,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ProjectAdvisorsResponseLintMetadataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectAdvisorsResponseLintMetadataType value)
        {
            return value switch
            {
                V1ProjectAdvisorsResponseLintMetadataType.Auth => "auth",
                V1ProjectAdvisorsResponseLintMetadataType.Compliance => "compliance",
                V1ProjectAdvisorsResponseLintMetadataType.Extension => "extension",
                V1ProjectAdvisorsResponseLintMetadataType.Function => "function",
                V1ProjectAdvisorsResponseLintMetadataType.Table => "table",
                V1ProjectAdvisorsResponseLintMetadataType.View => "view",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectAdvisorsResponseLintMetadataType? ToEnum(string value)
        {
            return value switch
            {
                "auth" => V1ProjectAdvisorsResponseLintMetadataType.Auth,
                "compliance" => V1ProjectAdvisorsResponseLintMetadataType.Compliance,
                "extension" => V1ProjectAdvisorsResponseLintMetadataType.Extension,
                "function" => V1ProjectAdvisorsResponseLintMetadataType.Function,
                "table" => V1ProjectAdvisorsResponseLintMetadataType.Table,
                "view" => V1ProjectAdvisorsResponseLintMetadataType.View,
                _ => null,
            };
        }
    }
}