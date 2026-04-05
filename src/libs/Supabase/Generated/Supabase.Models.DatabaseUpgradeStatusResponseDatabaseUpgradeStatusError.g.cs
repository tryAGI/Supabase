
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError
    {
        /// <summary>
        /// 
        /// </summary>
        x1UpgradedInstanceLaunchFailed,
        /// <summary>
        /// 
        /// </summary>
        x2VolumeDetachchmentFromUpgradedInstanceFailed,
        /// <summary>
        /// 
        /// </summary>
        x3VolumeAttachmentToOriginalInstanceFailed,
        /// <summary>
        /// 
        /// </summary>
        x4DataUpgradeInitiationFailed,
        /// <summary>
        /// 
        /// </summary>
        x5DataUpgradeCompletionFailed,
        /// <summary>
        /// 
        /// </summary>
        x6VolumeDetachchmentFromOriginalInstanceFailed,
        /// <summary>
        /// 
        /// </summary>
        x7VolumeAttachmentToUpgradedInstanceFailed,
        /// <summary>
        /// 
        /// </summary>
        x8UpgradeCompletionFailed,
        /// <summary>
        /// 
        /// </summary>
        x9PostPhysicalBackupFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatabaseUpgradeStatusResponseDatabaseUpgradeStatusErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError value)
        {
            return value switch
            {
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x1UpgradedInstanceLaunchFailed => "1_upgraded_instance_launch_failed",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x2VolumeDetachchmentFromUpgradedInstanceFailed => "2_volume_detachchment_from_upgraded_instance_failed",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x3VolumeAttachmentToOriginalInstanceFailed => "3_volume_attachment_to_original_instance_failed",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x4DataUpgradeInitiationFailed => "4_data_upgrade_initiation_failed",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x5DataUpgradeCompletionFailed => "5_data_upgrade_completion_failed",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x6VolumeDetachchmentFromOriginalInstanceFailed => "6_volume_detachchment_from_original_instance_failed",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x7VolumeAttachmentToUpgradedInstanceFailed => "7_volume_attachment_to_upgraded_instance_failed",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x8UpgradeCompletionFailed => "8_upgrade_completion_failed",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x9PostPhysicalBackupFailed => "9_post_physical_backup_failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError? ToEnum(string value)
        {
            return value switch
            {
                "1_upgraded_instance_launch_failed" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x1UpgradedInstanceLaunchFailed,
                "2_volume_detachchment_from_upgraded_instance_failed" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x2VolumeDetachchmentFromUpgradedInstanceFailed,
                "3_volume_attachment_to_original_instance_failed" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x3VolumeAttachmentToOriginalInstanceFailed,
                "4_data_upgrade_initiation_failed" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x4DataUpgradeInitiationFailed,
                "5_data_upgrade_completion_failed" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x5DataUpgradeCompletionFailed,
                "6_volume_detachchment_from_original_instance_failed" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x6VolumeDetachchmentFromOriginalInstanceFailed,
                "7_volume_attachment_to_upgraded_instance_failed" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x7VolumeAttachmentToUpgradedInstanceFailed,
                "8_upgrade_completion_failed" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x8UpgradeCompletionFailed,
                "9_post_physical_backup_failed" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError.x9PostPhysicalBackupFailed,
                _ => null,
            };
        }
    }
}