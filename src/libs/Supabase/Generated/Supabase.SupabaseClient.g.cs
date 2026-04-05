
#nullable enable

namespace Supabase
{
    /// <summary>
    /// Supabase API generated from the OpenAPI specification.Visit [https://supabase.com/docs](https://supabase.com/docs) for a complete documentation.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class SupabaseClient : global::Supabase.ISupabaseClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.supabase.com";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Supabase.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Supabase.JsonConverters.BranchDetailResponseStatusJsonConverter(),
                    new global::Supabase.JsonConverters.BranchDetailResponseStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateBranchBodyStatusJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateBranchBodyStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.BranchResponseStatusJsonConverter(),
                    new global::Supabase.JsonConverters.BranchResponseStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.BranchResponsePreviewProjectStatusJsonConverter(),
                    new global::Supabase.JsonConverters.BranchResponsePreviewProjectStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.BranchDeleteResponseMessageJsonConverter(),
                    new global::Supabase.JsonConverters.BranchDeleteResponseMessageNullableJsonConverter(),
                    new global::Supabase.JsonConverters.BranchUpdateResponseMessageJsonConverter(),
                    new global::Supabase.JsonConverters.BranchUpdateResponseMessageNullableJsonConverter(),
                    new global::Supabase.JsonConverters.BranchRestoreResponseMessageJsonConverter(),
                    new global::Supabase.JsonConverters.BranchRestoreResponseMessageNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1ListProjectsPaginatedResponseProjectInfraComputeSizeJsonConverter(),
                    new global::Supabase.JsonConverters.V1ListProjectsPaginatedResponseProjectInfraComputeSizeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1ProjectWithDatabaseResponseStatusJsonConverter(),
                    new global::Supabase.JsonConverters.V1ProjectWithDatabaseResponseStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1CreateProjectBodyPlanJsonConverter(),
                    new global::Supabase.JsonConverters.V1CreateProjectBodyPlanNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1CreateProjectBodyRegionJsonConverter(),
                    new global::Supabase.JsonConverters.V1CreateProjectBodyRegionNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant1TypeJsonConverter(),
                    new global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant1TypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant1CodeJsonConverter(),
                    new global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant1CodeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant2TypeJsonConverter(),
                    new global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant2TypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant2CodeJsonConverter(),
                    new global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant2CodeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1CreateProjectBodyDesiredInstanceSizeJsonConverter(),
                    new global::Supabase.JsonConverters.V1CreateProjectBodyDesiredInstanceSizeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1ProjectResponseStatusJsonConverter(),
                    new global::Supabase.JsonConverters.V1ProjectResponseStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoRecommendationsSmartGroupCodeJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoRecommendationsSmartGroupCodeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoRecommendationsSmartGroupTypeJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoRecommendationsSmartGroupTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemCodeJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemCodeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemTypeJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemProviderJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemProviderNullableJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemStatusJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoAllSmartGroupItemCodeJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoAllSmartGroupItemCodeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoAllSmartGroupItemTypeJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoAllSmartGroupItemTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoAllSpecificItemCodeJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoAllSpecificItemCodeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoAllSpecificItemTypeJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoAllSpecificItemTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoAllSpecificItemProviderJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoAllSpecificItemProviderNullableJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoAllSpecificItemStatusJsonConverter(),
                    new global::Supabase.JsonConverters.RegionsInfoAllSpecificItemStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.OAuthTokenBodyGrantTypeJsonConverter(),
                    new global::Supabase.JsonConverters.OAuthTokenBodyGrantTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.OAuthTokenResponseTokenTypeJsonConverter(),
                    new global::Supabase.JsonConverters.OAuthTokenResponseTokenTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.SnippetListDataItemTypeJsonConverter(),
                    new global::Supabase.JsonConverters.SnippetListDataItemTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.SnippetListDataItemVisibilityJsonConverter(),
                    new global::Supabase.JsonConverters.SnippetListDataItemVisibilityNullableJsonConverter(),
                    new global::Supabase.JsonConverters.SnippetResponseTypeJsonConverter(),
                    new global::Supabase.JsonConverters.SnippetResponseTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.SnippetResponseVisibilityJsonConverter(),
                    new global::Supabase.JsonConverters.SnippetResponseVisibilityNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListActionRunResponseItemRunStepNameJsonConverter(),
                    new global::Supabase.JsonConverters.ListActionRunResponseItemRunStepNameNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListActionRunResponseItemRunStepStatusJsonConverter(),
                    new global::Supabase.JsonConverters.ListActionRunResponseItemRunStepStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ActionRunResponseRunStepNameJsonConverter(),
                    new global::Supabase.JsonConverters.ActionRunResponseRunStepNameNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ActionRunResponseRunStepStatusJsonConverter(),
                    new global::Supabase.JsonConverters.ActionRunResponseRunStepStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusBodyCloneJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusBodyCloneNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusBodyPullJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusBodyPullNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusBodyHealthJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusBodyHealthNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusBodyConfigureJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusBodyConfigureNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusBodyMigrateJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusBodyMigrateNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusBodySeedJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusBodySeedNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusBodyDeployJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusBodyDeployNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusResponseMessageJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateRunStatusResponseMessageNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ApiKeyResponseTypeJsonConverter(),
                    new global::Supabase.JsonConverters.ApiKeyResponseTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateApiKeyBodyTypeJsonConverter(),
                    new global::Supabase.JsonConverters.CreateApiKeyBodyTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateBranchBodyDesiredInstanceSizeJsonConverter(),
                    new global::Supabase.JsonConverters.CreateBranchBodyDesiredInstanceSizeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateBranchBodyReleaseChannelJsonConverter(),
                    new global::Supabase.JsonConverters.CreateBranchBodyReleaseChannelNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateBranchBodyPostgresEngineJsonConverter(),
                    new global::Supabase.JsonConverters.CreateBranchBodyPostgresEngineNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateCustomHostnameResponseStatusJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateCustomHostnameResponseStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.JitAccessRequestRequestStateJsonConverter(),
                    new global::Supabase.JsonConverters.JitAccessRequestRequestStateNullableJsonConverter(),
                    new global::Supabase.JsonConverters.NetworkRestrictionsResponseEntitlementJsonConverter(),
                    new global::Supabase.JsonConverters.NetworkRestrictionsResponseEntitlementNullableJsonConverter(),
                    new global::Supabase.JsonConverters.NetworkRestrictionsResponseStatusJsonConverter(),
                    new global::Supabase.JsonConverters.NetworkRestrictionsResponseStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseEntitlementJsonConverter(),
                    new global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseEntitlementNullableJsonConverter(),
                    new global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseConfigDbAllowedCidrTypeJsonConverter(),
                    new global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseConfigDbAllowedCidrTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseOldConfigDbAllowedCidrTypeJsonConverter(),
                    new global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseOldConfigDbAllowedCidrTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseStatusJsonConverter(),
                    new global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.VanitySubdomainConfigResponseStatusJsonConverter(),
                    new global::Supabase.JsonConverters.VanitySubdomainConfigResponseStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpgradeDatabaseBodyReleaseChannelJsonConverter(),
                    new global::Supabase.JsonConverters.UpgradeDatabaseBodyReleaseChannelNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannelJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannelNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersionJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersionNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannelJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannelNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant1TypeJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant1TypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant2TypeJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant2TypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant3TypeJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant3TypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant4TypeJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant4TypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant5TypeJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant5TypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant6TypeJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant6TypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant7TypeJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant7TypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjTypeJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant8TypeJsonConverter(),
                    new global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant8TypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusErrorJsonConverter(),
                    new global::Supabase.JsonConverters.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusErrorNullableJsonConverter(),
                    new global::Supabase.JsonConverters.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgressJsonConverter(),
                    new global::Supabase.JsonConverters.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgressNullableJsonConverter(),
                    new global::Supabase.JsonConverters.SetUpReadReplicaBodyReadReplicaRegionJsonConverter(),
                    new global::Supabase.JsonConverters.SetUpReadReplicaBodyReadReplicaRegionNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1ServiceHealthResponseNameJsonConverter(),
                    new global::Supabase.JsonConverters.V1ServiceHealthResponseNameNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1ServiceHealthResponseStatusJsonConverter(),
                    new global::Supabase.JsonConverters.V1ServiceHealthResponseStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1ServiceHealthResponseInfoVariant1NameJsonConverter(),
                    new global::Supabase.JsonConverters.V1ServiceHealthResponseInfoVariant1NameNullableJsonConverter(),
                    new global::Supabase.JsonConverters.SigningKeyResponseAlgorithmJsonConverter(),
                    new global::Supabase.JsonConverters.SigningKeyResponseAlgorithmNullableJsonConverter(),
                    new global::Supabase.JsonConverters.SigningKeyResponseStatusJsonConverter(),
                    new global::Supabase.JsonConverters.SigningKeyResponseStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyAlgorithmJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyAlgorithmNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyStatusJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1UseJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1UseNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1KeyOpJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1KeyOpNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1KtyJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1KtyNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1AlgJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1AlgNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1EJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1ENullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2UseJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2UseNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2KeyOpJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2KeyOpNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2KtyJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2KtyNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2AlgJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2AlgNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2CrvJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2CrvNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3UseJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3UseNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3KeyOpJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3KeyOpNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3KtyJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3KtyNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3AlgJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3AlgNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3CrvJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3CrvNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4UseJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4UseNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4KeyOpJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4KeyOpNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4KtyJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4KtyNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4AlgJsonConverter(),
                    new global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4AlgNullableJsonConverter(),
                    new global::Supabase.JsonConverters.SigningKeysResponseKeyAlgorithmJsonConverter(),
                    new global::Supabase.JsonConverters.SigningKeysResponseKeyAlgorithmNullableJsonConverter(),
                    new global::Supabase.JsonConverters.SigningKeysResponseKeyStatusJsonConverter(),
                    new global::Supabase.JsonConverters.SigningKeysResponseKeyStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateSigningKeyBodyStatusJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateSigningKeyBodyStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.AuthConfigResponseDbMaxPoolSizeUnitJsonConverter(),
                    new global::Supabase.JsonConverters.AuthConfigResponseDbMaxPoolSizeUnitNullableJsonConverter(),
                    new global::Supabase.JsonConverters.AuthConfigResponsePasswordRequiredCharactersJsonConverter(),
                    new global::Supabase.JsonConverters.AuthConfigResponsePasswordRequiredCharactersNullableJsonConverter(),
                    new global::Supabase.JsonConverters.AuthConfigResponseSecurityCaptchaProviderJsonConverter(),
                    new global::Supabase.JsonConverters.AuthConfigResponseSecurityCaptchaProviderNullableJsonConverter(),
                    new global::Supabase.JsonConverters.AuthConfigResponseSmsProviderJsonConverter(),
                    new global::Supabase.JsonConverters.AuthConfigResponseSmsProviderNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateAuthConfigBodySecurityCaptchaProviderJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateAuthConfigBodySecurityCaptchaProviderNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateAuthConfigBodyPasswordRequiredCharactersJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateAuthConfigBodyPasswordRequiredCharactersNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateAuthConfigBodySmsProviderJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateAuthConfigBodySmsProviderNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateAuthConfigBodyDbMaxPoolSizeUnitJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateAuthConfigBodyDbMaxPoolSizeUnitNullableJsonConverter(),
                    new global::Supabase.JsonConverters.GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannelJsonConverter(),
                    new global::Supabase.JsonConverters.GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannelNullableJsonConverter(),
                    new global::Supabase.JsonConverters.GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngineJsonConverter(),
                    new global::Supabase.JsonConverters.GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngineNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonTypeJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant1JsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant1NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant2JsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant2NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant3JsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant3NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant4JsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant4NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant5JsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant5NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant6JsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant6NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant7JsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant7NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantPriceTypeJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantPriceTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantPriceIntervalJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantPriceIntervalNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonTypeJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant1JsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant1NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant2JsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant2NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant3JsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant3NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant4JsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant4NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant5JsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant5NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant6JsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant6NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant7JsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant7NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantPriceTypeJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantPriceTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantPriceIntervalJsonConverter(),
                    new global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantPriceIntervalNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant1JsonConverter(),
                    new global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant1NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant2JsonConverter(),
                    new global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant2NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant3JsonConverter(),
                    new global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant3NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant4JsonConverter(),
                    new global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant4NullableJsonConverter(),
                    new global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonTypeJsonConverter(),
                    new global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintNameJsonConverter(),
                    new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintNameNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintLevelJsonConverter(),
                    new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintLevelNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintFacingJsonConverter(),
                    new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintFacingNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintCategorieJsonConverter(),
                    new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintCategorieNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintMetadataTypeJsonConverter(),
                    new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintMetadataTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.DeleteRolesResponseMessageJsonConverter(),
                    new global::Supabase.JsonConverters.DeleteRolesResponseMessageNullableJsonConverter(),
                    new global::Supabase.JsonConverters.FunctionResponseStatusJsonConverter(),
                    new global::Supabase.JsonConverters.FunctionResponseStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.BulkUpdateFunctionBodyItemStatusJsonConverter(),
                    new global::Supabase.JsonConverters.BulkUpdateFunctionBodyItemStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.BulkUpdateFunctionResponseFunctionStatusJsonConverter(),
                    new global::Supabase.JsonConverters.BulkUpdateFunctionResponseFunctionStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.DeployFunctionResponseStatusJsonConverter(),
                    new global::Supabase.JsonConverters.DeployFunctionResponseStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.FunctionSlugResponseStatusJsonConverter(),
                    new global::Supabase.JsonConverters.FunctionSlugResponseStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.DiskResponseAttributesVariant1TypeJsonConverter(),
                    new global::Supabase.JsonConverters.DiskResponseAttributesVariant1TypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.DiskResponseAttributesVariant2TypeJsonConverter(),
                    new global::Supabase.JsonConverters.DiskResponseAttributesVariant2TypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.DiskRequestBodyAttributesVariant1TypeJsonConverter(),
                    new global::Supabase.JsonConverters.DiskRequestBodyAttributesVariant1TypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.DiskRequestBodyAttributesVariant2TypeJsonConverter(),
                    new global::Supabase.JsonConverters.DiskRequestBodyAttributesVariant2TypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.StorageConfigResponseExternalUpstreamTargetJsonConverter(),
                    new global::Supabase.JsonConverters.StorageConfigResponseExternalUpstreamTargetNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateStorageConfigBodyExternalUpstreamTargetJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateStorageConfigBodyExternalUpstreamTargetNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1PgbouncerConfigResponsePoolModeJsonConverter(),
                    new global::Supabase.JsonConverters.V1PgbouncerConfigResponsePoolModeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.SupavisorConfigResponseDatabaseTypeJsonConverter(),
                    new global::Supabase.JsonConverters.SupavisorConfigResponseDatabaseTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.SupavisorConfigResponsePoolModeJsonConverter(),
                    new global::Supabase.JsonConverters.SupavisorConfigResponsePoolModeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateSupavisorConfigBodyPoolModeJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateSupavisorConfigBodyPoolModeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.PostgresConfigResponseSessionReplicationRoleJsonConverter(),
                    new global::Supabase.JsonConverters.PostgresConfigResponseSessionReplicationRoleNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdatePostgresConfigBodySessionReplicationRoleJsonConverter(),
                    new global::Supabase.JsonConverters.UpdatePostgresConfigBodySessionReplicationRoleNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateProviderBodyTypeJsonConverter(),
                    new global::Supabase.JsonConverters.CreateProviderBodyTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateProviderBodyNameIdFormatJsonConverter(),
                    new global::Supabase.JsonConverters.CreateProviderBodyNameIdFormatNullableJsonConverter(),
                    new global::Supabase.JsonConverters.CreateProviderResponseSamlNameIdFormatJsonConverter(),
                    new global::Supabase.JsonConverters.CreateProviderResponseSamlNameIdFormatNullableJsonConverter(),
                    new global::Supabase.JsonConverters.ListProvidersResponseItemSamlNameIdFormatJsonConverter(),
                    new global::Supabase.JsonConverters.ListProvidersResponseItemSamlNameIdFormatNullableJsonConverter(),
                    new global::Supabase.JsonConverters.GetProviderResponseSamlNameIdFormatJsonConverter(),
                    new global::Supabase.JsonConverters.GetProviderResponseSamlNameIdFormatNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateProviderBodyNameIdFormatJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateProviderBodyNameIdFormatNullableJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateProviderResponseSamlNameIdFormatJsonConverter(),
                    new global::Supabase.JsonConverters.UpdateProviderResponseSamlNameIdFormatNullableJsonConverter(),
                    new global::Supabase.JsonConverters.DeleteProviderResponseSamlNameIdFormatJsonConverter(),
                    new global::Supabase.JsonConverters.DeleteProviderResponseSamlNameIdFormatNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1BackupsResponseBackupStatusJsonConverter(),
                    new global::Supabase.JsonConverters.V1BackupsResponseBackupStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1RestorePointResponseStatusJsonConverter(),
                    new global::Supabase.JsonConverters.V1RestorePointResponseStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1OrganizationSlugResponsePlanJsonConverter(),
                    new global::Supabase.JsonConverters.V1OrganizationSlugResponsePlanNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1OrganizationSlugResponseOptInTagJsonConverter(),
                    new global::Supabase.JsonConverters.V1OrganizationSlugResponseOptInTagNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1OrganizationSlugResponseAllowedReleaseChannelJsonConverter(),
                    new global::Supabase.JsonConverters.V1OrganizationSlugResponseAllowedReleaseChannelNullableJsonConverter(),
                    new global::Supabase.JsonConverters.OrganizationProjectClaimResponsePreviewSourceSubscriptionPlanJsonConverter(),
                    new global::Supabase.JsonConverters.OrganizationProjectClaimResponsePreviewSourceSubscriptionPlanNullableJsonConverter(),
                    new global::Supabase.JsonConverters.OrganizationProjectClaimResponsePreviewTargetSubscriptionPlanJsonConverter(),
                    new global::Supabase.JsonConverters.OrganizationProjectClaimResponsePreviewTargetSubscriptionPlanNullableJsonConverter(),
                    new global::Supabase.JsonConverters.OrganizationProjectsResponseProjectStatusJsonConverter(),
                    new global::Supabase.JsonConverters.OrganizationProjectsResponseProjectStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseInfraComputeSizeJsonConverter(),
                    new global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseInfraComputeSizeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseStatusJsonConverter(),
                    new global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseStatusNullableJsonConverter(),
                    new global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseTypeJsonConverter(),
                    new global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseDiskTypeJsonConverter(),
                    new global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseDiskTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1GetAvailableRegionsContinentJsonConverter(),
                    new global::Supabase.JsonConverters.V1GetAvailableRegionsContinentNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1GetAvailableRegionsDesiredInstanceSizeJsonConverter(),
                    new global::Supabase.JsonConverters.V1GetAvailableRegionsDesiredInstanceSizeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1AuthorizeUserResponseTypeJsonConverter(),
                    new global::Supabase.JsonConverters.V1AuthorizeUserResponseTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1AuthorizeUserCodeChallengeMethodJsonConverter(),
                    new global::Supabase.JsonConverters.V1AuthorizeUserCodeChallengeMethodNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1OauthAuthorizeProjectClaimResponseTypeJsonConverter(),
                    new global::Supabase.JsonConverters.V1OauthAuthorizeProjectClaimResponseTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1OauthAuthorizeProjectClaimCodeChallengeMethodJsonConverter(),
                    new global::Supabase.JsonConverters.V1OauthAuthorizeProjectClaimCodeChallengeMethodNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1ListAllSnippetsSortByJsonConverter(),
                    new global::Supabase.JsonConverters.V1ListAllSnippetsSortByNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1ListAllSnippetsSortOrderJsonConverter(),
                    new global::Supabase.JsonConverters.V1ListAllSnippetsSortOrderNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1GetServicesHealthServiceJsonConverter(),
                    new global::Supabase.JsonConverters.V1GetServicesHealthServiceNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant1JsonConverter(),
                    new global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant1NullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant2JsonConverter(),
                    new global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant2NullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant3JsonConverter(),
                    new global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant3NullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant4JsonConverter(),
                    new global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant4NullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1GetSecurityAdvisorsLintTypeJsonConverter(),
                    new global::Supabase.JsonConverters.V1GetSecurityAdvisorsLintTypeNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1GetProjectUsageApiCountIntervalJsonConverter(),
                    new global::Supabase.JsonConverters.V1GetProjectUsageApiCountIntervalNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1GetProjectFunctionCombinedStatsIntervalJsonConverter(),
                    new global::Supabase.JsonConverters.V1GetProjectFunctionCombinedStatsIntervalNullableJsonConverter(),
                    new global::Supabase.JsonConverters.V1GetAllProjectsForOrganizationSortJsonConverter(),
                    new global::Supabase.JsonConverters.V1GetAllProjectsForOrganizationSortNullableJsonConverter(),
                    new global::Supabase.JsonConverters.RegionSelectionJsonConverter(),
                    new global::Supabase.JsonConverters.PrivateJwkJsonConverter(),
                    new global::Supabase.JsonConverters.Attributes2JsonConverter(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant1, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant2, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant3, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant4, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant5, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant6, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant7, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant8>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.V1ServiceHealthResponseInfoVariant1, global::Supabase.V1ServiceHealthResponseInfoVariant2, global::Supabase.V1ServiceHealthResponseInfoVariant3>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant1?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant2?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant3?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant4?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant5?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant6?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant7?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant1?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant2?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant3?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant4?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant5?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant6?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant7?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.ApplyProjectAddonBodyAddonVariantVariant1?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant3?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant4?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<string, global::Supabase.AnalyticsResponseError>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<string, global::Supabase.V1GetUsageApiCountResponseError>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<string, global::Supabase.V1GetUsageApiRequestsCountResponseError>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.DiskResponseAttributesVariant1, global::Supabase.DiskResponseAttributesVariant2>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<object, double?, string, bool?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<object, double?, string, bool?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<object, double?, string, bool?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<object, double?, string, bool?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<object, double?, string, bool?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<object, double?, string, bool?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<object, double?, string, bool?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>(),
                    new global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.V1RemoveProjectAddonAddonVariantVariant1?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant2?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant3?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant4?>(),
                    new global::Supabase.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// Analytics related endpoints
        /// </summary>
        public AnalyticsClient Analytics => new AnalyticsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Auth related endpoints
        /// </summary>
        public AuthClient Auth => new AuthClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Billing related endpoints
        /// </summary>
        public BillingClient Billing => new BillingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Database related endpoints
        /// </summary>
        public DatabaseClient Database => new DatabaseClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Domains related endpoints
        /// </summary>
        public DomainsClient Domains => new DomainsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Edge related endpoints
        /// </summary>
        public EdgeFunctionsClient EdgeFunctions => new EdgeFunctionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Environments related endpoints
        /// </summary>
        public EnvironmentsClient Environments => new EnvironmentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// OAuth related endpoints
        /// </summary>
        public OAuthClient OAuth => new OAuthClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Organizations related endpoints
        /// </summary>
        public OrganizationsClient Organizations => new OrganizationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Projects related endpoints
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClient Realtime => new RealtimeClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Rest related endpoints
        /// </summary>
        public RestClient Rest => new RestClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Secrets related endpoints
        /// </summary>
        public SecretsClient Secrets => new SecretsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Visit [https://supabase.github.io/storage/](https://supabase.github.io/storage/) for complete documentation.
        /// </summary>
        public StorageClient Storage => new StorageClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the SupabaseClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public SupabaseClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Supabase.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Supabase.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}