
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public enum DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress
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
    public static class DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgressExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress value)
        {
            return value switch
            {
                DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x0Requested => "0_requested",
                DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x10CompletedPostPhysicalBackup => "10_completed_post_physical_backup",
                DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x1Started => "1_started",
                DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x2LaunchedUpgradedInstance => "2_launched_upgraded_instance",
                DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x3DetachedVolumeFromUpgradedInstance => "3_detached_volume_from_upgraded_instance",
                DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x4AttachedVolumeToOriginalInstance => "4_attached_volume_to_original_instance",
                DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x5InitiatedDataUpgrade => "5_initiated_data_upgrade",
                DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x6CompletedDataUpgrade => "6_completed_data_upgrade",
                DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x7DetachedVolumeFromOriginalInstance => "7_detached_volume_from_original_instance",
                DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x8AttachedVolumeToUpgradedInstance => "8_attached_volume_to_upgraded_instance",
                DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x9CompletedUpgrade => "9_completed_upgrade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress? ToEnum(string value)
        {
            return value switch
            {
                "0_requested" => DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x0Requested,
                "10_completed_post_physical_backup" => DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x10CompletedPostPhysicalBackup,
                "1_started" => DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x1Started,
                "2_launched_upgraded_instance" => DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x2LaunchedUpgradedInstance,
                "3_detached_volume_from_upgraded_instance" => DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x3DetachedVolumeFromUpgradedInstance,
                "4_attached_volume_to_original_instance" => DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x4AttachedVolumeToOriginalInstance,
                "5_initiated_data_upgrade" => DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x5InitiatedDataUpgrade,
                "6_completed_data_upgrade" => DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x6CompletedDataUpgrade,
                "7_detached_volume_from_original_instance" => DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x7DetachedVolumeFromOriginalInstance,
                "8_attached_volume_to_upgraded_instance" => DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x8AttachedVolumeToUpgradedInstance,
                "9_completed_upgrade" => DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress.x9CompletedUpgrade,
                _ => null,
            };
        }
    }
}