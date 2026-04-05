
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1OrganizationSlugResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1OrganizationSlugResponsePlanJsonConverter))]
        public global::Supabase.V1OrganizationSlugResponsePlan? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opt_in_tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.V1OrganizationSlugResponseOptInTag> OptInTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_release_channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.V1OrganizationSlugResponseAllowedReleaseChannel> AllowedReleaseChannels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1OrganizationSlugResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="optInTags"></param>
        /// <param name="allowedReleaseChannels"></param>
        /// <param name="plan"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1OrganizationSlugResponse(
            string id,
            string name,
            global::System.Collections.Generic.IList<global::Supabase.V1OrganizationSlugResponseOptInTag> optInTags,
            global::System.Collections.Generic.IList<global::Supabase.V1OrganizationSlugResponseAllowedReleaseChannel> allowedReleaseChannels,
            global::Supabase.V1OrganizationSlugResponsePlan? plan)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Plan = plan;
            this.OptInTags = optInTags ?? throw new global::System.ArgumentNullException(nameof(optInTags));
            this.AllowedReleaseChannels = allowedReleaseChannels ?? throw new global::System.ArgumentNullException(nameof(allowedReleaseChannels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1OrganizationSlugResponse" /> class.
        /// </summary>
        public V1OrganizationSlugResponse()
        {
        }
    }
}