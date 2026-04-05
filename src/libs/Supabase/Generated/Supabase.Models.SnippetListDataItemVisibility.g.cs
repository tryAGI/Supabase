
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum SnippetListDataItemVisibility
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
    public static class SnippetListDataItemVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SnippetListDataItemVisibility value)
        {
            return value switch
            {
                SnippetListDataItemVisibility.Org => "org",
                SnippetListDataItemVisibility.Project => "project",
                SnippetListDataItemVisibility.Public => "public",
                SnippetListDataItemVisibility.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SnippetListDataItemVisibility? ToEnum(string value)
        {
            return value switch
            {
                "org" => SnippetListDataItemVisibility.Org,
                "project" => SnippetListDataItemVisibility.Project,
                "public" => SnippetListDataItemVisibility.Public,
                "user" => SnippetListDataItemVisibility.User,
                _ => null,
            };
        }
    }
}