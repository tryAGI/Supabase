
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"target_version":"17","release_channel":"ga"}
    /// </summary>
    public sealed partial class UpgradeDatabaseBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.UpgradeDatabaseBodyReleaseChannelJsonConverter))]
        public global::Supabase.UpgradeDatabaseBodyReleaseChannel? ReleaseChannel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeDatabaseBody" /> class.
        /// </summary>
        /// <param name="targetVersion"></param>
        /// <param name="releaseChannel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpgradeDatabaseBody(
            string targetVersion,
            global::Supabase.UpgradeDatabaseBodyReleaseChannel? releaseChannel)
        {
            this.TargetVersion = targetVersion ?? throw new global::System.ArgumentNullException(nameof(targetVersion));
            this.ReleaseChannel = releaseChannel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeDatabaseBody" /> class.
        /// </summary>
        public UpgradeDatabaseBody()
        {
        }
    }
}