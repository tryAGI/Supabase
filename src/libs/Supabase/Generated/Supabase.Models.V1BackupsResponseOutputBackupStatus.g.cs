
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum V1BackupsResponseOutputBackupStatus
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
    public static class V1BackupsResponseOutputBackupStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1BackupsResponseOutputBackupStatus value)
        {
            return value switch
            {
                V1BackupsResponseOutputBackupStatus.Archived => "ARCHIVED",
                V1BackupsResponseOutputBackupStatus.Cancelled => "CANCELLED",
                V1BackupsResponseOutputBackupStatus.Completed => "COMPLETED",
                V1BackupsResponseOutputBackupStatus.Failed => "FAILED",
                V1BackupsResponseOutputBackupStatus.Pending => "PENDING",
                V1BackupsResponseOutputBackupStatus.Removed => "REMOVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1BackupsResponseOutputBackupStatus? ToEnum(string value)
        {
            return value switch
            {
                "ARCHIVED" => V1BackupsResponseOutputBackupStatus.Archived,
                "CANCELLED" => V1BackupsResponseOutputBackupStatus.Cancelled,
                "COMPLETED" => V1BackupsResponseOutputBackupStatus.Completed,
                "FAILED" => V1BackupsResponseOutputBackupStatus.Failed,
                "PENDING" => V1BackupsResponseOutputBackupStatus.Pending,
                "REMOVED" => V1BackupsResponseOutputBackupStatus.Removed,
                _ => null,
            };
        }
    }
}