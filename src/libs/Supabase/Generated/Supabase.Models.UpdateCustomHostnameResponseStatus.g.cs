
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCustomHostnameResponseStatus
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
    public static class UpdateCustomHostnameResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCustomHostnameResponseStatus value)
        {
            return value switch
            {
                UpdateCustomHostnameResponseStatus.x1NotStarted => "1_not_started",
                UpdateCustomHostnameResponseStatus.x2Initiated => "2_initiated",
                UpdateCustomHostnameResponseStatus.x3ChallengeVerified => "3_challenge_verified",
                UpdateCustomHostnameResponseStatus.x4OriginSetupCompleted => "4_origin_setup_completed",
                UpdateCustomHostnameResponseStatus.x5ServicesReconfigured => "5_services_reconfigured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCustomHostnameResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "1_not_started" => UpdateCustomHostnameResponseStatus.x1NotStarted,
                "2_initiated" => UpdateCustomHostnameResponseStatus.x2Initiated,
                "3_challenge_verified" => UpdateCustomHostnameResponseStatus.x3ChallengeVerified,
                "4_origin_setup_completed" => UpdateCustomHostnameResponseStatus.x4OriginSetupCompleted,
                "5_services_reconfigured" => UpdateCustomHostnameResponseStatus.x5ServicesReconfigured,
                _ => null,
            };
        }
    }
}