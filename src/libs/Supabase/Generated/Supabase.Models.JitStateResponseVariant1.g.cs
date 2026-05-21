
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JitStateResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.JitStateResponseVariant1StateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.JitStateResponseVariant1State State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appliedSuccessfully")]
        public bool? AppliedSuccessfully { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JitStateResponseVariant1" /> class.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="appliedSuccessfully"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JitStateResponseVariant1(
            global::Supabase.JitStateResponseVariant1State state,
            bool? appliedSuccessfully)
        {
            this.State = state;
            this.AppliedSuccessfully = appliedSuccessfully;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JitStateResponseVariant1" /> class.
        /// </summary>
        public JitStateResponseVariant1()
        {
        }

    }
}