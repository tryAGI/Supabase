
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1ListProjectsPaginatedResponseProject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CloudProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inserted_at")]
        public string? InsertedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_id")]
        public string? SubscriptionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_branch_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBranchEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_physical_backups_enabled")]
        public bool? IsPhysicalBackupsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_branch_refs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PreviewBranchRefs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_volume_size_gb")]
        public double? DiskVolumeSizeGb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infra_compute_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1ListProjectsPaginatedResponseProjectInfraComputeSizeJsonConverter))]
        public global::Supabase.V1ListProjectsPaginatedResponseProjectInfraComputeSize? InfraComputeSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListProjectsPaginatedResponseProject" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cloudProvider"></param>
        /// <param name="name"></param>
        /// <param name="organizationId"></param>
        /// <param name="organizationSlug"></param>
        /// <param name="ref"></param>
        /// <param name="region"></param>
        /// <param name="status"></param>
        /// <param name="isBranchEnabled"></param>
        /// <param name="previewBranchRefs"></param>
        /// <param name="insertedAt"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="isPhysicalBackupsEnabled"></param>
        /// <param name="diskVolumeSizeGb"></param>
        /// <param name="infraComputeSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ListProjectsPaginatedResponseProject(
            double id,
            string cloudProvider,
            string name,
            double organizationId,
            string organizationSlug,
            string @ref,
            string region,
            string status,
            bool isBranchEnabled,
            global::System.Collections.Generic.IList<string> previewBranchRefs,
            string? insertedAt,
            string? subscriptionId,
            bool? isPhysicalBackupsEnabled,
            double? diskVolumeSizeGb,
            global::Supabase.V1ListProjectsPaginatedResponseProjectInfraComputeSize? infraComputeSize)
        {
            this.Id = id;
            this.CloudProvider = cloudProvider ?? throw new global::System.ArgumentNullException(nameof(cloudProvider));
            this.InsertedAt = insertedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrganizationId = organizationId;
            this.OrganizationSlug = organizationSlug ?? throw new global::System.ArgumentNullException(nameof(organizationSlug));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.SubscriptionId = subscriptionId;
            this.IsBranchEnabled = isBranchEnabled;
            this.IsPhysicalBackupsEnabled = isPhysicalBackupsEnabled;
            this.PreviewBranchRefs = previewBranchRefs ?? throw new global::System.ArgumentNullException(nameof(previewBranchRefs));
            this.DiskVolumeSizeGb = diskVolumeSizeGb;
            this.InfraComputeSize = infraComputeSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListProjectsPaginatedResponseProject" /> class.
        /// </summary>
        public V1ListProjectsPaginatedResponseProject()
        {
        }
    }
}