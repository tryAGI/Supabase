
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1ProjectAdvisorsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.V1ProjectAdvisorsResponseLint> Lints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ProjectAdvisorsResponse" /> class.
        /// </summary>
        /// <param name="lints"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1ProjectAdvisorsResponse(
            global::System.Collections.Generic.IList<global::Supabase.V1ProjectAdvisorsResponseLint> lints)
        {
            this.Lints = lints ?? throw new global::System.ArgumentNullException(nameof(lints));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ProjectAdvisorsResponse" /> class.
        /// </summary>
        public V1ProjectAdvisorsResponse()
        {
        }
    }
}