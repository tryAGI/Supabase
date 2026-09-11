
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectAvailableRestoreVersionsResponseOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.GetProjectAvailableRestoreVersionsResponseOutputAvailableVersion> AvailableVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectAvailableRestoreVersionsResponseOutput" /> class.
        /// </summary>
        /// <param name="availableVersions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectAvailableRestoreVersionsResponseOutput(
            global::System.Collections.Generic.IList<global::Supabase.GetProjectAvailableRestoreVersionsResponseOutputAvailableVersion> availableVersions)
        {
            this.AvailableVersions = availableVersions ?? throw new global::System.ArgumentNullException(nameof(availableVersions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectAvailableRestoreVersionsResponseOutput" /> class.
        /// </summary>
        public GetProjectAvailableRestoreVersionsResponseOutput()
        {
        }

    }
}