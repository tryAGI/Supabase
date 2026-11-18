
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BranchDetailResponseOutput? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BranchDetailResponseOutputStatus? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateBranchBody? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateBranchBodyStatus? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BranchResponseOutput? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BranchResponseOutputStatus? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BranchResponseOutputPreviewProjectStatus? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.PlanGateErrorBody? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.PlanGateErrorBodyError? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.PlanGateErrorBodyErrorCode? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BranchDeleteResponseOutput? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BranchDeleteResponseOutputMessage? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BranchActionBody? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BranchUpdateResponseOutput? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BranchUpdateResponseOutputMessage? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BranchRestoreResponseOutput? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BranchRestoreResponseOutputMessage? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ProjectWithDatabaseResponseOutput? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ProjectWithDatabaseResponseOutputStatus? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ProjectWithDatabaseResponseOutputDatabase? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1CreateProjectBody? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1CreateProjectBodyPlan? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1CreateProjectBodyRegion? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OneOf<global::Supabase.V1CreateProjectBodyRegionSelectionVariant1, global::Supabase.V1CreateProjectBodyRegionSelectionVariant2>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1CreateProjectBodyRegionSelectionVariant1? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1CreateProjectBodyRegionSelectionVariant1Type? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1CreateProjectBodyRegionSelectionVariant1Code? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1CreateProjectBodyRegionSelectionVariant2? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1CreateProjectBodyRegionSelectionVariant2Type? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1CreateProjectBodyRegionSelectionVariant2Code? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1CreateProjectBodyDesiredInstanceSize? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ProjectResponseOutput? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ProjectResponseOutputStatus? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1Output? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputRecommendations? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputRecommendationsSmartGroup? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputRecommendationsSmartGroupCode? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputRecommendationsSmartGroupType? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.RegionsInfoV1OutputRecommendationsSpecificItem>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputRecommendationsSpecificItem? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputRecommendationsSpecificItemCode? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputRecommendationsSpecificItemType? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputRecommendationsSpecificItemProvider? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputRecommendationsSpecificItemStatus? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputAll? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.RegionsInfoV1OutputAllSmartGroupItem>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputAllSmartGroupItem? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputAllSmartGroupItemCode? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputAllSmartGroupItemType? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.RegionsInfoV1OutputAllSpecificItem>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputAllSpecificItem? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputAllSpecificItemCode? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputAllSpecificItemType? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputAllSpecificItemProvider? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RegionsInfoV1OutputAllSpecificItemStatus? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationResponseV1Output? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateOrganizationV1? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OAuthTokenBody? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OAuthTokenBodyGrantType? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OAuthTokenResponseOutput? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OAuthTokenResponseOutputTokenType? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OAuthRevokeTokenBody? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SnippetListOutput? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.SnippetListOutputDataItem>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SnippetListOutputDataItem? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SnippetListOutputDataItemType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SnippetListOutputDataItemVisibility? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SnippetListOutputDataItemProject? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SnippetListOutputDataItemOwner? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SnippetListOutputDataItemUpdatedBy? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SnippetResponseOutput? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SnippetResponseOutputType? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SnippetResponseOutputVisibility? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SnippetResponseOutputProject? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SnippetResponseOutputOwner? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SnippetResponseOutputUpdatedBy? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SnippetResponseOutputContent? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ProfileResponseOutput? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.ListActionRunResponseOutputItem>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListActionRunResponseOutputItem? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.ListActionRunResponseOutputItemRunStep>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListActionRunResponseOutputItemRunStep? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListActionRunResponseOutputItemRunStepName? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListActionRunResponseOutputItemRunStepStatus? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ActionRunResponseOutput? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.ActionRunResponseOutputRunStep>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ActionRunResponseOutputRunStep? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ActionRunResponseOutputRunStepName? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ActionRunResponseOutputRunStepStatus? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateRunStatusBody? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateRunStatusBodyClone? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateRunStatusBodyPull? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateRunStatusBodyHealth? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateRunStatusBodyConfigure? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateRunStatusBodyMigrate? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateRunStatusBodySeed? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateRunStatusBodyDeploy? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateRunStatusResponseOutput? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateRunStatusResponseOutputMessage? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ApiKeyResponseOutput? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ApiKeyResponseOutputType? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.LegacyApiKeysResponseOutput? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateApiKeyBody? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateApiKeyBodyType? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateApiKeyBody? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateBranchBody? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateBranchBodyDesiredInstanceSize? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateBranchBodyReleaseChannel? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateBranchBodyPostgresEngine? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JsonValueOutput? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput?>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Supabase.JsonValueOutput?>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateCustomHostnameResponseOutput? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateCustomHostnameResponseOutputStatus? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateCustomHostnameResponseOutputData? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateCustomHostnameResponseOutputDataResult? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateCustomHostnameResponseOutputDataResultSsl? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseOutputDataResultSslValidationRecord>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateCustomHostnameResponseOutputDataResultSslValidationRecord? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.UpdateCustomHostnameResponseOutputDataResultSslValidationError>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateCustomHostnameResponseOutputDataResultSslValidationError? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateCustomHostnameResponseOutputDataResultOwnershipVerification? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateCustomHostnameBody? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitAccessRequestRequest? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitAccessRequestRequestState? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkBanResponseOutput? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkBanResponseEnrichedOutput? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.NetworkBanResponseEnrichedOutputBannedIpv4Addresse>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkBanResponseEnrichedOutputBannedIpv4Addresse? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RemoveNetworkBanRequest? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsResponseOutput? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsResponseOutputEntitlement? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsResponseOutputConfig? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsResponseOutputOldConfig? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsResponseOutputPendingConfig? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsResponseOutputStatus? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsRequest? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsPatchRequest? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsPatchRequestAdd? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsPatchRequestRemove? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsV2ResponseOutput? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsV2ResponseOutputEntitlement? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsV2ResponseOutputConfig? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.NetworkRestrictionsV2ResponseOutputConfigDbAllowedCidr>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsV2ResponseOutputConfigDbAllowedCidr? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsV2ResponseOutputConfigDbAllowedCidrType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsV2ResponseOutputOldConfig? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.NetworkRestrictionsV2ResponseOutputOldConfigDbAllowedCidr>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsV2ResponseOutputOldConfigDbAllowedCidr? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsV2ResponseOutputOldConfigDbAllowedCidrType? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsV2ResponseOutputStatus? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsReviewRequest? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.NetworkRestrictionsReviewRequestAction? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.PgsodiumConfigResponseOutput? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdatePgsodiumConfigBody? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.PostgrestConfigWithJWTSecretResponseOutput? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1UpdatePostgrestConfigBody? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1PostgrestConfigResponseOutput? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ProjectRefResponseOutput? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1UpdateProjectBody? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SecretResponseOutput? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.CreateSecretBodyItem>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSecretBodyItem? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SslEnforcementResponseOutput? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SslEnforcementResponseOutputCurrentConfig? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SslEnforcementRequest? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SslEnforcementRequestRequestedConfig? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.TypescriptResponseOutput? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.VanitySubdomainConfigResponseOutput? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.VanitySubdomainConfigResponseOutputStatus? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.VanitySubdomainBody? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SubdomainAvailabilityResponseOutput? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ActivateVanitySubdomainResponseOutput? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpgradeDatabaseBody? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpgradeDatabaseBodyReleaseChannel? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeInitiateResponseOutput? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutput? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputCurrentAppVersionReleaseChannel? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersion>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersion? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionPostgresVersion? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersionReleaseChannel? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant1Type? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant2? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant2Type? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant3? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant3Type? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant4Type? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant5? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant5Type? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant6? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant6Type? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7Type? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant1? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant7ObjTypeVariant2? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant8? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant8Type? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant9Type? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant10? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant10Type? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant11? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputValidationErrorVariant11Type? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant1? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant1Type? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant2? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant2Type? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant3? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant3Type? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant4? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant4Type? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant5? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectUpgradeEligibilityResponseOutputWarningVariant5Type? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DatabaseUpgradeStatusResponseOutput? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatus? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusError? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DatabaseUpgradeStatusResponseOutputDatabaseUpgradeStatusProgress? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ReadOnlyStatusResponseOutput? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SetUpReadReplicaBody? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SetUpReadReplicaBodyReadReplicaRegion? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RemoveReadReplicaBody? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ServiceHealthResponseOutput? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ServiceHealthResponseOutputName? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ServiceHealthResponseOutputStatus? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ServiceHealthResponseOutputInfoVariant1? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ServiceHealthResponseOutputInfoVariant1Name? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ServiceHealthResponseOutputInfoVariant2? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ServiceHealthResponseOutputInfoVariant3? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SigningKeyResponseOutput? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SigningKeyResponseOutputAlgorithm? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SigningKeyResponseOutputStatus? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBody? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyAlgorithm? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyStatus? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1Use? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1KeyOp>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1KeyOp? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1Kty? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1Alg? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1E? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Use? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2KeyOp>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2KeyOp? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Kty? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Alg? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2Crv? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3Use? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3KeyOp>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3KeyOp? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3Kty? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3Alg? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3Crv? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4Use? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4KeyOp>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4KeyOp? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4Kty? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4Alg? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SigningKeysResponseOutput? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.SigningKeysResponseOutputKey>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SigningKeysResponseOutputKey? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SigningKeysResponseOutputKeyAlgorithm? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SigningKeysResponseOutputKeyStatus? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateSigningKeyBody? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateSigningKeyBodyStatus? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AuthConfigResponseOutput? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AuthConfigResponseOutputDbMaxPoolSizeUnit? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AuthConfigResponseOutputPasswordRequiredCharacters? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AuthConfigResponseOutputSecurityCaptchaProvider? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AuthConfigResponseOutputSmsProvider? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateAuthConfigBody? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateAuthConfigBodySecurityCaptchaProvider? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateAuthConfigBodyPasswordRequiredCharacters? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateAuthConfigBodySmsProvider? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateAuthConfigBodyDbMaxPoolSizeUnit? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateThirdPartyAuthBody? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ThirdPartyAuthOutput? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.GetProjectAvailableRestoreVersionsResponseOutput? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.GetProjectAvailableRestoreVersionsResponseOutputAvailableVersion>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.GetProjectAvailableRestoreVersionsResponseOutputAvailableVersion? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionReleaseChannel? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.GetProjectAvailableRestoreVersionsResponseOutputAvailableVersionPostgresEngine? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutput? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseOutputSelectedAddon>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputSelectedAddon? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputSelectedAddonType? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputSelectedAddonVariant? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant1? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant2? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant3? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant4? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant5? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant6? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant7? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputSelectedAddonVariantIdVariant8? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputSelectedAddonVariantPrice? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputSelectedAddonVariantPriceType? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputSelectedAddonVariantPriceInterval? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseOutputAvailableAddon>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputAvailableAddon? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputAvailableAddonType? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariant>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariant? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant1? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant2? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant3? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant4? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant5? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant6? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant7? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantIdVariant8? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantPrice? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantPriceType? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariantPriceInterval? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ApplyProjectAddonBody? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ApplyProjectAddonBodyAddonVariantVariant1? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ApplyProjectAddonBodyAddonVariantVariant2? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ApplyProjectAddonBodyAddonVariantVariant3? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ApplyProjectAddonBodyAddonVariantVariant4? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ApplyProjectAddonBodyAddonType? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ProjectClaimTokenResponseOutput? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateProjectClaimTokenResponseOutput? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ProjectAdvisorsResponseOutput? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1ProjectAdvisorsResponseOutputLint>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ProjectAdvisorsResponseOutputLint? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ProjectAdvisorsResponseOutputLintName? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ProjectAdvisorsResponseOutputLintLevel? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ProjectAdvisorsResponseOutputLintFacing? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1ProjectAdvisorsResponseOutputLintCategorie>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ProjectAdvisorsResponseOutputLintCategorie? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ProjectAdvisorsResponseOutputLintMetadata? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ProjectAdvisorsResponseOutputLintMetadataType? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AnalyticsResponseOutput? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AnyOf<string, global::Supabase.AnalyticsResponseOutputError>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AnalyticsResponseOutputError? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.AnalyticsResponseOutputErrorError>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AnalyticsResponseOutputErrorError? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetUsageApiCountResponseOutput? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiCountResponseOutputResultItem>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetUsageApiCountResponseOutputResultItem? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AnyOf<string, global::Supabase.V1GetUsageApiCountResponseOutputError>? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetUsageApiCountResponseOutputError? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiCountResponseOutputErrorError>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetUsageApiCountResponseOutputErrorError? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetUsageApiRequestsCountResponseOutput? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiRequestsCountResponseOutputResultItem>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetUsageApiRequestsCountResponseOutputResultItem? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AnyOf<string, global::Supabase.V1GetUsageApiRequestsCountResponseOutputError>? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetUsageApiRequestsCountResponseOutputError? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiRequestsCountResponseOutputErrorError>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetUsageApiRequestsCountResponseOutputErrorError? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateRoleBody? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateRoleResponseOutput? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DeleteRolesResponseOutput? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DeleteRolesResponseOutputMessage? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1ListMigrationsResponseOutputItem>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ListMigrationsResponseOutputItem? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1CreateMigrationBody? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1UpsertMigrationBody? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetMigrationResponseOutput? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1PatchMigrationBody? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1RunQueryBody? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ReadOnlyQueryBody? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.GetProjectDbMetadataResponseOutput? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.GetProjectDbMetadataResponseOutputDatabase>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.GetProjectDbMetadataResponseOutputDatabase? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.GetProjectDbMetadataResponseOutputDatabaseSchema>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.GetProjectDbMetadataResponseOutputDatabaseSchema? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1UpdatePasswordBody? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1UpdatePasswordResponseOutput? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitAccessResponseOutput? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseOutputUserRole>? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitAccessResponseOutputUserRole? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitAccessResponseOutputUserRoleAllowedNetworks? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseOutputUserRoleAllowedNetworksAllowedCidr>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitAccessResponseOutputUserRoleAllowedNetworksAllowedCidr? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitAccessResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AuthorizeJitAccessBody? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitAuthorizeAccessResponseOutput? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitAuthorizeAccessResponseOutputUserRole? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitAuthorizeAccessResponseOutputUserRoleAllowedNetworks? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.JitAuthorizeAccessResponseOutputUserRoleAllowedNetworksAllowedCidr>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitAuthorizeAccessResponseOutputUserRoleAllowedNetworksAllowedCidr? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.JitAuthorizeAccessResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitAuthorizeAccessResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitListAccessResponseOutput? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.AnyOf<global::Supabase.JitListAccessResponseOutputItemVariant1, global::Supabase.JitListAccessResponseOutputItemVariant2>>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AnyOf<global::Supabase.JitListAccessResponseOutputItemVariant1, global::Supabase.JitListAccessResponseOutputItemVariant2>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitListAccessResponseOutputItemVariant1? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseOutputItemVariant1UserRole>? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitListAccessResponseOutputItemVariant1UserRole? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitListAccessResponseOutputItemVariant1UserRoleAllowedNetworks? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseOutputItemVariant1UserRoleAllowedNetworksAllowedCidr>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitListAccessResponseOutputItemVariant1UserRoleAllowedNetworksAllowedCidr? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseOutputItemVariant1UserRoleAllowedNetworksAllowedCidrsV6Item>? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitListAccessResponseOutputItemVariant1UserRoleAllowedNetworksAllowedCidrsV6Item? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitListAccessResponseOutputItemVariant2? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseOutputItemVariant2UserRole>? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitListAccessResponseOutputItemVariant2UserRole? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitListAccessResponseOutputItemVariant2UserRoleAllowedNetworks? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseOutputItemVariant2UserRoleAllowedNetworksAllowedCidr>? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitListAccessResponseOutputItemVariant2UserRoleAllowedNetworksAllowedCidr? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseOutputItemVariant2UserRoleAllowedNetworksAllowedCidrsV6Item>? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.JitListAccessResponseOutputItemVariant2UserRoleAllowedNetworksAllowedCidrsV6Item? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateJitAccessBody? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.UpdateJitAccessBodyRole>? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateJitAccessBodyRole? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateJitAccessBodyRoleAllowedNetworks? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidr>? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidr? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item>? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.InviteExternalUserJitAccessBody? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitAccessBodyRole>? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.InviteExternalUserJitAccessBodyRole? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.InviteExternalUserJitAccessBodyRoleAllowedNetworks? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitAccessBodyRoleAllowedNetworksAllowedCidr>? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.InviteExternalUserJitAccessBodyRoleAllowedNetworksAllowedCidr? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item>? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.InviteExternalUserJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.InviteExternalUserJitResponseOutput? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitResponseOutputUserRole>? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.InviteExternalUserJitResponseOutputUserRole? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.InviteExternalUserJitResponseOutputUserRoleAllowedNetworks? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitResponseOutputUserRoleAllowedNetworksAllowedCidr>? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.InviteExternalUserJitResponseOutputUserRoleAllowedNetworksAllowedCidr? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item>? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.InviteExternalUserJitResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AcceptInviteExternalUserJitAccessBody? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.FunctionResponseOutput? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.FunctionResponseOutputStatus? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1CreateFunctionBody? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.BulkUpdateFunctionBodyItem>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BulkUpdateFunctionBodyItem? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BulkUpdateFunctionBodyItemStatus? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BulkUpdateFunctionResponseOutput? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.BulkUpdateFunctionResponseOutputFunction>? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BulkUpdateFunctionResponseOutputFunction? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.BulkUpdateFunctionResponseOutputFunctionStatus? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.FunctionDeployBody? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.FunctionDeployBodyMetadata? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DeployFunctionResponseOutput? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DeployFunctionResponseOutputStatus? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.FunctionSlugResponseOutput? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.FunctionSlugResponseOutputStatus? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.StreamableFile? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1UpdateFunctionBodyJson? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1StorageBucketResponseOutput? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DiskResponseOutput? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AnyOf<global::Supabase.DiskResponseOutputAttributesVariant1, global::Supabase.DiskResponseOutputAttributesVariant2>? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DiskResponseOutputAttributesVariant1? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DiskResponseOutputAttributesVariant1Type? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DiskResponseOutputAttributesVariant2? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DiskResponseOutputAttributesVariant2Type? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DiskRequestBody? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OneOf<global::Supabase.DiskRequestBodyAttributesVariant1, global::Supabase.DiskRequestBodyAttributesVariant2>? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DiskRequestBodyAttributesVariant1? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DiskRequestBodyAttributesVariant1Type? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DiskRequestBodyAttributesVariant2? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DiskRequestBodyAttributesVariant2Type? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DiskUtilMetricsResponseOutput? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DiskUtilMetricsResponseOutputMetrics? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DiskAutoscaleConfigOutput? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.StorageConfigResponseOutput? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.StorageConfigResponseOutputFeatures? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.StorageConfigResponseOutputFeaturesImageTransformation? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.StorageConfigResponseOutputFeaturesS3Protocol? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.StorageConfigResponseOutputFeaturesPurgeCache? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.StorageConfigResponseOutputFeaturesIcebergCatalog? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.StorageConfigResponseOutputFeaturesVectorBuckets? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.StorageConfigResponseOutputCapabilities? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.StorageConfigResponseOutputExternal? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.StorageConfigResponseOutputExternalUpstreamTarget? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateStorageConfigBody? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateStorageConfigBodyFeatures? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateStorageConfigBodyFeaturesImageTransformation? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateStorageConfigBodyFeaturesS3Protocol? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateStorageConfigBodyFeaturesPurgeCache? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateStorageConfigBodyFeaturesIcebergCatalog? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateStorageConfigBodyFeaturesVectorBuckets? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateStorageConfigBodyExternal? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateStorageConfigBodyExternalUpstreamTarget? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1PgbouncerConfigResponseOutput? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1PgbouncerConfigResponseOutputPoolMode? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SupavisorConfigResponseOutput? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SupavisorConfigResponseOutputDatabaseType? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.SupavisorConfigResponseOutputPoolMode? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateSupavisorConfigBody? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateSupavisorConfigBodyPoolMode? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateSupavisorConfigResponseOutput? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.PostgresConfigResponseOutput? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.PostgresConfigResponseOutputSessionReplicationRole? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdatePostgresConfigBody? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdatePostgresConfigBodySessionReplicationRole? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.RealtimeConfigResponseOutput? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateRealtimeConfigBody? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateProviderBody? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateProviderBodyType? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateProviderBodyAttributeMapping? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Supabase.CreateProviderBodyAttributeMappingKeys2>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateProviderBodyAttributeMappingKeys2? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AnyOf<object, double?, string, bool?>? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateProviderBodyNameIdFormat? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateProviderResponseOutput? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateProviderResponseOutputSaml? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateProviderResponseOutputSamlAttributeMapping? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Supabase.CreateProviderResponseOutputSamlAttributeMappingKeys2>? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateProviderResponseOutputSamlAttributeMappingKeys2? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateProviderResponseOutputSamlNameIdFormat? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.CreateProviderResponseOutputDomain>? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.CreateProviderResponseOutputDomain? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProvidersResponseOutput? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.ListProvidersResponseOutputItem>? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProvidersResponseOutputItem? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProvidersResponseOutputItemSaml? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProvidersResponseOutputItemSamlAttributeMapping? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Supabase.ListProvidersResponseOutputItemSamlAttributeMappingKeys2>? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProvidersResponseOutputItemSamlAttributeMappingKeys2? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProvidersResponseOutputItemSamlNameIdFormat? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.ListProvidersResponseOutputItemDomain>? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.ListProvidersResponseOutputItemDomain? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.GetProviderResponseOutput? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.GetProviderResponseOutputSaml? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.GetProviderResponseOutputSamlAttributeMapping? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Supabase.GetProviderResponseOutputSamlAttributeMappingKeys2>? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.GetProviderResponseOutputSamlAttributeMappingKeys2? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.GetProviderResponseOutputSamlNameIdFormat? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.GetProviderResponseOutputDomain>? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.GetProviderResponseOutputDomain? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateProviderBody? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateProviderBodyAttributeMapping? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Supabase.UpdateProviderBodyAttributeMappingKeys2>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateProviderBodyAttributeMappingKeys2? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateProviderBodyNameIdFormat? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateProviderResponseOutput? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateProviderResponseOutputSaml? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateProviderResponseOutputSamlAttributeMapping? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Supabase.UpdateProviderResponseOutputSamlAttributeMappingKeys2>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateProviderResponseOutputSamlAttributeMappingKeys2? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateProviderResponseOutputSamlNameIdFormat? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.UpdateProviderResponseOutputDomain>? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.UpdateProviderResponseOutputDomain? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DeleteProviderResponseOutput? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DeleteProviderResponseOutputSaml? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DeleteProviderResponseOutputSamlAttributeMapping? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Supabase.DeleteProviderResponseOutputSamlAttributeMappingKeys2>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DeleteProviderResponseOutputSamlAttributeMappingKeys2? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DeleteProviderResponseOutputSamlNameIdFormat? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.DeleteProviderResponseOutputDomain>? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.DeleteProviderResponseOutputDomain? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1BackupsResponseOutput? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1BackupsResponseOutputBackup>? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1BackupsResponseOutputBackup? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1BackupsResponseOutputBackupStatus? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1BackupsResponseOutputPhysicalBackupData? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1RestorePitrBody? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1RestorePointPostBody? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1RestorePointResponse? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1RestorePointResponseStatus? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1RestoreBackupBody? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1BackupScheduleResponseOutput? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1UpdateBackupScheduleBody? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1UndoBody? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ListEntitlementsResponseOutput? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1ListEntitlementsResponseOutputEntitlement>? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ListEntitlementsResponseOutputEntitlement? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeature? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureKey? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureType? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ListEntitlementsResponseOutputEntitlementType? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant1? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant2? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant3? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1OrganizationMemberResponseOutput? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1OrganizationSlugResponseOutput? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1OrganizationSlugResponseOutputPlan? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1OrganizationSlugResponseOutputOptInTag>? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1OrganizationSlugResponseOutputOptInTag? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1OrganizationSlugResponseOutputAllowedReleaseChannel>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1OrganizationSlugResponseOutputAllowedReleaseChannel? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectClaimResponseOutput? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectClaimResponseOutputProject? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectClaimResponseOutputPreview? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponseOutputPreviewWarning>? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectClaimResponseOutputPreviewWarning? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponseOutputPreviewError>? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectClaimResponseOutputPreviewError? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponseOutputPreviewInfoItem>? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectClaimResponseOutputPreviewInfoItem? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponseOutputPreviewMembersExceedingFreeProjectLimitItem>? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectClaimResponseOutputPreviewMembersExceedingFreeProjectLimitItem? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectsResponseOutput? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectsResponseOutputProject>? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectsResponseOutputProject? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectsResponseOutputProjectStatus? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectsResponseOutputProjectDatabase>? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectsResponseOutputProjectDatabase? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectsResponseOutputProjectDatabaseInfraComputeSize? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectsResponseOutputProjectDatabaseStatus? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectsResponseOutputProjectDatabaseType? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectsResponseOutputProjectDatabaseDiskType? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OrganizationProjectsResponseOutputPagination? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AnyOf<string, global::System.Guid?>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetAvailableRegionsContinent? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetAvailableRegionsDesiredInstanceSize? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1AuthorizeUserResponseType? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1AuthorizeUserCodeChallengeMethod? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1OauthAuthorizeProjectClaimResponseType? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1OauthAuthorizeProjectClaimCodeChallengeMethod? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ListAllSnippetsSortBy? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1ListAllSnippetsSortOrder? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AnyOf<string, global::System.Collections.Generic.IList<global::Supabase.V1GetServicesHealthServicesVariant2Item>>? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1GetServicesHealthServicesVariant2Item>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetServicesHealthServicesVariant2Item? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1RemoveProjectAddonAddonVariantVariant1? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1RemoveProjectAddonAddonVariantVariant2? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1RemoveProjectAddonAddonVariantVariant3? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1RemoveProjectAddonAddonVariantVariant4? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetSecurityAdvisorsLintType? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetProjectUsageApiCountInterval? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetProjectFunctionCombinedStatsInterval? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetAllProjectsForOrganizationSort? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1ProjectWithDatabaseResponseOutput>? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.OrganizationResponseV1Output>? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.ApiKeyResponseOutput>? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.BranchResponseOutput>? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OneOf<global::Supabase.V1GetJitAccessConfigResponseVariant1, global::Supabase.V1GetJitAccessConfigResponseVariant2>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetJitAccessConfigResponseVariant1? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetJitAccessConfigResponseVariant1State? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetJitAccessConfigResponseVariant2? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1GetJitAccessConfigResponseVariant2UnavailableReason? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.OneOf<global::Supabase.V1UpdateJitAccessConfigResponseVariant1, global::Supabase.V1UpdateJitAccessConfigResponseVariant2>? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1UpdateJitAccessConfigResponseVariant1? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1UpdateJitAccessConfigResponseVariant1State? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1UpdateJitAccessConfigResponseVariant2? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.V1UpdateJitAccessConfigResponseVariant2UnavailableReason? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.SecretResponseOutput>? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1ServiceHealthResponseOutput>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.ThirdPartyAuthOutput>? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.FunctionResponseOutput>? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1StorageBucketResponseOutput>? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.SupavisorConfigResponseOutput>? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Supabase.V1OrganizationMemberResponseOutput>? Type665 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.RegionsInfoV1OutputRecommendationsSpecificItem>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.RegionsInfoV1OutputAllSmartGroupItem>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.RegionsInfoV1OutputAllSpecificItem>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.SnippetListOutputDataItem>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.ListActionRunResponseOutputItem>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.ListActionRunResponseOutputItemRunStep>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.ActionRunResponseOutputRunStep>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.JsonValueOutput?>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.UpdateCustomHostnameResponseOutputDataResultSslValidationRecord>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.UpdateCustomHostnameResponseOutputDataResultSslValidationError>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.NetworkBanResponseEnrichedOutputBannedIpv4Addresse>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.NetworkRestrictionsV2ResponseOutputConfigDbAllowedCidr>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.NetworkRestrictionsV2ResponseOutputOldConfigDbAllowedCidr>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.CreateSecretBodyItem>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.ProjectUpgradeEligibilityResponseOutputTargetUpgradeVersion>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1KeyOp>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2KeyOp>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3KeyOp>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4KeyOp>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.SigningKeysResponseOutputKey>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.GetProjectAvailableRestoreVersionsResponseOutputAvailableVersion>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.ListProjectAddonsResponseOutputSelectedAddon>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.ListProjectAddonsResponseOutputAvailableAddon>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.ListProjectAddonsResponseOutputAvailableAddonVariant>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1ProjectAdvisorsResponseOutputLint>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1ProjectAdvisorsResponseOutputLintCategorie>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.AnalyticsResponseOutputErrorError>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1GetUsageApiCountResponseOutputResultItem>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1GetUsageApiCountResponseOutputErrorError>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1GetUsageApiRequestsCountResponseOutputResultItem>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1GetUsageApiRequestsCountResponseOutputErrorError>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1ListMigrationsResponseOutputItem>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.GetProjectDbMetadataResponseOutputDatabase>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.GetProjectDbMetadataResponseOutputDatabaseSchema>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.JitAccessResponseOutputUserRole>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.JitAccessResponseOutputUserRoleAllowedNetworksAllowedCidr>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.JitAccessResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.JitAuthorizeAccessResponseOutputUserRoleAllowedNetworksAllowedCidr>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.JitAuthorizeAccessResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.AnyOf<global::Supabase.JitListAccessResponseOutputItemVariant1, global::Supabase.JitListAccessResponseOutputItemVariant2>>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseOutputItemVariant1UserRole>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseOutputItemVariant1UserRoleAllowedNetworksAllowedCidr>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseOutputItemVariant1UserRoleAllowedNetworksAllowedCidrsV6Item>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseOutputItemVariant2UserRole>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseOutputItemVariant2UserRoleAllowedNetworksAllowedCidr>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseOutputItemVariant2UserRoleAllowedNetworksAllowedCidrsV6Item>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.UpdateJitAccessBodyRole>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidr>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.InviteExternalUserJitAccessBodyRole>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.InviteExternalUserJitAccessBodyRoleAllowedNetworksAllowedCidr>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.InviteExternalUserJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.InviteExternalUserJitResponseOutputUserRole>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.InviteExternalUserJitResponseOutputUserRoleAllowedNetworksAllowedCidr>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.InviteExternalUserJitResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.BulkUpdateFunctionBodyItem>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.BulkUpdateFunctionResponseOutputFunction>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.CreateProviderResponseOutputDomain>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.ListProvidersResponseOutputItem>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.ListProvidersResponseOutputItemDomain>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.GetProviderResponseOutputDomain>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.UpdateProviderResponseOutputDomain>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.DeleteProviderResponseOutputDomain>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1BackupsResponseOutputBackup>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1ListEntitlementsResponseOutputEntitlement>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1OrganizationSlugResponseOutputOptInTag>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1OrganizationSlugResponseOutputAllowedReleaseChannel>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.OrganizationProjectClaimResponseOutputPreviewWarning>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.OrganizationProjectClaimResponseOutputPreviewError>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.OrganizationProjectClaimResponseOutputPreviewInfoItem>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.OrganizationProjectClaimResponseOutputPreviewMembersExceedingFreeProjectLimitItem>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.OrganizationProjectsResponseOutputProject>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.OrganizationProjectsResponseOutputProjectDatabase>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Supabase.AnyOf<string, global::System.Collections.Generic.List<global::Supabase.V1GetServicesHealthServicesVariant2Item>>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1GetServicesHealthServicesVariant2Item>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1ProjectWithDatabaseResponseOutput>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.OrganizationResponseV1Output>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.ApiKeyResponseOutput>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.BranchResponseOutput>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.SecretResponseOutput>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1ServiceHealthResponseOutput>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.ThirdPartyAuthOutput>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.FunctionResponseOutput>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1StorageBucketResponseOutput>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.SupavisorConfigResponseOutput>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Supabase.V1OrganizationMemberResponseOutput>? ListType89 { get; set; }
    }
}