
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BulkUpdateFunctionResponseOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.BulkUpdateFunctionResponseOutputFunction> Functions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateFunctionResponseOutput" /> class.
        /// </summary>
        /// <param name="functions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateFunctionResponseOutput(
            global::System.Collections.Generic.IList<global::Supabase.BulkUpdateFunctionResponseOutputFunction> functions)
        {
            this.Functions = functions ?? throw new global::System.ArgumentNullException(nameof(functions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateFunctionResponseOutput" /> class.
        /// </summary>
        public BulkUpdateFunctionResponseOutput()
        {
        }

    }
}