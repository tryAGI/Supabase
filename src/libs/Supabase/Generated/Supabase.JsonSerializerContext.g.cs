
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Supabase
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Supabase.JsonConverters.BranchDetailResponseStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.BranchDetailResponseStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateBranchBodyStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateBranchBodyStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.BranchResponseStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.BranchResponseStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.BranchResponsePreviewProjectStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.BranchResponsePreviewProjectStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.BranchDeleteResponseMessageJsonConverter),

            typeof(global::Supabase.JsonConverters.BranchDeleteResponseMessageNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.BranchUpdateResponseMessageJsonConverter),

            typeof(global::Supabase.JsonConverters.BranchUpdateResponseMessageNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.BranchRestoreResponseMessageJsonConverter),

            typeof(global::Supabase.JsonConverters.BranchRestoreResponseMessageNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ProjectWithDatabaseResponseStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ProjectWithDatabaseResponseStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1CreateProjectBodyPlanJsonConverter),

            typeof(global::Supabase.JsonConverters.V1CreateProjectBodyPlanNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionJsonConverter),

            typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant1TypeJsonConverter),

            typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant1TypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant1CodeJsonConverter),

            typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant1CodeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant2TypeJsonConverter),

            typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant2TypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant2CodeJsonConverter),

            typeof(global::Supabase.JsonConverters.V1CreateProjectBodyRegionSelectionVariant2CodeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1CreateProjectBodyDesiredInstanceSizeJsonConverter),

            typeof(global::Supabase.JsonConverters.V1CreateProjectBodyDesiredInstanceSizeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ProjectResponseStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ProjectResponseStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoRecommendationsSmartGroupCodeJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoRecommendationsSmartGroupCodeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoRecommendationsSmartGroupTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoRecommendationsSmartGroupTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemCodeJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemCodeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemProviderJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemProviderNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoRecommendationsSpecificItemStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoAllSmartGroupItemCodeJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoAllSmartGroupItemCodeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoAllSmartGroupItemTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoAllSmartGroupItemTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoAllSpecificItemCodeJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoAllSpecificItemCodeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoAllSpecificItemTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoAllSpecificItemTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoAllSpecificItemProviderJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoAllSpecificItemProviderNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoAllSpecificItemStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionsInfoAllSpecificItemStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.OAuthTokenBodyGrantTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.OAuthTokenBodyGrantTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.OAuthTokenResponseTokenTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.OAuthTokenResponseTokenTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.SnippetListDataItemTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.SnippetListDataItemTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.SnippetListDataItemVisibilityJsonConverter),

            typeof(global::Supabase.JsonConverters.SnippetListDataItemVisibilityNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.SnippetResponseTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.SnippetResponseTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.SnippetResponseVisibilityJsonConverter),

            typeof(global::Supabase.JsonConverters.SnippetResponseVisibilityNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListActionRunResponseItemRunStepNameJsonConverter),

            typeof(global::Supabase.JsonConverters.ListActionRunResponseItemRunStepNameNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListActionRunResponseItemRunStepStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.ListActionRunResponseItemRunStepStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ActionRunResponseRunStepNameJsonConverter),

            typeof(global::Supabase.JsonConverters.ActionRunResponseRunStepNameNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ActionRunResponseRunStepStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.ActionRunResponseRunStepStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyCloneJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyCloneNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyPullJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyPullNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyHealthJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyHealthNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyConfigureJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyConfigureNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyMigrateJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyMigrateNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusBodySeedJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusBodySeedNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyDeployJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusBodyDeployNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusResponseMessageJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateRunStatusResponseMessageNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ApiKeyResponseTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.ApiKeyResponseTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateApiKeyBodyTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateApiKeyBodyTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateBranchBodyDesiredInstanceSizeJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateBranchBodyDesiredInstanceSizeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateBranchBodyReleaseChannelJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateBranchBodyReleaseChannelNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateBranchBodyPostgresEngineJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateBranchBodyPostgresEngineNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateCustomHostnameResponseStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateCustomHostnameResponseStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.JitStateResponseVariant1StateJsonConverter),

            typeof(global::Supabase.JsonConverters.JitStateResponseVariant1StateNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.JitStateResponseVariant2StateJsonConverter),

            typeof(global::Supabase.JsonConverters.JitStateResponseVariant2StateNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.JitStateResponseVariant2UnavailableReasonJsonConverter),

            typeof(global::Supabase.JsonConverters.JitStateResponseVariant2UnavailableReasonNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.JitAccessRequestRequestStateJsonConverter),

            typeof(global::Supabase.JsonConverters.JitAccessRequestRequestStateNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.NetworkRestrictionsResponseEntitlementJsonConverter),

            typeof(global::Supabase.JsonConverters.NetworkRestrictionsResponseEntitlementNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.NetworkRestrictionsResponseStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.NetworkRestrictionsResponseStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseEntitlementJsonConverter),

            typeof(global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseEntitlementNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseConfigDbAllowedCidrTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseConfigDbAllowedCidrTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseOldConfigDbAllowedCidrTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseOldConfigDbAllowedCidrTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.NetworkRestrictionsV2ResponseStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.VanitySubdomainConfigResponseStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.VanitySubdomainConfigResponseStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpgradeDatabaseBodyReleaseChannelJsonConverter),

            typeof(global::Supabase.JsonConverters.UpgradeDatabaseBodyReleaseChannelNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannelJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannelNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersionJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersionNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannelJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannelNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant1TypeJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant1TypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant2TypeJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant2TypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant3TypeJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant3TypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant4TypeJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant4TypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant5TypeJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant5TypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant6TypeJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant6TypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant7TypeJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant7TypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant8TypeJsonConverter),

            typeof(global::Supabase.JsonConverters.ProjectUpgradeEligibilityResponseValidationErrorVariant8TypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusErrorJsonConverter),

            typeof(global::Supabase.JsonConverters.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusErrorNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgressJsonConverter),

            typeof(global::Supabase.JsonConverters.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgressNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.SetUpReadReplicaBodyReadReplicaRegionJsonConverter),

            typeof(global::Supabase.JsonConverters.SetUpReadReplicaBodyReadReplicaRegionNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ServiceHealthResponseNameJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ServiceHealthResponseNameNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ServiceHealthResponseStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ServiceHealthResponseStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ServiceHealthResponseInfoVariant1NameJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ServiceHealthResponseInfoVariant1NameNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.SigningKeyResponseAlgorithmJsonConverter),

            typeof(global::Supabase.JsonConverters.SigningKeyResponseAlgorithmNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.SigningKeyResponseStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.SigningKeyResponseStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyAlgorithmJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyAlgorithmNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1UseJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1UseNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1KeyOpJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1KeyOpNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1KtyJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1KtyNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1AlgJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1AlgNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1EJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant1ENullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2UseJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2UseNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2KeyOpJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2KeyOpNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2KtyJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2KtyNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2AlgJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2AlgNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2CrvJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant2CrvNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3UseJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3UseNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3KeyOpJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3KeyOpNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3KtyJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3KtyNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3AlgJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3AlgNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3CrvJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant3CrvNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4UseJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4UseNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4KeyOpJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4KeyOpNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4KtyJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4KtyNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4AlgJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateSigningKeyBodyPrivateJwkVariant4AlgNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.SigningKeysResponseKeyAlgorithmJsonConverter),

            typeof(global::Supabase.JsonConverters.SigningKeysResponseKeyAlgorithmNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.SigningKeysResponseKeyStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.SigningKeysResponseKeyStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateSigningKeyBodyStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateSigningKeyBodyStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.AuthConfigResponseDbMaxPoolSizeUnitJsonConverter),

            typeof(global::Supabase.JsonConverters.AuthConfigResponseDbMaxPoolSizeUnitNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.AuthConfigResponsePasswordRequiredCharactersJsonConverter),

            typeof(global::Supabase.JsonConverters.AuthConfigResponsePasswordRequiredCharactersNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.AuthConfigResponseSecurityCaptchaProviderJsonConverter),

            typeof(global::Supabase.JsonConverters.AuthConfigResponseSecurityCaptchaProviderNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.AuthConfigResponseSmsProviderJsonConverter),

            typeof(global::Supabase.JsonConverters.AuthConfigResponseSmsProviderNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateAuthConfigBodySecurityCaptchaProviderJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateAuthConfigBodySecurityCaptchaProviderNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateAuthConfigBodyPasswordRequiredCharactersJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateAuthConfigBodyPasswordRequiredCharactersNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateAuthConfigBodySmsProviderJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateAuthConfigBodySmsProviderNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateAuthConfigBodyDbMaxPoolSizeUnitJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateAuthConfigBodyDbMaxPoolSizeUnitNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannelJsonConverter),

            typeof(global::Supabase.JsonConverters.GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannelNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngineJsonConverter),

            typeof(global::Supabase.JsonConverters.GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngineNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant1JsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant1NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant2JsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant2NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant3JsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant3NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant4JsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant4NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant5JsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant5NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant6JsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant6NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant7JsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantIdVariant7NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantPriceTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantPriceTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantPriceIntervalJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseSelectedAddonVariantPriceIntervalNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant1JsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant1NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant2JsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant2NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant3JsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant3NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant4JsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant4NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant5JsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant5NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant6JsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant6NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant7JsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantIdVariant7NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantPriceTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantPriceTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantPriceIntervalJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProjectAddonsResponseAvailableAddonVariantPriceIntervalNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant1JsonConverter),

            typeof(global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant1NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant2JsonConverter),

            typeof(global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant2NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant3JsonConverter),

            typeof(global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant3NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant4JsonConverter),

            typeof(global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonVariantVariant4NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.ApplyProjectAddonBodyAddonTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintNameJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintNameNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintLevelJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintLevelNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintFacingJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintFacingNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintCategorieJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintCategorieNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintMetadataTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ProjectAdvisorsResponseLintMetadataTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.DeleteRolesResponseMessageJsonConverter),

            typeof(global::Supabase.JsonConverters.DeleteRolesResponseMessageNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.FunctionResponseStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.FunctionResponseStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.BulkUpdateFunctionBodyItemStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.BulkUpdateFunctionBodyItemStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.BulkUpdateFunctionResponseFunctionStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.BulkUpdateFunctionResponseFunctionStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.DeployFunctionResponseStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.DeployFunctionResponseStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.FunctionSlugResponseStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.FunctionSlugResponseStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.DiskResponseAttributesVariant1TypeJsonConverter),

            typeof(global::Supabase.JsonConverters.DiskResponseAttributesVariant1TypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.DiskResponseAttributesVariant2TypeJsonConverter),

            typeof(global::Supabase.JsonConverters.DiskResponseAttributesVariant2TypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.DiskRequestBodyAttributesVariant1TypeJsonConverter),

            typeof(global::Supabase.JsonConverters.DiskRequestBodyAttributesVariant1TypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.DiskRequestBodyAttributesVariant2TypeJsonConverter),

            typeof(global::Supabase.JsonConverters.DiskRequestBodyAttributesVariant2TypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.StorageConfigResponseExternalUpstreamTargetJsonConverter),

            typeof(global::Supabase.JsonConverters.StorageConfigResponseExternalUpstreamTargetNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateStorageConfigBodyExternalUpstreamTargetJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateStorageConfigBodyExternalUpstreamTargetNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1PgbouncerConfigResponsePoolModeJsonConverter),

            typeof(global::Supabase.JsonConverters.V1PgbouncerConfigResponsePoolModeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.SupavisorConfigResponseDatabaseTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.SupavisorConfigResponseDatabaseTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.SupavisorConfigResponsePoolModeJsonConverter),

            typeof(global::Supabase.JsonConverters.SupavisorConfigResponsePoolModeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateSupavisorConfigBodyPoolModeJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateSupavisorConfigBodyPoolModeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.PostgresConfigResponseSessionReplicationRoleJsonConverter),

            typeof(global::Supabase.JsonConverters.PostgresConfigResponseSessionReplicationRoleNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdatePostgresConfigBodySessionReplicationRoleJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdatePostgresConfigBodySessionReplicationRoleNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateProviderBodyTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateProviderBodyTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateProviderBodyNameIdFormatJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateProviderBodyNameIdFormatNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateProviderResponseSamlNameIdFormatJsonConverter),

            typeof(global::Supabase.JsonConverters.CreateProviderResponseSamlNameIdFormatNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProvidersResponseItemSamlNameIdFormatJsonConverter),

            typeof(global::Supabase.JsonConverters.ListProvidersResponseItemSamlNameIdFormatNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.GetProviderResponseSamlNameIdFormatJsonConverter),

            typeof(global::Supabase.JsonConverters.GetProviderResponseSamlNameIdFormatNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateProviderBodyNameIdFormatJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateProviderBodyNameIdFormatNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateProviderResponseSamlNameIdFormatJsonConverter),

            typeof(global::Supabase.JsonConverters.UpdateProviderResponseSamlNameIdFormatNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.DeleteProviderResponseSamlNameIdFormatJsonConverter),

            typeof(global::Supabase.JsonConverters.DeleteProviderResponseSamlNameIdFormatNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1BackupsResponseBackupStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.V1BackupsResponseBackupStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1RestorePointResponseStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.V1RestorePointResponseStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ListEntitlementsResponseEntitlementFeatureKeyJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ListEntitlementsResponseEntitlementFeatureKeyNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ListEntitlementsResponseEntitlementFeatureTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ListEntitlementsResponseEntitlementFeatureTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ListEntitlementsResponseEntitlementTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ListEntitlementsResponseEntitlementTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1OrganizationSlugResponsePlanJsonConverter),

            typeof(global::Supabase.JsonConverters.V1OrganizationSlugResponsePlanNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1OrganizationSlugResponseOptInTagJsonConverter),

            typeof(global::Supabase.JsonConverters.V1OrganizationSlugResponseOptInTagNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1OrganizationSlugResponseAllowedReleaseChannelJsonConverter),

            typeof(global::Supabase.JsonConverters.V1OrganizationSlugResponseAllowedReleaseChannelNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.OrganizationProjectClaimResponsePreviewSourceSubscriptionPlanJsonConverter),

            typeof(global::Supabase.JsonConverters.OrganizationProjectClaimResponsePreviewSourceSubscriptionPlanNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.OrganizationProjectClaimResponsePreviewTargetSubscriptionPlanJsonConverter),

            typeof(global::Supabase.JsonConverters.OrganizationProjectClaimResponsePreviewTargetSubscriptionPlanNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseProjectStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseProjectStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseInfraComputeSizeJsonConverter),

            typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseInfraComputeSizeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseStatusJsonConverter),

            typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseStatusNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseDiskTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.OrganizationProjectsResponseProjectDatabaseDiskTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1GetAvailableRegionsContinentJsonConverter),

            typeof(global::Supabase.JsonConverters.V1GetAvailableRegionsContinentNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1GetAvailableRegionsDesiredInstanceSizeJsonConverter),

            typeof(global::Supabase.JsonConverters.V1GetAvailableRegionsDesiredInstanceSizeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1AuthorizeUserResponseTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.V1AuthorizeUserResponseTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1AuthorizeUserCodeChallengeMethodJsonConverter),

            typeof(global::Supabase.JsonConverters.V1AuthorizeUserCodeChallengeMethodNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1OauthAuthorizeProjectClaimResponseTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.V1OauthAuthorizeProjectClaimResponseTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1OauthAuthorizeProjectClaimCodeChallengeMethodJsonConverter),

            typeof(global::Supabase.JsonConverters.V1OauthAuthorizeProjectClaimCodeChallengeMethodNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ListAllSnippetsSortByJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ListAllSnippetsSortByNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ListAllSnippetsSortOrderJsonConverter),

            typeof(global::Supabase.JsonConverters.V1ListAllSnippetsSortOrderNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1GetServicesHealthServiceJsonConverter),

            typeof(global::Supabase.JsonConverters.V1GetServicesHealthServiceNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant1JsonConverter),

            typeof(global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant1NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant2JsonConverter),

            typeof(global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant2NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant3JsonConverter),

            typeof(global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant3NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant4JsonConverter),

            typeof(global::Supabase.JsonConverters.V1RemoveProjectAddonAddonVariantVariant4NullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1GetSecurityAdvisorsLintTypeJsonConverter),

            typeof(global::Supabase.JsonConverters.V1GetSecurityAdvisorsLintTypeNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1GetProjectUsageApiCountIntervalJsonConverter),

            typeof(global::Supabase.JsonConverters.V1GetProjectUsageApiCountIntervalNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1GetProjectFunctionCombinedStatsIntervalJsonConverter),

            typeof(global::Supabase.JsonConverters.V1GetProjectFunctionCombinedStatsIntervalNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.V1GetAllProjectsForOrganizationSortJsonConverter),

            typeof(global::Supabase.JsonConverters.V1GetAllProjectsForOrganizationSortNullableJsonConverter),

            typeof(global::Supabase.JsonConverters.RegionSelectionJsonConverter),

            typeof(global::Supabase.JsonConverters.JitStateResponseJsonConverter),

            typeof(global::Supabase.JsonConverters.PrivateJwkJsonConverter),

            typeof(global::Supabase.JsonConverters.Attributes2JsonConverter),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant1, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant2, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant3, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant4, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant5, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant6, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant7, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant8>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.V1ServiceHealthResponseInfoVariant1, global::Supabase.V1ServiceHealthResponseInfoVariant2, global::Supabase.V1ServiceHealthResponseInfoVariant3>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant1?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant2?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant3?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant4?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant5?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant6?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant7?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant1?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant2?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant3?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant4?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant5?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant6?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant7?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.ApplyProjectAddonBodyAddonVariantVariant1?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant3?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant4?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<string, global::Supabase.AnalyticsResponseError>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<string, global::Supabase.V1GetUsageApiCountResponseError>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<string, global::Supabase.V1GetUsageApiRequestsCountResponseError>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.DiskResponseAttributesVariant1, global::Supabase.DiskResponseAttributesVariant2>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<object, double?, string, bool?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<object, double?, string, bool?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<object, double?, string, bool?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<object, double?, string, bool?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<object, double?, string, bool?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<object, double?, string, bool?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<object, double?, string, bool?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant1, global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant2, global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant3>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<string, global::System.Guid?>),

            typeof(global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.V1RemoveProjectAddonAddonVariantVariant1?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant2?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant3?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant4?>),

            typeof(global::Supabase.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchDetailResponseStatus), TypeInfoPropertyName = "BranchDetailResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateBranchBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateBranchBodyStatus), TypeInfoPropertyName = "UpdateBranchBodyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchResponseStatus), TypeInfoPropertyName = "BranchResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchResponsePreviewProjectStatus), TypeInfoPropertyName = "BranchResponsePreviewProjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchDeleteResponseMessage), TypeInfoPropertyName = "BranchDeleteResponseMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchActionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchUpdateResponseMessage), TypeInfoPropertyName = "BranchUpdateResponseMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchRestoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchRestoreResponseMessage), TypeInfoPropertyName = "BranchRestoreResponseMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectWithDatabaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectWithDatabaseResponseStatus), TypeInfoPropertyName = "V1ProjectWithDatabaseResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectWithDatabaseResponseDatabase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1CreateProjectBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1CreateProjectBodyPlan), TypeInfoPropertyName = "V1CreateProjectBodyPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1CreateProjectBodyRegion), TypeInfoPropertyName = "V1CreateProjectBodyRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionSelection), TypeInfoPropertyName = "RegionSelection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant1Type), TypeInfoPropertyName = "V1CreateProjectBodyRegionSelectionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant1Code), TypeInfoPropertyName = "V1CreateProjectBodyRegionSelectionVariant1Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant2Type), TypeInfoPropertyName = "V1CreateProjectBodyRegionSelectionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant2Code), TypeInfoPropertyName = "V1CreateProjectBodyRegionSelectionVariant2Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1CreateProjectBodyRegionSelectionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1CreateProjectBodyDesiredInstanceSize), TypeInfoPropertyName = "V1CreateProjectBodyDesiredInstanceSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectResponseStatus), TypeInfoPropertyName = "V1ProjectResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoRecommendations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoRecommendationsSmartGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoRecommendationsSmartGroupCode), TypeInfoPropertyName = "RegionsInfoRecommendationsSmartGroupCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoRecommendationsSmartGroupType), TypeInfoPropertyName = "RegionsInfoRecommendationsSmartGroupType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.RegionsInfoRecommendationsSpecificItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoRecommendationsSpecificItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoRecommendationsSpecificItemCode), TypeInfoPropertyName = "RegionsInfoRecommendationsSpecificItemCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoRecommendationsSpecificItemType), TypeInfoPropertyName = "RegionsInfoRecommendationsSpecificItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoRecommendationsSpecificItemProvider), TypeInfoPropertyName = "RegionsInfoRecommendationsSpecificItemProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoRecommendationsSpecificItemStatus), TypeInfoPropertyName = "RegionsInfoRecommendationsSpecificItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoAll))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.RegionsInfoAllSmartGroupItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoAllSmartGroupItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoAllSmartGroupItemCode), TypeInfoPropertyName = "RegionsInfoAllSmartGroupItemCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoAllSmartGroupItemType), TypeInfoPropertyName = "RegionsInfoAllSmartGroupItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.RegionsInfoAllSpecificItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoAllSpecificItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoAllSpecificItemCode), TypeInfoPropertyName = "RegionsInfoAllSpecificItemCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoAllSpecificItemType), TypeInfoPropertyName = "RegionsInfoAllSpecificItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoAllSpecificItemProvider), TypeInfoPropertyName = "RegionsInfoAllSpecificItemProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RegionsInfoAllSpecificItemStatus), TypeInfoPropertyName = "RegionsInfoAllSpecificItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateOrganizationV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OAuthTokenBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OAuthTokenBodyGrantType), TypeInfoPropertyName = "OAuthTokenBodyGrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OAuthTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OAuthTokenResponseTokenType), TypeInfoPropertyName = "OAuthTokenResponseTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OAuthRevokeTokenBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.SnippetListDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetListDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetListDataItemType), TypeInfoPropertyName = "SnippetListDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetListDataItemVisibility), TypeInfoPropertyName = "SnippetListDataItemVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetListDataItemProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetListDataItemOwner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetListDataItemUpdatedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponseType), TypeInfoPropertyName = "SnippetResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponseVisibility), TypeInfoPropertyName = "SnippetResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponseProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponseOwner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponseUpdatedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponseContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProfileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.ListActionRunResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListActionRunResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.ListActionRunResponseItemRunStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListActionRunResponseItemRunStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListActionRunResponseItemRunStepName), TypeInfoPropertyName = "ListActionRunResponseItemRunStepName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListActionRunResponseItemRunStepStatus), TypeInfoPropertyName = "ListActionRunResponseItemRunStepStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ActionRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.ActionRunResponseRunStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ActionRunResponseRunStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ActionRunResponseRunStepName), TypeInfoPropertyName = "ActionRunResponseRunStepName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ActionRunResponseRunStepStatus), TypeInfoPropertyName = "ActionRunResponseRunStepStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyClone), TypeInfoPropertyName = "UpdateRunStatusBodyClone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyPull), TypeInfoPropertyName = "UpdateRunStatusBodyPull2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyHealth), TypeInfoPropertyName = "UpdateRunStatusBodyHealth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyConfigure), TypeInfoPropertyName = "UpdateRunStatusBodyConfigure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyMigrate), TypeInfoPropertyName = "UpdateRunStatusBodyMigrate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodySeed), TypeInfoPropertyName = "UpdateRunStatusBodySeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyDeploy), TypeInfoPropertyName = "UpdateRunStatusBodyDeploy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusResponseMessage), TypeInfoPropertyName = "UpdateRunStatusResponseMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ApiKeyResponseType), TypeInfoPropertyName = "ApiKeyResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.LegacyApiKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateApiKeyBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateApiKeyBodyType), TypeInfoPropertyName = "CreateApiKeyBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateApiKeyBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateBranchBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateBranchBodyDesiredInstanceSize), TypeInfoPropertyName = "CreateBranchBodyDesiredInstanceSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateBranchBodyReleaseChannel), TypeInfoPropertyName = "CreateBranchBodyReleaseChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateBranchBodyPostgresEngine), TypeInfoPropertyName = "CreateBranchBodyPostgresEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateCustomHostnameResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateCustomHostnameResponseStatus), TypeInfoPropertyName = "UpdateCustomHostnameResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateCustomHostnameResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateCustomHostnameResponseDataResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateCustomHostnameResponseDataResultSsl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseDataResultSslValidationRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateCustomHostnameResponseDataResultSslValidationRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseDataResultSslValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateCustomHostnameResponseDataResultSslValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateCustomHostnameResponseDataResultOwnershipVerification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateCustomHostnameBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitStateResponse), TypeInfoPropertyName = "JitStateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitStateResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitStateResponseVariant1State), TypeInfoPropertyName = "JitStateResponseVariant1State2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitStateResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitStateResponseVariant2State), TypeInfoPropertyName = "JitStateResponseVariant2State2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitStateResponseVariant2UnavailableReason), TypeInfoPropertyName = "JitStateResponseVariant2UnavailableReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitStateResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAccessRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAccessRequestRequestState), TypeInfoPropertyName = "JitAccessRequestRequestState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkBanResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkBanResponseEnriched))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.NetworkBanResponseEnrichedBannedIpv4Addresse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkBanResponseEnrichedBannedIpv4Addresse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RemoveNetworkBanRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsResponseEntitlement), TypeInfoPropertyName = "NetworkRestrictionsResponseEntitlement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsResponseOldConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsResponseStatus), TypeInfoPropertyName = "NetworkRestrictionsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsPatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsPatchRequestAdd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsPatchRequestRemove))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsV2ResponseEntitlement), TypeInfoPropertyName = "NetworkRestrictionsV2ResponseEntitlement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsV2ResponseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.NetworkRestrictionsV2ResponseConfigDbAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsV2ResponseConfigDbAllowedCidr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsV2ResponseConfigDbAllowedCidrType), TypeInfoPropertyName = "NetworkRestrictionsV2ResponseConfigDbAllowedCidrType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsV2ResponseOldConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.NetworkRestrictionsV2ResponseOldConfigDbAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsV2ResponseOldConfigDbAllowedCidr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsV2ResponseOldConfigDbAllowedCidrType), TypeInfoPropertyName = "NetworkRestrictionsV2ResponseOldConfigDbAllowedCidrType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.NetworkRestrictionsV2ResponseStatus), TypeInfoPropertyName = "NetworkRestrictionsV2ResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.PgsodiumConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdatePgsodiumConfigBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.PostgrestConfigWithJWTSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpdatePostgrestConfigBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1PostgrestConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectRefResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpdateProjectBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.CreateSecretBodyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSecretBodyItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SslEnforcementResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SslEnforcementResponseCurrentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SslEnforcementRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SslEnforcementRequestRequestedConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.TypescriptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.VanitySubdomainConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.VanitySubdomainConfigResponseStatus), TypeInfoPropertyName = "VanitySubdomainConfigResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.VanitySubdomainBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SubdomainAvailabilityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ActivateVanitySubdomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpgradeDatabaseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpgradeDatabaseBodyReleaseChannel), TypeInfoPropertyName = "UpgradeDatabaseBodyReleaseChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeInitiateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel), TypeInfoPropertyName = "ProjectUpgradeEligibilityResponseCurrentAppVersionReleaseChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.ProjectUpgradeEligibilityResponseTargetUpgradeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseTargetUpgradeVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion), TypeInfoPropertyName = "ProjectUpgradeEligibilityResponseTargetUpgradeVersionPostgresVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel), TypeInfoPropertyName = "ProjectUpgradeEligibilityResponseTargetUpgradeVersionReleaseChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.OneOf<global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant1, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant2, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant3, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant4, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant5, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant6, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant7, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant8>>), TypeInfoPropertyName = "ProjectUpgradeEligibilityResponseValidationErrorVariant8_674af966dddea15b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant1, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant2, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant3, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant4, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant5, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant6, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant7, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant8>), TypeInfoPropertyName = "ProjectUpgradeEligibilityResponseValidationErrorVariant8_24e758e8754eb1de")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant1Type), TypeInfoPropertyName = "ProjectUpgradeEligibilityResponseValidationErrorVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant2Type), TypeInfoPropertyName = "ProjectUpgradeEligibilityResponseValidationErrorVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant3Type), TypeInfoPropertyName = "ProjectUpgradeEligibilityResponseValidationErrorVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant4Type), TypeInfoPropertyName = "ProjectUpgradeEligibilityResponseValidationErrorVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant5Type), TypeInfoPropertyName = "ProjectUpgradeEligibilityResponseValidationErrorVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant6Type), TypeInfoPropertyName = "ProjectUpgradeEligibilityResponseValidationErrorVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant7Type), TypeInfoPropertyName = "ProjectUpgradeEligibilityResponseValidationErrorVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjType), TypeInfoPropertyName = "ProjectUpgradeEligibilityResponseValidationErrorVariant7ObjType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant8Type), TypeInfoPropertyName = "ProjectUpgradeEligibilityResponseValidationErrorVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DatabaseUpgradeStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DatabaseUpgradeStatusResponseDatabaseUpgradeStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError), TypeInfoPropertyName = "DatabaseUpgradeStatusResponseDatabaseUpgradeStatusError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress), TypeInfoPropertyName = "DatabaseUpgradeStatusResponseDatabaseUpgradeStatusProgress2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ReadOnlyStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SetUpReadReplicaBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SetUpReadReplicaBodyReadReplicaRegion), TypeInfoPropertyName = "SetUpReadReplicaBodyReadReplicaRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RemoveReadReplicaBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ServiceHealthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ServiceHealthResponseName), TypeInfoPropertyName = "V1ServiceHealthResponseName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ServiceHealthResponseStatus), TypeInfoPropertyName = "V1ServiceHealthResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<global::Supabase.V1ServiceHealthResponseInfoVariant1, global::Supabase.V1ServiceHealthResponseInfoVariant2, global::Supabase.V1ServiceHealthResponseInfoVariant3>), TypeInfoPropertyName = "OneOfV1ServiceHealthResponseInfoVariant1V1ServiceHealthResponseInfoVariant2V1ServiceHealthResponseInfoVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ServiceHealthResponseInfoVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ServiceHealthResponseInfoVariant1Name), TypeInfoPropertyName = "V1ServiceHealthResponseInfoVariant1Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ServiceHealthResponseInfoVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ServiceHealthResponseInfoVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SigningKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SigningKeyResponseAlgorithm), TypeInfoPropertyName = "SigningKeyResponseAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SigningKeyResponseStatus), TypeInfoPropertyName = "SigningKeyResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyAlgorithm), TypeInfoPropertyName = "CreateSigningKeyBodyAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyStatus), TypeInfoPropertyName = "CreateSigningKeyBodyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.PrivateJwk), TypeInfoPropertyName = "PrivateJwk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1Use), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant1Use2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1KeyOp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1KeyOp), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant1KeyOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1Kty), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant1Kty2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1Alg), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant1Alg2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1E), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant1E2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Use), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant2Use2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2KeyOp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2KeyOp), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant2KeyOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Kty), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant2Kty2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Alg), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant2Alg2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Crv), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant2Crv2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3Use), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant3Use2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3KeyOp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3KeyOp), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant3KeyOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3Kty), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant3Kty2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3Alg), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant3Alg2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3Crv), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant3Crv2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4Use), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant4Use2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4KeyOp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4KeyOp), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant4KeyOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4Kty), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant4Kty2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4Alg), TypeInfoPropertyName = "CreateSigningKeyBodyPrivateJwkVariant4Alg2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SigningKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.SigningKeysResponseKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SigningKeysResponseKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SigningKeysResponseKeyAlgorithm), TypeInfoPropertyName = "SigningKeysResponseKeyAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SigningKeysResponseKeyStatus), TypeInfoPropertyName = "SigningKeysResponseKeyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateSigningKeyBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateSigningKeyBodyStatus), TypeInfoPropertyName = "UpdateSigningKeyBodyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AuthConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AuthConfigResponseDbMaxPoolSizeUnit), TypeInfoPropertyName = "AuthConfigResponseDbMaxPoolSizeUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AuthConfigResponsePasswordRequiredCharacters), TypeInfoPropertyName = "AuthConfigResponsePasswordRequiredCharacters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AuthConfigResponseSecurityCaptchaProvider), TypeInfoPropertyName = "AuthConfigResponseSecurityCaptchaProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AuthConfigResponseSmsProvider), TypeInfoPropertyName = "AuthConfigResponseSmsProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateAuthConfigBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateAuthConfigBodySecurityCaptchaProvider), TypeInfoPropertyName = "UpdateAuthConfigBodySecurityCaptchaProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateAuthConfigBodyPasswordRequiredCharacters), TypeInfoPropertyName = "UpdateAuthConfigBodyPasswordRequiredCharacters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateAuthConfigBodySmsProvider), TypeInfoPropertyName = "UpdateAuthConfigBodySmsProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateAuthConfigBodyDbMaxPoolSizeUnit), TypeInfoPropertyName = "UpdateAuthConfigBodyDbMaxPoolSizeUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateThirdPartyAuthBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ThirdPartyAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProjectAvailableRestoreVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.GetProjectAvailableRestoreVersionsResponseAvailableVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProjectAvailableRestoreVersionsResponseAvailableVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel), TypeInfoPropertyName = "GetProjectAvailableRestoreVersionsResponseAvailableVersionReleaseChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine), TypeInfoPropertyName = "GetProjectAvailableRestoreVersionsResponseAvailableVersionPostgresEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseSelectedAddon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseSelectedAddon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseSelectedAddonType), TypeInfoPropertyName = "ListProjectAddonsResponseSelectedAddonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseSelectedAddonVariant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant1?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant2?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant3?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant4?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant5?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant6?, global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant7?>), TypeInfoPropertyName = "ListProjectAddonsResponseSelectedAddonVariantIdVariant7_e69aa8168b0edccc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant1), TypeInfoPropertyName = "ListProjectAddonsResponseSelectedAddonVariantIdVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant2), TypeInfoPropertyName = "ListProjectAddonsResponseSelectedAddonVariantIdVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant3), TypeInfoPropertyName = "ListProjectAddonsResponseSelectedAddonVariantIdVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant4), TypeInfoPropertyName = "ListProjectAddonsResponseSelectedAddonVariantIdVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant5), TypeInfoPropertyName = "ListProjectAddonsResponseSelectedAddonVariantIdVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant6), TypeInfoPropertyName = "ListProjectAddonsResponseSelectedAddonVariantIdVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseSelectedAddonVariantIdVariant7), TypeInfoPropertyName = "ListProjectAddonsResponseSelectedAddonVariantIdVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseSelectedAddonVariantPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseSelectedAddonVariantPriceType), TypeInfoPropertyName = "ListProjectAddonsResponseSelectedAddonVariantPriceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseSelectedAddonVariantPriceInterval), TypeInfoPropertyName = "ListProjectAddonsResponseSelectedAddonVariantPriceInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseAvailableAddon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseAvailableAddon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseAvailableAddonType), TypeInfoPropertyName = "ListProjectAddonsResponseAvailableAddonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseAvailableAddonVariant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseAvailableAddonVariant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant1?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant2?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant3?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant4?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant5?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant6?, global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant7?>), TypeInfoPropertyName = "ListProjectAddonsResponseAvailableAddonVariantIdVariant7_590ac3ed40a15eaa")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant1), TypeInfoPropertyName = "ListProjectAddonsResponseAvailableAddonVariantIdVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant2), TypeInfoPropertyName = "ListProjectAddonsResponseAvailableAddonVariantIdVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant3), TypeInfoPropertyName = "ListProjectAddonsResponseAvailableAddonVariantIdVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant4), TypeInfoPropertyName = "ListProjectAddonsResponseAvailableAddonVariantIdVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant5), TypeInfoPropertyName = "ListProjectAddonsResponseAvailableAddonVariantIdVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant6), TypeInfoPropertyName = "ListProjectAddonsResponseAvailableAddonVariantIdVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseAvailableAddonVariantIdVariant7), TypeInfoPropertyName = "ListProjectAddonsResponseAvailableAddonVariantIdVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseAvailableAddonVariantPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseAvailableAddonVariantPriceType), TypeInfoPropertyName = "ListProjectAddonsResponseAvailableAddonVariantPriceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProjectAddonsResponseAvailableAddonVariantPriceInterval), TypeInfoPropertyName = "ListProjectAddonsResponseAvailableAddonVariantPriceInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ApplyProjectAddonBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<global::Supabase.ApplyProjectAddonBodyAddonVariantVariant1?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant3?, global::Supabase.ApplyProjectAddonBodyAddonVariantVariant4?>), TypeInfoPropertyName = "ApplyProjectAddonBodyAddonVariantVariant4_9df9d8878db596d9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ApplyProjectAddonBodyAddonVariantVariant1), TypeInfoPropertyName = "ApplyProjectAddonBodyAddonVariantVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2), TypeInfoPropertyName = "ApplyProjectAddonBodyAddonVariantVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ApplyProjectAddonBodyAddonVariantVariant3), TypeInfoPropertyName = "ApplyProjectAddonBodyAddonVariantVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ApplyProjectAddonBodyAddonVariantVariant4), TypeInfoPropertyName = "ApplyProjectAddonBodyAddonVariantVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ApplyProjectAddonBodyAddonType), TypeInfoPropertyName = "ApplyProjectAddonBodyAddonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ProjectClaimTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateProjectClaimTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1ProjectAdvisorsResponseLint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseLint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseLintName), TypeInfoPropertyName = "V1ProjectAdvisorsResponseLintName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseLintLevel), TypeInfoPropertyName = "V1ProjectAdvisorsResponseLintLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseLintFacing), TypeInfoPropertyName = "V1ProjectAdvisorsResponseLintFacing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1ProjectAdvisorsResponseLintCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseLintCategorie), TypeInfoPropertyName = "V1ProjectAdvisorsResponseLintCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseLintMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseLintMetadataType), TypeInfoPropertyName = "V1ProjectAdvisorsResponseLintMetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnalyticsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<string, global::Supabase.AnalyticsResponseError>), TypeInfoPropertyName = "OneOfStringAnalyticsResponseError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnalyticsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.AnalyticsResponseErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnalyticsResponseErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiCountResponseResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiCountResponseResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<string, global::Supabase.V1GetUsageApiCountResponseError>), TypeInfoPropertyName = "OneOfStringV1GetUsageApiCountResponseError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiCountResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiCountResponseErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiCountResponseErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiRequestsCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiRequestsCountResponseResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiRequestsCountResponseResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<string, global::Supabase.V1GetUsageApiRequestsCountResponseError>), TypeInfoPropertyName = "OneOfStringV1GetUsageApiRequestsCountResponseError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiRequestsCountResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiRequestsCountResponseErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiRequestsCountResponseErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateRoleBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateRoleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DeleteRolesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DeleteRolesResponseMessage), TypeInfoPropertyName = "DeleteRolesResponseMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1ListMigrationsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListMigrationsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1CreateMigrationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpsertMigrationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetMigrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1PatchMigrationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RunQueryBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ReadOnlyQueryBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProjectDbMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.GetProjectDbMetadataResponseDatabase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProjectDbMetadataResponseDatabase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.GetProjectDbMetadataResponseDatabaseSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProjectDbMetadataResponseDatabaseSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpdatePasswordBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpdatePasswordResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseUserRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAccessResponseUserRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAccessResponseUserRoleAllowedNetworks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseUserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAccessResponseUserRoleAllowedNetworksAllowedCidr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseUserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAccessResponseUserRoleAllowedNetworksAllowedCidrsV6Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AuthorizeJitAccessBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAuthorizeAccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAuthorizeAccessResponseUserRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAuthorizeAccessResponseUserRoleAllowedNetworks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitAuthorizeAccessResponseUserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAuthorizeAccessResponseUserRoleAllowedNetworksAllowedCidr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitAuthorizeAccessResponseUserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAuthorizeAccessResponseUserRoleAllowedNetworksAllowedCidrsV6Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseItemUserRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseItemUserRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseItemUserRoleAllowedNetworks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseItemUserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseItemUserRoleAllowedNetworksAllowedCidr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseItemUserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseItemUserRoleAllowedNetworksAllowedCidrsV6Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateJitAccessBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.UpdateJitAccessBodyRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateJitAccessBodyRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateJitAccessBodyRoleAllowedNetworks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.FunctionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.FunctionResponseStatus), TypeInfoPropertyName = "FunctionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1CreateFunctionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.BulkUpdateFunctionBodyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BulkUpdateFunctionBodyItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BulkUpdateFunctionBodyItemStatus), TypeInfoPropertyName = "BulkUpdateFunctionBodyItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BulkUpdateFunctionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.BulkUpdateFunctionResponseFunction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BulkUpdateFunctionResponseFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BulkUpdateFunctionResponseFunctionStatus), TypeInfoPropertyName = "BulkUpdateFunctionResponseFunctionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.FunctionDeployBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.FunctionDeployBodyMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DeployFunctionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DeployFunctionResponseStatus), TypeInfoPropertyName = "DeployFunctionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.FunctionSlugResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.FunctionSlugResponseStatus), TypeInfoPropertyName = "FunctionSlugResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StreamableFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpdateFunctionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1StorageBucketResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DiskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<global::Supabase.DiskResponseAttributesVariant1, global::Supabase.DiskResponseAttributesVariant2>), TypeInfoPropertyName = "OneOfDiskResponseAttributesVariant1DiskResponseAttributesVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DiskResponseAttributesVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DiskResponseAttributesVariant1Type), TypeInfoPropertyName = "DiskResponseAttributesVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DiskResponseAttributesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DiskResponseAttributesVariant2Type), TypeInfoPropertyName = "DiskResponseAttributesVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DiskRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.Attributes2), TypeInfoPropertyName = "Attributes22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DiskRequestBodyAttributesVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DiskRequestBodyAttributesVariant1Type), TypeInfoPropertyName = "DiskRequestBodyAttributesVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DiskRequestBodyAttributesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DiskRequestBodyAttributesVariant2Type), TypeInfoPropertyName = "DiskRequestBodyAttributesVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DiskRequestBodyAttributesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DiskUtilMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DiskUtilMetricsResponseMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DiskAutoscaleConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseFeatures))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseFeaturesImageTransformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseFeaturesS3Protocol))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseFeaturesIcebergCatalog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseFeaturesVectorBuckets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseExternal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseExternalUpstreamTarget), TypeInfoPropertyName = "StorageConfigResponseExternalUpstreamTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyFeatures))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyFeaturesImageTransformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyFeaturesS3Protocol))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyFeaturesIcebergCatalog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyFeaturesVectorBuckets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyExternal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyExternalUpstreamTarget), TypeInfoPropertyName = "UpdateStorageConfigBodyExternalUpstreamTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1PgbouncerConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1PgbouncerConfigResponsePoolMode), TypeInfoPropertyName = "V1PgbouncerConfigResponsePoolMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SupavisorConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SupavisorConfigResponseDatabaseType), TypeInfoPropertyName = "SupavisorConfigResponseDatabaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SupavisorConfigResponsePoolMode), TypeInfoPropertyName = "SupavisorConfigResponsePoolMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateSupavisorConfigBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateSupavisorConfigBodyPoolMode), TypeInfoPropertyName = "UpdateSupavisorConfigBodyPoolMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateSupavisorConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.PostgresConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.PostgresConfigResponseSessionReplicationRole), TypeInfoPropertyName = "PostgresConfigResponseSessionReplicationRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdatePostgresConfigBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdatePostgresConfigBodySessionReplicationRole), TypeInfoPropertyName = "UpdatePostgresConfigBodySessionReplicationRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RealtimeConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRealtimeConfigBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateProviderBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateProviderBodyType), TypeInfoPropertyName = "CreateProviderBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateProviderBodyAttributeMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Supabase.CreateProviderBodyAttributeMappingKeys2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateProviderBodyAttributeMappingKeys2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<object, double?, string, bool?>), TypeInfoPropertyName = "OneOfObjectDoubleStringBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateProviderBodyNameIdFormat), TypeInfoPropertyName = "CreateProviderBodyNameIdFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateProviderResponseSaml))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateProviderResponseSamlAttributeMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Supabase.CreateProviderResponseSamlAttributeMappingKeys2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateProviderResponseSamlAttributeMappingKeys2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateProviderResponseSamlNameIdFormat), TypeInfoPropertyName = "CreateProviderResponseSamlNameIdFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.CreateProviderResponseDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateProviderResponseDomain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProvidersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.ListProvidersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProvidersResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProvidersResponseItemSaml))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProvidersResponseItemSamlAttributeMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Supabase.ListProvidersResponseItemSamlAttributeMappingKeys2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProvidersResponseItemSamlAttributeMappingKeys2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProvidersResponseItemSamlNameIdFormat), TypeInfoPropertyName = "ListProvidersResponseItemSamlNameIdFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.ListProvidersResponseItemDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListProvidersResponseItemDomain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProviderResponseSaml))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProviderResponseSamlAttributeMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Supabase.GetProviderResponseSamlAttributeMappingKeys2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProviderResponseSamlAttributeMappingKeys2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProviderResponseSamlNameIdFormat), TypeInfoPropertyName = "GetProviderResponseSamlNameIdFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.GetProviderResponseDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProviderResponseDomain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateProviderBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateProviderBodyAttributeMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Supabase.UpdateProviderBodyAttributeMappingKeys2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateProviderBodyAttributeMappingKeys2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateProviderBodyNameIdFormat), TypeInfoPropertyName = "UpdateProviderBodyNameIdFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateProviderResponseSaml))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateProviderResponseSamlAttributeMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Supabase.UpdateProviderResponseSamlAttributeMappingKeys2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateProviderResponseSamlAttributeMappingKeys2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateProviderResponseSamlNameIdFormat), TypeInfoPropertyName = "UpdateProviderResponseSamlNameIdFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.UpdateProviderResponseDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateProviderResponseDomain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DeleteProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DeleteProviderResponseSaml))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DeleteProviderResponseSamlAttributeMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Supabase.DeleteProviderResponseSamlAttributeMappingKeys2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DeleteProviderResponseSamlAttributeMappingKeys2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DeleteProviderResponseSamlNameIdFormat), TypeInfoPropertyName = "DeleteProviderResponseSamlNameIdFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.DeleteProviderResponseDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DeleteProviderResponseDomain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1BackupsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1BackupsResponseBackup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1BackupsResponseBackup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1BackupsResponseBackupStatus), TypeInfoPropertyName = "V1BackupsResponseBackupStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1BackupsResponsePhysicalBackupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RestorePitrBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RestorePointPostBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RestorePointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RestorePointResponseStatus), TypeInfoPropertyName = "V1RestorePointResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UndoBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1ListEntitlementsResponseEntitlement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseEntitlement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseEntitlementFeature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseEntitlementFeatureKey), TypeInfoPropertyName = "V1ListEntitlementsResponseEntitlementFeatureKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseEntitlementFeatureType), TypeInfoPropertyName = "V1ListEntitlementsResponseEntitlementFeatureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseEntitlementType), TypeInfoPropertyName = "V1ListEntitlementsResponseEntitlementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant1, global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant2, global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant3>), TypeInfoPropertyName = "V1ListEntitlementsResponseEntitlementConfigVariant3_9a3fba112d89481f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseEntitlementConfigVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OrganizationMemberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OrganizationSlugResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OrganizationSlugResponsePlan), TypeInfoPropertyName = "V1OrganizationSlugResponsePlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1OrganizationSlugResponseOptInTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OrganizationSlugResponseOptInTag), TypeInfoPropertyName = "V1OrganizationSlugResponseOptInTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1OrganizationSlugResponseAllowedReleaseChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OrganizationSlugResponseAllowedReleaseChannel), TypeInfoPropertyName = "V1OrganizationSlugResponseAllowedReleaseChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponseProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponsePreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponsePreviewWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponsePreviewWarning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponsePreviewError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponsePreviewError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponsePreviewInfoItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponsePreviewInfoItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponsePreviewMembersExceedingFreeProjectLimitItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponsePreviewMembersExceedingFreeProjectLimitItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan), TypeInfoPropertyName = "OrganizationProjectClaimResponsePreviewSourceSubscriptionPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan), TypeInfoPropertyName = "OrganizationProjectClaimResponsePreviewTargetSubscriptionPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectsResponseProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectsResponseProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectsResponseProjectStatus), TypeInfoPropertyName = "OrganizationProjectsResponseProjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectsResponseProjectDatabase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectsResponseProjectDatabase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectsResponseProjectDatabaseInfraComputeSize), TypeInfoPropertyName = "OrganizationProjectsResponseProjectDatabaseInfraComputeSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectsResponseProjectDatabaseStatus), TypeInfoPropertyName = "OrganizationProjectsResponseProjectDatabaseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectsResponseProjectDatabaseType), TypeInfoPropertyName = "OrganizationProjectsResponseProjectDatabaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectsResponseProjectDatabaseDiskType), TypeInfoPropertyName = "OrganizationProjectsResponseProjectDatabaseDiskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectsResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<string, global::System.Guid?>), TypeInfoPropertyName = "OneOfStringGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetAvailableRegionsContinent), TypeInfoPropertyName = "V1GetAvailableRegionsContinent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetAvailableRegionsDesiredInstanceSize), TypeInfoPropertyName = "V1GetAvailableRegionsDesiredInstanceSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1AuthorizeUserResponseType), TypeInfoPropertyName = "V1AuthorizeUserResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1AuthorizeUserCodeChallengeMethod), TypeInfoPropertyName = "V1AuthorizeUserCodeChallengeMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OauthAuthorizeProjectClaimResponseType), TypeInfoPropertyName = "V1OauthAuthorizeProjectClaimResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OauthAuthorizeProjectClaimCodeChallengeMethod), TypeInfoPropertyName = "V1OauthAuthorizeProjectClaimCodeChallengeMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListAllSnippetsSortBy), TypeInfoPropertyName = "V1ListAllSnippetsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListAllSnippetsSortOrder), TypeInfoPropertyName = "V1ListAllSnippetsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1GetServicesHealthService>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetServicesHealthService), TypeInfoPropertyName = "V1GetServicesHealthService2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<global::Supabase.V1RemoveProjectAddonAddonVariantVariant1?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant2?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant3?, global::Supabase.V1RemoveProjectAddonAddonVariantVariant4?>), TypeInfoPropertyName = "V1RemoveProjectAddonAddonVariantVariant4_84a345962d192efb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RemoveProjectAddonAddonVariantVariant1), TypeInfoPropertyName = "V1RemoveProjectAddonAddonVariantVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RemoveProjectAddonAddonVariantVariant2), TypeInfoPropertyName = "V1RemoveProjectAddonAddonVariantVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RemoveProjectAddonAddonVariantVariant3), TypeInfoPropertyName = "V1RemoveProjectAddonAddonVariantVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RemoveProjectAddonAddonVariantVariant4), TypeInfoPropertyName = "V1RemoveProjectAddonAddonVariantVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetSecurityAdvisorsLintType), TypeInfoPropertyName = "V1GetSecurityAdvisorsLintType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetProjectUsageApiCountInterval), TypeInfoPropertyName = "V1GetProjectUsageApiCountInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetProjectFunctionCombinedStatsInterval), TypeInfoPropertyName = "V1GetProjectFunctionCombinedStatsInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetAllProjectsForOrganizationSort), TypeInfoPropertyName = "V1GetAllProjectsForOrganizationSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1ProjectWithDatabaseResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.OrganizationResponseV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.ApiKeyResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.BranchResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.SecretResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1ServiceHealthResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.ThirdPartyAuth>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.FunctionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1StorageBucketResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.SupavisorConfigResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1OrganizationMemberResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.RegionsInfoRecommendationsSpecificItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.RegionsInfoAllSmartGroupItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.RegionsInfoAllSpecificItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.SnippetListDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.ListActionRunResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.ListActionRunResponseItemRunStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.ActionRunResponseRunStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.UpdateCustomHostnameResponseDataResultSslValidationRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.UpdateCustomHostnameResponseDataResultSslValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.NetworkBanResponseEnrichedBannedIpv4Addresse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.NetworkRestrictionsV2ResponseConfigDbAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.NetworkRestrictionsV2ResponseOldConfigDbAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.CreateSecretBodyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.ProjectUpgradeEligibilityResponseTargetUpgradeVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.OneOf<global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant1, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant2, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant3, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant4, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant5, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant6, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant7, global::Supabase.ProjectUpgradeEligibilityResponseValidationErrorVariant8>>), TypeInfoPropertyName = "ProjectUpgradeEligibilityResponseValidationErrorVariant8_0c2f67bf3df671ee")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1KeyOp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2KeyOp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3KeyOp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4KeyOp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.SigningKeysResponseKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.GetProjectAvailableRestoreVersionsResponseAvailableVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.ListProjectAddonsResponseSelectedAddon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.ListProjectAddonsResponseAvailableAddon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.ListProjectAddonsResponseAvailableAddonVariant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1ProjectAdvisorsResponseLint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1ProjectAdvisorsResponseLintCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.AnalyticsResponseErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1GetUsageApiCountResponseResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1GetUsageApiCountResponseErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1GetUsageApiRequestsCountResponseResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1GetUsageApiRequestsCountResponseErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1ListMigrationsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.GetProjectDbMetadataResponseDatabase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.GetProjectDbMetadataResponseDatabaseSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitAccessResponseUserRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitAccessResponseUserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitAccessResponseUserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitAuthorizeAccessResponseUserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitAuthorizeAccessResponseUserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseItemUserRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseItemUserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseItemUserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.UpdateJitAccessBodyRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.BulkUpdateFunctionBodyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.BulkUpdateFunctionResponseFunction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.CreateProviderResponseDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.ListProvidersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.ListProvidersResponseItemDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.GetProviderResponseDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.UpdateProviderResponseDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.DeleteProviderResponseDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1BackupsResponseBackup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1ListEntitlementsResponseEntitlement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1OrganizationSlugResponseOptInTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1OrganizationSlugResponseAllowedReleaseChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.OrganizationProjectClaimResponsePreviewWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.OrganizationProjectClaimResponsePreviewError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.OrganizationProjectClaimResponsePreviewInfoItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.OrganizationProjectClaimResponsePreviewMembersExceedingFreeProjectLimitItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.OrganizationProjectsResponseProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.OrganizationProjectsResponseProjectDatabase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1GetServicesHealthService>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1ProjectWithDatabaseResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.OrganizationResponseV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.ApiKeyResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.BranchResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.SecretResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1ServiceHealthResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.ThirdPartyAuth>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.FunctionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1StorageBucketResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.SupavisorConfigResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1OrganizationMemberResponse>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}