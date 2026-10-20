
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RegionsInfoV1Output
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommendations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.RegionsInfoV1OutputRecommendations Recommendations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.RegionsInfoV1OutputAll All { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoV1Output" /> class.
        /// </summary>
        /// <param name="recommendations"></param>
        /// <param name="all"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionsInfoV1Output(
            global::Supabase.RegionsInfoV1OutputRecommendations recommendations,
            global::Supabase.RegionsInfoV1OutputAll all)
        {
            this.Recommendations = recommendations ?? throw new global::System.ArgumentNullException(nameof(recommendations));
            this.All = all ?? throw new global::System.ArgumentNullException(nameof(all));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionsInfoV1Output" /> class.
        /// </summary>
        public RegionsInfoV1Output()
        {
        }

    }
}