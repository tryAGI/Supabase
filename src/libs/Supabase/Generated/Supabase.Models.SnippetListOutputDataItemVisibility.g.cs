
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum SnippetListOutputDataItemVisibility
    {
        /// <summary>
        ///
        /// </summary>
        Org,
        /// <summary>
        ///
        /// </summary>
        Project,
        /// <summary>
        ///
        /// </summary>
        Public,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SnippetListOutputDataItemVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SnippetListOutputDataItemVisibility value)
        {
            return value switch
            {
                SnippetListOutputDataItemVisibility.Org => "org",
                SnippetListOutputDataItemVisibility.Project => "project",
                SnippetListOutputDataItemVisibility.Public => "public",
                SnippetListOutputDataItemVisibility.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SnippetListOutputDataItemVisibility? ToEnum(string value)
        {
            return value switch
            {
                "org" => SnippetListOutputDataItemVisibility.Org,
                "project" => SnippetListOutputDataItemVisibility.Project,
                "public" => SnippetListOutputDataItemVisibility.Public,
                "user" => SnippetListOutputDataItemVisibility.User,
                _ => null,
            };
        }
    }
}