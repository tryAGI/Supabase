
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1ListAllSnippetsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        InsertedAt,
        /// <summary>
        /// 
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1ListAllSnippetsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1ListAllSnippetsSortBy value)
        {
            return value switch
            {
                V1ListAllSnippetsSortBy.InsertedAt => "inserted_at",
                V1ListAllSnippetsSortBy.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1ListAllSnippetsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "inserted_at" => V1ListAllSnippetsSortBy.InsertedAt,
                "name" => V1ListAllSnippetsSortBy.Name,
                _ => null,
            };
        }
    }
}