
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum SnippetResponseOutputType
    {
        /// <summary>
        ///
        /// </summary>
        Sql,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SnippetResponseOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SnippetResponseOutputType value)
        {
            return value switch
            {
                SnippetResponseOutputType.Sql => "sql",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SnippetResponseOutputType? ToEnum(string value)
        {
            return value switch
            {
                "sql" => SnippetResponseOutputType.Sql,
                _ => null,
            };
        }
    }
}