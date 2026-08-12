
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1UpdateJitAccessConfigResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unavailableReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1UpdateJitAccessConfigResponseVariant2UnavailableReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1UpdateJitAccessConfigResponseVariant2UnavailableReason UnavailableReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1UpdateJitAccessConfigResponseVariant2" /> class.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="unavailableReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1UpdateJitAccessConfigResponseVariant2(
            string state,
            global::Supabase.V1UpdateJitAccessConfigResponseVariant2UnavailableReason unavailableReason)
        {
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.UnavailableReason = unavailableReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1UpdateJitAccessConfigResponseVariant2" /> class.
        /// </summary>
        public V1UpdateJitAccessConfigResponseVariant2()
        {
        }

    }
}