
#nullable enable

namespace Supabase
{
    /// <summary>
    /// `apply` replaces the enforced list with the pending one and applies it. `reject` discards the pending one and keeps the enforced list.
    /// </summary>
    public enum NetworkRestrictionsReviewRequestAction
    {
        /// <summary>
        ///
        /// </summary>
        Apply,
        /// <summary>
        ///
        /// </summary>
        Reject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NetworkRestrictionsReviewRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkRestrictionsReviewRequestAction value)
        {
            return value switch
            {
                NetworkRestrictionsReviewRequestAction.Apply => "apply",
                NetworkRestrictionsReviewRequestAction.Reject => "reject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkRestrictionsReviewRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "apply" => NetworkRestrictionsReviewRequestAction.Apply,
                "reject" => NetworkRestrictionsReviewRequestAction.Reject,
                _ => null,
            };
        }
    }
}