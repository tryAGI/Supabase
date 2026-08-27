
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class V1GetJitAccessConfigResponseVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1GetJitAccessConfigResponseVariant1StateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.V1GetJitAccessConfigResponseVariant1State State { get; set; }

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
        /// Initializes a new instance of the <see cref="V1GetJitAccessConfigResponseVariant1" /> class.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="appliedSuccessfully"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1GetJitAccessConfigResponseVariant1(
            global::Supabase.V1GetJitAccessConfigResponseVariant1State state,
            bool? appliedSuccessfully)
        {
            this.State = state;
            this.AppliedSuccessfully = appliedSuccessfully;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1GetJitAccessConfigResponseVariant1" /> class.
        /// </summary>
        public V1GetJitAccessConfigResponseVariant1()
        {
        }

    }
}