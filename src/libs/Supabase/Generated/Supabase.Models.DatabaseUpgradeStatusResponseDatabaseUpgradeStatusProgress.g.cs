
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress
    {
        /// <summary>
        /// 
        /// </summary>
        x0Requested,
        /// <summary>
        /// 
        /// </summary>
        x10CompletedPostPhysicalBackup,
        /// <summary>
        /// 
        /// </summary>
        x1Started,
        /// <summary>
        /// 
        /// </summary>
        x2LaunchedUpgradedInstance,
        /// <summary>
        /// 
        /// </summary>
        x3DetachedVolumeFromUpgradedInstance,
        /// <summary>
        /// 
        /// </summary>
        x4AttachedVolumeToOriginalInstance,
        /// <summary>
        /// 
        /// </summary>
        x5InitiatedDataUpgrade,
        /// <summary>
        /// 
        /// </summary>
        x6CompletedDataUpgrade,
        /// <summary>
        /// 
        /// </summary>
        x7DetachedVolumeFromOriginalInstance,
        /// <summary>
        /// 
        /// </summary>
        x8AttachedVolumeToUpgradedInstance,
        /// <summary>
        /// 
        /// </summary>
        x9CompletedUpgrade,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgressExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress value)
        {
            return value switch
            {
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x0Requested => "0_requested",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x10CompletedPostPhysicalBackup => "10_completed_post_physical_backup",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x1Started => "1_started",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x2LaunchedUpgradedInstance => "2_launched_upgraded_instance",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x3DetachedVolumeFromUpgradedInstance => "3_detached_volume_from_upgraded_instance",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x4AttachedVolumeToOriginalInstance => "4_attached_volume_to_original_instance",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x5InitiatedDataUpgrade => "5_initiated_data_upgrade",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x6CompletedDataUpgrade => "6_completed_data_upgrade",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x7DetachedVolumeFromOriginalInstance => "7_detached_volume_from_original_instance",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x8AttachedVolumeToUpgradedInstance => "8_attached_volume_to_upgraded_instance",
                DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x9CompletedUpgrade => "9_completed_upgrade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress? ToEnum(string value)
        {
            return value switch
            {
                "0_requested" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x0Requested,
                "10_completed_post_physical_backup" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x10CompletedPostPhysicalBackup,
                "1_started" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x1Started,
                "2_launched_upgraded_instance" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x2LaunchedUpgradedInstance,
                "3_detached_volume_from_upgraded_instance" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x3DetachedVolumeFromUpgradedInstance,
                "4_attached_volume_to_original_instance" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x4AttachedVolumeToOriginalInstance,
                "5_initiated_data_upgrade" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x5InitiatedDataUpgrade,
                "6_completed_data_upgrade" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x6CompletedDataUpgrade,
                "7_detached_volume_from_original_instance" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x7DetachedVolumeFromOriginalInstance,
                "8_attached_volume_to_upgraded_instance" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x8AttachedVolumeToUpgradedInstance,
                "9_completed_upgrade" => DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress.x9CompletedUpgrade,
                _ => null,
            };
        }
    }
}