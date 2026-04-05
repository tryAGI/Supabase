
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V1CreateProjectBody
    {
        /// <summary>
        /// Database password
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_pass")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbPass { get; set; }

        /// <summary>
        /// Name of your project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Deprecated: Use `organization_slug` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// Organization slug
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationSlug { get; set; }

        /// <summary>
        /// Subscription Plan is now set on organization level and is ignored in this request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1CreateProjectBodyPlanJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Supabase.V1CreateProjectBodyPlan? Plan { get; set; }

        /// <summary>
        /// Region you want your server to reside in. Use region_selection instead.<br/>
        /// Example: us-east-1
        /// </summary>
        /// <example>us-east-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Supabase.V1CreateProjectBodyRegion? Region { get; set; }

        /// <summary>
        /// Region selection. Only one of region or region_selection can be specified.<br/>
        /// Example: { type: 'smartGroup', code: 'americas' }
        /// </summary>
        /// <example>{ type: 'smartGroup', code: 'americas' }</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.RegionSelectionJsonConverter))]
        public global::Supabase.RegionSelection? RegionSelection { get; set; }

        /// <summary>
        /// This field is deprecated and is ignored in this request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kps_enabled")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? KpsEnabled { get; set; }

        /// <summary>
        /// Desired instance size. Omit this field to always default to the smallest possible size.<br/>
        /// Example: nano
        /// </summary>
        /// <example>nano</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("desired_instance_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.V1CreateProjectBodyDesiredInstanceSizeJsonConverter))]
        public global::Supabase.V1CreateProjectBodyDesiredInstanceSize? DesiredInstanceSize { get; set; }

        /// <summary>
        /// Template URL used to create the project from the CLI.<br/>
        /// Example: https://github.com/supabase/supabase/tree/master/examples/slack-clone/nextjs-slack-clone
        /// </summary>
        /// <example>https://github.com/supabase/supabase/tree/master/examples/slack-clone/nextjs-slack-clone</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_url")]
        public string? TemplateUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1CreateProjectBody" /> class.
        /// </summary>
        /// <param name="dbPass">
        /// Database password
        /// </param>
        /// <param name="name">
        /// Name of your project
        /// </param>
        /// <param name="organizationSlug">
        /// Organization slug
        /// </param>
        /// <param name="regionSelection">
        /// Region selection. Only one of region or region_selection can be specified.<br/>
        /// Example: { type: 'smartGroup', code: 'americas' }
        /// </param>
        /// <param name="desiredInstanceSize">
        /// Desired instance size. Omit this field to always default to the smallest possible size.<br/>
        /// Example: nano
        /// </param>
        /// <param name="templateUrl">
        /// Template URL used to create the project from the CLI.<br/>
        /// Example: https://github.com/supabase/supabase/tree/master/examples/slack-clone/nextjs-slack-clone
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1CreateProjectBody(
            string dbPass,
            string name,
            string organizationSlug,
            global::Supabase.RegionSelection? regionSelection,
            global::Supabase.V1CreateProjectBodyDesiredInstanceSize? desiredInstanceSize,
            string? templateUrl)
        {
            this.DbPass = dbPass ?? throw new global::System.ArgumentNullException(nameof(dbPass));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrganizationSlug = organizationSlug ?? throw new global::System.ArgumentNullException(nameof(organizationSlug));
            this.RegionSelection = regionSelection;
            this.DesiredInstanceSize = desiredInstanceSize;
            this.TemplateUrl = templateUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1CreateProjectBody" /> class.
        /// </summary>
        public V1CreateProjectBody()
        {
        }
    }
}