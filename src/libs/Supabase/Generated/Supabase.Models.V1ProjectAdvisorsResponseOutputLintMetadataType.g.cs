
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1ProjectAdvisorsResponseOutputLintMetadataType
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
        ForeignTable,
        /// <summary>
        ///
        /// </summary>
        Function,
        /// <summary>
        ///
        /// </summary>
        Health,
        /// <summary>
        ///
        /// </summary>
        MaterializedView,
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
    public static class V1ProjectAdvisorsResponseOutputLintMetadataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ProjectAdvisorsResponseOutputLintMetadataType value)
        {
            return value switch
            {
                V1ProjectAdvisorsResponseOutputLintMetadataType.Auth => "auth",
                V1ProjectAdvisorsResponseOutputLintMetadataType.Compliance => "compliance",
                V1ProjectAdvisorsResponseOutputLintMetadataType.Extension => "extension",
                V1ProjectAdvisorsResponseOutputLintMetadataType.ForeignTable => "foreign table",
                V1ProjectAdvisorsResponseOutputLintMetadataType.Function => "function",
                V1ProjectAdvisorsResponseOutputLintMetadataType.Health => "health",
                V1ProjectAdvisorsResponseOutputLintMetadataType.MaterializedView => "materialized view",
                V1ProjectAdvisorsResponseOutputLintMetadataType.Table => "table",
                V1ProjectAdvisorsResponseOutputLintMetadataType.View => "view",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ProjectAdvisorsResponseOutputLintMetadataType? ToEnum(string value)
        {
            return value switch
            {
                "auth" => V1ProjectAdvisorsResponseOutputLintMetadataType.Auth,
                "compliance" => V1ProjectAdvisorsResponseOutputLintMetadataType.Compliance,
                "extension" => V1ProjectAdvisorsResponseOutputLintMetadataType.Extension,
                "foreign table" => V1ProjectAdvisorsResponseOutputLintMetadataType.ForeignTable,
                "function" => V1ProjectAdvisorsResponseOutputLintMetadataType.Function,
                "health" => V1ProjectAdvisorsResponseOutputLintMetadataType.Health,
                "materialized view" => V1ProjectAdvisorsResponseOutputLintMetadataType.MaterializedView,
                "table" => V1ProjectAdvisorsResponseOutputLintMetadataType.Table,
                "view" => V1ProjectAdvisorsResponseOutputLintMetadataType.View,
                _ => null,
            };
        }
    }
}