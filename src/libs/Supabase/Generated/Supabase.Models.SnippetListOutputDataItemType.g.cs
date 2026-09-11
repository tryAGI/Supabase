
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum SnippetListOutputDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Sql,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SnippetListOutputDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SnippetListOutputDataItemType value)
        {
            return value switch
            {
                SnippetListOutputDataItemType.Sql => "sql",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SnippetListOutputDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "sql" => SnippetListOutputDataItemType.Sql,
                _ => null,
            };
        }
    }
}