
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum VanitySubdomainConfigResponseOutputStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        CustomDomainUsed,
        /// <summary>
        ///
        /// </summary>
        NotUsed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VanitySubdomainConfigResponseOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VanitySubdomainConfigResponseOutputStatus value)
        {
            return value switch
            {
                VanitySubdomainConfigResponseOutputStatus.Active => "active",
                VanitySubdomainConfigResponseOutputStatus.CustomDomainUsed => "custom-domain-used",
                VanitySubdomainConfigResponseOutputStatus.NotUsed => "not-used",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VanitySubdomainConfigResponseOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => VanitySubdomainConfigResponseOutputStatus.Active,
                "custom-domain-used" => VanitySubdomainConfigResponseOutputStatus.CustomDomainUsed,
                "not-used" => VanitySubdomainConfigResponseOutputStatus.NotUsed,
                _ => null,
            };
        }
    }
}