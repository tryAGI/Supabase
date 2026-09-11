
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationProjectsResponseOutputProjectDatabase
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infra_compute_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSizeJsonConverter))]
        public global::Supabase.OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize? InfraComputeSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseOutputProjectDatabaseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.OrganizationProjectsResponseOutputProjectDatabaseStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CloudProvider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseOutputProjectDatabaseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.OrganizationProjectsResponseOutputProjectDatabaseType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_volume_size_gb")]
        public double? DiskVolumeSizeGb { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseOutputProjectDatabaseDiskTypeJsonConverter))]
        public global::Supabase.OrganizationProjectsResponseOutputProjectDatabaseDiskType? DiskType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_throughput_mbps")]
        public double? DiskThroughputMbps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_last_modified_at")]
        public string? DiskLastModifiedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProjectsResponseOutputProjectDatabase" /> class.
        /// </summary>
        /// <param name="region"></param>
        /// <param name="status"></param>
        /// <param name="cloudProvider"></param>
        /// <param name="identifier"></param>
        /// <param name="type"></param>
        /// <param name="infraComputeSize"></param>
        /// <param name="diskVolumeSizeGb"></param>
        /// <param name="diskType"></param>
        /// <param name="diskThroughputMbps"></param>
        /// <param name="diskLastModifiedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationProjectsResponseOutputProjectDatabase(
            string region,
            global::Supabase.OrganizationProjectsResponseOutputProjectDatabaseStatus status,
            string cloudProvider,
            string identifier,
            global::Supabase.OrganizationProjectsResponseOutputProjectDatabaseType type,
            global::Supabase.OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize? infraComputeSize,
            double? diskVolumeSizeGb,
            global::Supabase.OrganizationProjectsResponseOutputProjectDatabaseDiskType? diskType,
            double? diskThroughputMbps,
            string? diskLastModifiedAt)
        {
            this.InfraComputeSize = infraComputeSize;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Status = status;
            this.CloudProvider = cloudProvider ?? throw new global::System.ArgumentNullException(nameof(cloudProvider));
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Type = type;
            this.DiskVolumeSizeGb = diskVolumeSizeGb;
            this.DiskType = diskType;
            this.DiskThroughputMbps = diskThroughputMbps;
            this.DiskLastModifiedAt = diskLastModifiedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProjectsResponseOutputProjectDatabase" /> class.
        /// </summary>
        public OrganizationProjectsResponseOutputProjectDatabase()
        {
        }

    }
}