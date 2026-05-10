
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_project_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParentProjectRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_branch")]
        public string? GitBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pr_number")]
        public int? PrNumber { get; set; }

        /// <summary>
        /// This field is deprecated and will not be populated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_check_run_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? LatestCheckRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persistent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Persistent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.BranchResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.BranchResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_requested_at")]
        public global::System.DateTime? ReviewRequestedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WithData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletion_scheduled_at")]
        public global::System.DateTime? DeletionScheduledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_project_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.BranchResponsePreviewProjectStatusJsonConverter))]
        public global::Supabase.BranchResponsePreviewProjectStatus? PreviewProjectStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="projectRef"></param>
        /// <param name="parentProjectRef"></param>
        /// <param name="isDefault"></param>
        /// <param name="persistent"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="withData"></param>
        /// <param name="gitBranch"></param>
        /// <param name="prNumber"></param>
        /// <param name="reviewRequestedAt"></param>
        /// <param name="notifyUrl"></param>
        /// <param name="deletionScheduledAt"></param>
        /// <param name="previewProjectStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchResponse(
            global::System.Guid id,
            string name,
            string projectRef,
            string parentProjectRef,
            bool isDefault,
            bool persistent,
            global::Supabase.BranchResponseStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            bool withData,
            string? gitBranch,
            int? prNumber,
            global::System.DateTime? reviewRequestedAt,
            string? notifyUrl,
            global::System.DateTime? deletionScheduledAt,
            global::Supabase.BranchResponsePreviewProjectStatus? previewProjectStatus)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectRef = projectRef ?? throw new global::System.ArgumentNullException(nameof(projectRef));
            this.ParentProjectRef = parentProjectRef ?? throw new global::System.ArgumentNullException(nameof(parentProjectRef));
            this.IsDefault = isDefault;
            this.GitBranch = gitBranch;
            this.PrNumber = prNumber;
            this.Persistent = persistent;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ReviewRequestedAt = reviewRequestedAt;
            this.WithData = withData;
            this.NotifyUrl = notifyUrl;
            this.DeletionScheduledAt = deletionScheduledAt;
            this.PreviewProjectStatus = previewProjectStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchResponse" /> class.
        /// </summary>
        public BranchResponse()
        {
        }

    }
}