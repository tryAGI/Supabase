
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectUpgradeEligibilityResponseOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eligible")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Eligible { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_app_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentAppVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_app_version_release_channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Supabase.ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel CurrentAppVersionReleaseChannel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_app_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LatestAppVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_upgrade_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersion> TargetUpgradeVersions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_estimate_hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DurationEstimateHours { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legacy_auth_custom_roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> LegacyAuthCustomRoles { get; set; }

        /// <summary>
        /// Use validation_errors instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objects_to_be_dropped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ObjectsToBeDropped { get; set; }

        /// <summary>
        /// Use validation_errors instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unsupported_extensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> UnsupportedExtensions { get; set; }

        /// <summary>
        /// Use validation_errors instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_defined_objects_in_internal_schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> UserDefinedObjectsInInternalSchemas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.AnyOf<global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant2, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant3, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant5, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant6, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant8, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant10>> ValidationErrors { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Supabase.OneOf<global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant1, global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant2, global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant3, global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant4>> Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseOutput" /> class.
        /// </summary>
        /// <param name="eligible"></param>
        /// <param name="currentAppVersion"></param>
        /// <param name="currentAppVersionReleaseChannel"></param>
        /// <param name="latestAppVersion"></param>
        /// <param name="targetUpgradeVersions"></param>
        /// <param name="durationEstimateHours"></param>
        /// <param name="legacyAuthCustomRoles"></param>
        /// <param name="objectsToBeDropped">
        /// Use validation_errors instead.
        /// </param>
        /// <param name="unsupportedExtensions">
        /// Use validation_errors instead.
        /// </param>
        /// <param name="userDefinedObjectsInInternalSchemas">
        /// Use validation_errors instead.
        /// </param>
        /// <param name="validationErrors"></param>
        /// <param name="warnings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUpgradeEligibilityResponseOutput(
            bool eligible,
            string currentAppVersion,
            global::Supabase.ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel currentAppVersionReleaseChannel,
            string latestAppVersion,
            global::System.Collections.Generic.IList<global::Supabase.ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersion> targetUpgradeVersions,
            double durationEstimateHours,
            global::System.Collections.Generic.IList<string> legacyAuthCustomRoles,
            global::System.Collections.Generic.IList<string> objectsToBeDropped,
            global::System.Collections.Generic.IList<string> unsupportedExtensions,
            global::System.Collections.Generic.IList<string> userDefinedObjectsInInternalSchemas,
            global::System.Collections.Generic.IList<global::Supabase.AnyOf<global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant2, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant3, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant5, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant6, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant8, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9, global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant10>> validationErrors,
            global::System.Collections.Generic.IList<global::Supabase.OneOf<global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant1, global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant2, global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant3, global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant4>> warnings)
        {
            this.Eligible = eligible;
            this.CurrentAppVersion = currentAppVersion ?? throw new global::System.ArgumentNullException(nameof(currentAppVersion));
            this.CurrentAppVersionReleaseChannel = currentAppVersionReleaseChannel;
            this.LatestAppVersion = latestAppVersion ?? throw new global::System.ArgumentNullException(nameof(latestAppVersion));
            this.TargetUpgradeVersions = targetUpgradeVersions ?? throw new global::System.ArgumentNullException(nameof(targetUpgradeVersions));
            this.DurationEstimateHours = durationEstimateHours;
            this.LegacyAuthCustomRoles = legacyAuthCustomRoles ?? throw new global::System.ArgumentNullException(nameof(legacyAuthCustomRoles));
            this.ObjectsToBeDropped = objectsToBeDropped ?? throw new global::System.ArgumentNullException(nameof(objectsToBeDropped));
            this.UnsupportedExtensions = unsupportedExtensions ?? throw new global::System.ArgumentNullException(nameof(unsupportedExtensions));
            this.UserDefinedObjectsInInternalSchemas = userDefinedObjectsInInternalSchemas ?? throw new global::System.ArgumentNullException(nameof(userDefinedObjectsInInternalSchemas));
            this.ValidationErrors = validationErrors ?? throw new global::System.ArgumentNullException(nameof(validationErrors));
            this.Warnings = warnings ?? throw new global::System.ArgumentNullException(nameof(warnings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpgradeEligibilityResponseOutput" /> class.
        /// </summary>
        public ProjectUpgradeEligibilityResponseOutput()
        {
        }

    }
}