
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum SnippetListDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Sql,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SnippetListDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SnippetListDataItemType value)
        {
            return value switch
            {
                SnippetListDataItemType.Sql => "sql",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SnippetListDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "sql" => SnippetListDataItemType.Sql,
                _ => null,
            };
        }
    }
}