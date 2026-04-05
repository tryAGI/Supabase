
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1BackupsResponseBackupStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Removed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1BackupsResponseBackupStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1BackupsResponseBackupStatus value)
        {
            return value switch
            {
                V1BackupsResponseBackupStatus.Archived => "ARCHIVED",
                V1BackupsResponseBackupStatus.Cancelled => "CANCELLED",
                V1BackupsResponseBackupStatus.Completed => "COMPLETED",
                V1BackupsResponseBackupStatus.Failed => "FAILED",
                V1BackupsResponseBackupStatus.Pending => "PENDING",
                V1BackupsResponseBackupStatus.Removed => "REMOVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1BackupsResponseBackupStatus? ToEnum(string value)
        {
            return value switch
            {
                "ARCHIVED" => V1BackupsResponseBackupStatus.Archived,
                "CANCELLED" => V1BackupsResponseBackupStatus.Cancelled,
                "COMPLETED" => V1BackupsResponseBackupStatus.Completed,
                "FAILED" => V1BackupsResponseBackupStatus.Failed,
                "PENDING" => V1BackupsResponseBackupStatus.Pending,
                "REMOVED" => V1BackupsResponseBackupStatus.Removed,
                _ => null,
            };
        }
    }
}