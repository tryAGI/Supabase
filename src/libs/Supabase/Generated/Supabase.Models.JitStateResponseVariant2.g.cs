
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JitStateResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.JitStateResponseVariant2StateJsonConverter))]
        public global::Supabase.JitStateResponseVariant2State State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unavailableReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.JitStateResponseVariant2UnavailableReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.JitStateResponseVariant2UnavailableReason UnavailableReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JitStateResponseVariant2" /> class.
        /// </summary>
        /// <param name="unavailableReason"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JitStateResponseVariant2(
            global::Supabase.JitStateResponseVariant2UnavailableReason unavailableReason,
            global::Supabase.JitStateResponseVariant2State state)
        {
            this.State = state;
            this.UnavailableReason = unavailableReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JitStateResponseVariant2" /> class.
        /// </summary>
        public JitStateResponseVariant2()
        {
        }
    }
}