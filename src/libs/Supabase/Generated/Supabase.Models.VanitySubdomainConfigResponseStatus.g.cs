
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum VanitySubdomainConfigResponseStatus
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
    public static class VanitySubdomainConfigResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VanitySubdomainConfigResponseStatus value)
        {
            return value switch
            {
                VanitySubdomainConfigResponseStatus.Active => "active",
                VanitySubdomainConfigResponseStatus.CustomDomainUsed => "custom-domain-used",
                VanitySubdomainConfigResponseStatus.NotUsed => "not-used",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VanitySubdomainConfigResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => VanitySubdomainConfigResponseStatus.Active,
                "custom-domain-used" => VanitySubdomainConfigResponseStatus.CustomDomainUsed,
                "not-used" => VanitySubdomainConfigResponseStatus.NotUsed,
                _ => null,
            };
        }
    }
}