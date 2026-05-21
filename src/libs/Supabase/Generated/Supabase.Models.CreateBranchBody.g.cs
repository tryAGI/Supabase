
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Example: {"branch_name":"preview-login-page","git_branch":"feature/login-page","persistent":true,"with_data":false,"notify_url":"https://example.com/webhooks/branches"}
    /// </summary>
    public sealed partial class CreateBranchBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_branch")]
        public string? GitBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persistent")]
        public bool? Persistent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desired_instance_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateBranchBodyDesiredInstanceSizeJsonConverter))]
        public global::Supabase.CreateBranchBodyDesiredInstanceSize? DesiredInstanceSize { get; set; }

        /// <summary>
        /// Release channel. If not provided, GA will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateBranchBodyReleaseChannelJsonConverter))]
        public global::Supabase.CreateBranchBodyReleaseChannel? ReleaseChannel { get; set; }

        /// <summary>
        /// Postgres engine version. If not provided, the latest version will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postgres_engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.CreateBranchBodyPostgresEngineJsonConverter))]
        public global::Supabase.CreateBranchBodyPostgresEngine? PostgresEngine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.Dictionary<string, string>? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_data")]
        public bool? WithData { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateBranchBody" /> class.
        /// </summary>
        /// <param name="branchName"></param>
        /// <param name="gitBranch"></param>
        /// <param name="isDefault"></param>
        /// <param name="persistent"></param>
        /// <param name="region"></param>
        /// <param name="desiredInstanceSize"></param>
        /// <param name="releaseChannel">
        /// Release channel. If not provided, GA will be used.
        /// </param>
        /// <param name="postgresEngine">
        /// Postgres engine version. If not provided, the latest version will be used.
        /// </param>
        /// <param name="secrets"></param>
        /// <param name="withData"></param>
        /// <param name="notifyUrl">
        /// HTTP endpoint to receive branch status updates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBranchBody(
            string branchName,
            string? gitBranch,
            bool? isDefault,
            bool? persistent,
            string? region,
            global::Supabase.CreateBranchBodyDesiredInstanceSize? desiredInstanceSize,
            global::Supabase.CreateBranchBodyReleaseChannel? releaseChannel,
            global::Supabase.CreateBranchBodyPostgresEngine? postgresEngine,
            global::System.Collections.Generic.Dictionary<string, string>? secrets,
            bool? withData,
            string? notifyUrl)
        {
            this.BranchName = branchName ?? throw new global::System.ArgumentNullException(nameof(branchName));
            this.GitBranch = gitBranch;
            this.IsDefault = isDefault;
            this.Persistent = persistent;
            this.Region = region;
            this.DesiredInstanceSize = desiredInstanceSize;
            this.ReleaseChannel = releaseChannel;
            this.PostgresEngine = postgresEngine;
            this.Secrets = secrets;
            this.WithData = withData;
            this.NotifyUrl = notifyUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBranchBody" /> class.
        /// </summary>
        public CreateBranchBody()
        {
        }

    }
}