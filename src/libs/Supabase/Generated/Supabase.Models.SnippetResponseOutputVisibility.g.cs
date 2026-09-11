
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum SnippetResponseOutputVisibility
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
    public static class SnippetResponseOutputVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SnippetResponseOutputVisibility value)
        {
            return value switch
            {
                SnippetResponseOutputVisibility.Org => "org",
                SnippetResponseOutputVisibility.Project => "project",
                SnippetResponseOutputVisibility.Public => "public",
                SnippetResponseOutputVisibility.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SnippetResponseOutputVisibility? ToEnum(string value)
        {
            return value switch
            {
                "org" => SnippetResponseOutputVisibility.Org,
                "project" => SnippetResponseOutputVisibility.Project,
                "public" => SnippetResponseOutputVisibility.Public,
                "user" => SnippetResponseOutputVisibility.User,
                _ => null,
            };
        }
    }
}