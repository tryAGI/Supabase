
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum SnippetResponseVisibility
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
    public static class SnippetResponseVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SnippetResponseVisibility value)
        {
            return value switch
            {
                SnippetResponseVisibility.Org => "org",
                SnippetResponseVisibility.Project => "project",
                SnippetResponseVisibility.Public => "public",
                SnippetResponseVisibility.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SnippetResponseVisibility? ToEnum(string value)
        {
            return value switch
            {
                "org" => SnippetResponseVisibility.Org,
                "project" => SnippetResponseVisibility.Project,
                "public" => SnippetResponseVisibility.Public,
                "user" => SnippetResponseVisibility.User,
                _ => null,
            };
        }
    }
}