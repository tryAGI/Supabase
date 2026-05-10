
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationProjectsResponseProjectDatabase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infra_compute_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseInfraComputeSizeJsonConverter))]
        public global::Supabase.OrganizationProjectsResponseProjectDatabaseInfraComputeSize? InfraComputeSize { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.OrganizationProjectsResponseProjectDatabaseStatus Status { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.OrganizationProjectsResponseProjectDatabaseType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_volume_size_gb")]
        public double? DiskVolumeSizeGb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseDiskTypeJsonConverter))]
        public global::Supabase.OrganizationProjectsResponseProjectDatabaseDiskType? DiskType { get; set; }

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
        /// Initializes a new instance of the <see cref="OrganizationProjectsResponseProjectDatabase" /> class.
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
        public OrganizationProjectsResponseProjectDatabase(
            string region,
            global::Supabase.OrganizationProjectsResponseProjectDatabaseStatus status,
            string cloudProvider,
            string identifier,
            global::Supabase.OrganizationProjectsResponseProjectDatabaseType type,
            global::Supabase.OrganizationProjectsResponseProjectDatabaseInfraComputeSize? infraComputeSize,
            double? diskVolumeSizeGb,
            global::Supabase.OrganizationProjectsResponseProjectDatabaseDiskType? diskType,
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
        /// Initializes a new instance of the <see cref="OrganizationProjectsResponseProjectDatabase" /> class.
        /// </summary>
        public OrganizationProjectsResponseProjectDatabase()
        {
        }

    }
}