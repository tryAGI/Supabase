
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListProjectAddonsResponseOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_addons")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseOutputSelectedAddon> SelectedAddons { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_addons")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseOutputAvailableAddon> AvailableAddons { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseOutput" /> class.
        /// </summary>
        /// <param name="selectedAddons"></param>
        /// <param name="availableAddons"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectAddonsResponseOutput(
            global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseOutputSelectedAddon> selectedAddons,
            global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseOutputAvailableAddon> availableAddons)
        {
            this.SelectedAddons = selectedAddons ?? throw new global::System.ArgumentNullException(nameof(selectedAddons));
            this.AvailableAddons = availableAddons ?? throw new global::System.ArgumentNullException(nameof(availableAddons));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectAddonsResponseOutput" /> class.
        /// </summary>
        public ListProjectAddonsResponseOutput()
        {
        }

    }
}