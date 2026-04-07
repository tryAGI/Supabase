
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"branch_name":"preview-login-page","git_branch":"feature/login-page","persistent":true,"request_review":true,"notify_url":"https://example.com/webhooks/branches"}
    /// </summary>
    public sealed partial class UpdateBranchBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_name")]
        public string? BranchName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_branch")]
        public string? GitBranch { get; set; }

        /// <summary>
        /// This field is deprecated and will be ignored. Use v1-reset-a-branch endpoint directly instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_on_push")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ResetOnPush { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persistent")]
        public bool? Persistent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.UpdateBranchBodyStatusJsonConverter))]
        public global::Supabase.UpdateBranchBodyStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_review")]
        public bool? RequestReview { get; set; }

        /// <summary>
        /// HTTP endpoint to receive branch status updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBranchBody" /> class.
        /// </summary>
        /// <param name="branchName"></param>
        /// <param name="gitBranch"></param>
        /// <param name="persistent"></param>
        /// <param name="status"></param>
        /// <param name="requestReview"></param>
        /// <param name="notifyUrl">
        /// HTTP endpoint to receive branch status updates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateBranchBody(
            string? branchName,
            string? gitBranch,
            bool? persistent,
            global::Supabase.UpdateBranchBodyStatus? status,
            bool? requestReview,
            string? notifyUrl)
        {
            this.BranchName = branchName;
            this.GitBranch = gitBranch;
            this.Persistent = persistent;
            this.Status = status;
            this.RequestReview = requestReview;
            this.NotifyUrl = notifyUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBranchBody" /> class.
        /// </summary>
        public UpdateBranchBody()
        {
        }
    }
}