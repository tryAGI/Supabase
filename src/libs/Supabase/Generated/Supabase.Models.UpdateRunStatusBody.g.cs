
#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRunStatusBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyCloneJsonConverter))]
        public global::Supabase.UpdateRunStatusBodyClone? Clone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyPullJsonConverter))]
        public global::Supabase.UpdateRunStatusBodyPull? Pull { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyHealthJsonConverter))]
        public global::Supabase.UpdateRunStatusBodyHealth? Health { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configure")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyConfigureJsonConverter))]
        public global::Supabase.UpdateRunStatusBodyConfigure? Configure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("migrate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyMigrateJsonConverter))]
        public global::Supabase.UpdateRunStatusBodyMigrate? Migrate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.UpdateRunStatusBodySeedJsonConverter))]
        public global::Supabase.UpdateRunStatusBodySeed? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyDeployJsonConverter))]
        public global::Supabase.UpdateRunStatusBodyDeploy? Deploy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRunStatusBody" /> class.
        /// </summary>
        /// <param name="clone"></param>
        /// <param name="pull"></param>
        /// <param name="health"></param>
        /// <param name="configure"></param>
        /// <param name="migrate"></param>
        /// <param name="seed"></param>
        /// <param name="deploy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRunStatusBody(
            global::Supabase.UpdateRunStatusBodyClone? clone,
            global::Supabase.UpdateRunStatusBodyPull? pull,
            global::Supabase.UpdateRunStatusBodyHealth? health,
            global::Supabase.UpdateRunStatusBodyConfigure? configure,
            global::Supabase.UpdateRunStatusBodyMigrate? migrate,
            global::Supabase.UpdateRunStatusBodySeed? seed,
            global::Supabase.UpdateRunStatusBodyDeploy? deploy)
        {
            this.Clone = clone;
            this.Pull = pull;
            this.Health = health;
            this.Configure = configure;
            this.Migrate = migrate;
            this.Seed = seed;
            this.Deploy = deploy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRunStatusBody" /> class.
        /// </summary>
        public UpdateRunStatusBody()
        {
        }
    }
}