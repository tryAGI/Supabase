
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ListAllSnippetsSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ListAllSnippetsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListAllSnippetsSortOrder value)
        {
            return value switch
            {
                V1ListAllSnippetsSortOrder.Asc => "asc",
                V1ListAllSnippetsSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListAllSnippetsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => V1ListAllSnippetsSortOrder.Asc,
                "desc" => V1ListAllSnippetsSortOrder.Desc,
                _ => null,
            };
        }
    }
}