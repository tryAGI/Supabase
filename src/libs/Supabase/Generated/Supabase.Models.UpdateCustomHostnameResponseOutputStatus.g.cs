
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateCustomHostnameResponseOutputStatus
    {
        /// <summary>
        ///
        /// </summary>
        x1NotStarted,
        /// <summary>
        ///
        /// </summary>
        x2Initiated,
        /// <summary>
        ///
        /// </summary>
        x3ChallengeVerified,
        /// <summary>
        ///
        /// </summary>
        x4OriginSetupCompleted,
        /// <summary>
        ///
        /// </summary>
        x5ServicesReconfigured,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCustomHostnameResponseOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCustomHostnameResponseOutputStatus value)
        {
            return value switch
            {
                UpdateCustomHostnameResponseOutputStatus.x1NotStarted => "1_not_started",
                UpdateCustomHostnameResponseOutputStatus.x2Initiated => "2_initiated",
                UpdateCustomHostnameResponseOutputStatus.x3ChallengeVerified => "3_challenge_verified",
                UpdateCustomHostnameResponseOutputStatus.x4OriginSetupCompleted => "4_origin_setup_completed",
                UpdateCustomHostnameResponseOutputStatus.x5ServicesReconfigured => "5_services_reconfigured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCustomHostnameResponseOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "1_not_started" => UpdateCustomHostnameResponseOutputStatus.x1NotStarted,
                "2_initiated" => UpdateCustomHostnameResponseOutputStatus.x2Initiated,
                "3_challenge_verified" => UpdateCustomHostnameResponseOutputStatus.x3ChallengeVerified,
                "4_origin_setup_completed" => UpdateCustomHostnameResponseOutputStatus.x4OriginSetupCompleted,
                "5_services_reconfigured" => UpdateCustomHostnameResponseOutputStatus.x5ServicesReconfigured,
                _ => null,
            };
        }
    }
}