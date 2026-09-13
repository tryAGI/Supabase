
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetListOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.SnippetListOutputDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetListOutputDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetListOutputDataItemType), TypeInfoPropertyName = "SnippetListOutputDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetListOutputDataItemVisibility), TypeInfoPropertyName = "SnippetListOutputDataItemVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetListOutputDataItemProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetListOutputDataItemOwner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetListOutputDataItemUpdatedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponseOutputType), TypeInfoPropertyName = "SnippetResponseOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponseOutputVisibility), TypeInfoPropertyName = "SnippetResponseOutputVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponseOutputProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponseOutputOwner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponseOutputUpdatedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponseOutputContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAccessRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAccessRequestRequestState), TypeInfoPropertyName = "JitAccessRequestRequestState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SslEnforcementResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SslEnforcementResponseOutputCurrentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SslEnforcementRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SslEnforcementRequestRequestedConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.TypescriptResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.PlanGateErrorBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.PlanGateErrorBodyError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.PlanGateErrorBodyErrorCode), TypeInfoPropertyName = "PlanGateErrorBodyErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ReadOnlyStatusResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SetUpReadReplicaBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SetUpReadReplicaBodyReadReplicaRegion), TypeInfoPropertyName = "SetUpReadReplicaBodyReadReplicaRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.RemoveReadReplicaBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateRoleBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateRoleResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DeleteRolesResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DeleteRolesResponseOutputMessage), TypeInfoPropertyName = "DeleteRolesResponseOutputMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1ListMigrationsResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListMigrationsResponseOutputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1CreateMigrationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpsertMigrationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetMigrationResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1PatchMigrationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RunQueryBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ReadOnlyQueryBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProjectDbMetadataResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.GetProjectDbMetadataResponseOutputDatabase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProjectDbMetadataResponseOutputDatabase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.GetProjectDbMetadataResponseOutputDatabaseSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.GetProjectDbMetadataResponseOutputDatabaseSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpdatePasswordBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpdatePasswordResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAccessResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseOutputUserRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAccessResponseOutputUserRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAccessResponseOutputUserRoleAllowedNetworks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseOutputUserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAccessResponseOutputUserRoleAllowedNetworksAllowedCidr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitAccessResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAccessResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AuthorizeJitAccessBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAuthorizeAccessResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAuthorizeAccessResponseOutputUserRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAuthorizeAccessResponseOutputUserRoleAllowedNetworks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitAuthorizeAccessResponseOutputUserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAuthorizeAccessResponseOutputUserRoleAllowedNetworksAllowedCidr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitAuthorizeAccessResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAuthorizeAccessResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.AnyOf<global::Supabase.JitListAccessResponseOutputItemVariant1, global::Supabase.JitListAccessResponseOutputItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnyOf<global::Supabase.JitListAccessResponseOutputItemVariant1, global::Supabase.JitListAccessResponseOutputItemVariant2>), TypeInfoPropertyName = "AnyOfJitListAccessResponseOutputItemVariant1JitListAccessResponseOutputItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseOutputItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseOutputItemVariant1UserRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseOutputItemVariant1UserRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseOutputItemVariant1UserRoleAllowedNetworks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseOutputItemVariant1UserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseOutputItemVariant1UserRoleAllowedNetworksAllowedCidr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseOutputItemVariant1UserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseOutputItemVariant1UserRoleAllowedNetworksAllowedCidrsV6Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseOutputItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseOutputItemVariant2UserRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseOutputItemVariant2UserRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseOutputItemVariant2UserRoleAllowedNetworks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseOutputItemVariant2UserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseOutputItemVariant2UserRoleAllowedNetworksAllowedCidr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.JitListAccessResponseOutputItemVariant2UserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitListAccessResponseOutputItemVariant2UserRoleAllowedNetworksAllowedCidrsV6Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateJitAccessBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.UpdateJitAccessBodyRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateJitAccessBodyRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateJitAccessBodyRoleAllowedNetworks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.InviteExternalUserJitAccessBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitAccessBodyRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.InviteExternalUserJitAccessBodyRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.InviteExternalUserJitAccessBodyRoleAllowedNetworks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitAccessBodyRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.InviteExternalUserJitAccessBodyRoleAllowedNetworksAllowedCidr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.InviteExternalUserJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.InviteExternalUserJitResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitResponseOutputUserRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.InviteExternalUserJitResponseOutputUserRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.InviteExternalUserJitResponseOutputUserRoleAllowedNetworks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitResponseOutputUserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.InviteExternalUserJitResponseOutputUserRoleAllowedNetworksAllowedCidr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.InviteExternalUserJitResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AcceptInviteExternalUserJitAccessBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1PgbouncerConfigResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1PgbouncerConfigResponseOutputPoolMode), TypeInfoPropertyName = "V1PgbouncerConfigResponseOutputPoolMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SupavisorConfigResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SupavisorConfigResponseOutputDatabaseType), TypeInfoPropertyName = "SupavisorConfigResponseOutputDatabaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SupavisorConfigResponseOutputPoolMode), TypeInfoPropertyName = "SupavisorConfigResponseOutputPoolMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateSupavisorConfigBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateSupavisorConfigBodyPoolMode), TypeInfoPropertyName = "UpdateSupavisorConfigBodyPoolMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateSupavisorConfigResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.PostgresConfigResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.PostgresConfigResponseOutputSessionReplicationRole), TypeInfoPropertyName = "PostgresConfigResponseOutputSessionReplicationRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdatePostgresConfigBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdatePostgresConfigBodySessionReplicationRole), TypeInfoPropertyName = "UpdatePostgresConfigBodySessionReplicationRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1BackupsResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1BackupsResponseOutputBackup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1BackupsResponseOutputBackup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1BackupsResponseOutputBackupStatus), TypeInfoPropertyName = "V1BackupsResponseOutputBackupStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1BackupsResponseOutputPhysicalBackupData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RestorePitrBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RestorePointPostBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RestorePointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RestorePointResponseStatus), TypeInfoPropertyName = "V1RestorePointResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RestoreBackupBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1BackupScheduleResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpdateBackupScheduleBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UndoBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListAllSnippetsSortBy), TypeInfoPropertyName = "V1ListAllSnippetsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListAllSnippetsSortOrder), TypeInfoPropertyName = "V1ListAllSnippetsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<global::Supabase.V1GetJitAccessConfigResponseVariant1, global::Supabase.V1GetJitAccessConfigResponseVariant2>), TypeInfoPropertyName = "OneOfV1GetJitAccessConfigResponseVariant1V1GetJitAccessConfigResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetJitAccessConfigResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetJitAccessConfigResponseVariant1State), TypeInfoPropertyName = "V1GetJitAccessConfigResponseVariant1State2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetJitAccessConfigResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetJitAccessConfigResponseVariant2UnavailableReason), TypeInfoPropertyName = "V1GetJitAccessConfigResponseVariant2UnavailableReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<global::Supabase.V1UpdateJitAccessConfigResponseVariant1, global::Supabase.V1UpdateJitAccessConfigResponseVariant2>), TypeInfoPropertyName = "OneOfV1UpdateJitAccessConfigResponseVariant1V1UpdateJitAccessConfigResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpdateJitAccessConfigResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpdateJitAccessConfigResponseVariant1State), TypeInfoPropertyName = "V1UpdateJitAccessConfigResponseVariant1State2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpdateJitAccessConfigResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpdateJitAccessConfigResponseVariant2UnavailableReason), TypeInfoPropertyName = "V1UpdateJitAccessConfigResponseVariant2UnavailableReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.SupavisorConfigResponseOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetListOutputDataItemType?), TypeInfoPropertyName = "NullableSnippetListOutputDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetListOutputDataItemVisibility?), TypeInfoPropertyName = "NullableSnippetListOutputDataItemVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponseOutputType?), TypeInfoPropertyName = "NullableSnippetResponseOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SnippetResponseOutputVisibility?), TypeInfoPropertyName = "NullableSnippetResponseOutputVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.JitAccessRequestRequestState?), TypeInfoPropertyName = "NullableJitAccessRequestRequestState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.PlanGateErrorBodyErrorCode?), TypeInfoPropertyName = "NullablePlanGateErrorBodyErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SetUpReadReplicaBodyReadReplicaRegion?), TypeInfoPropertyName = "NullableSetUpReadReplicaBodyReadReplicaRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.DeleteRolesResponseOutputMessage?), TypeInfoPropertyName = "NullableDeleteRolesResponseOutputMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnyOf<global::Supabase.JitListAccessResponseOutputItemVariant1, global::Supabase.JitListAccessResponseOutputItemVariant2>?), TypeInfoPropertyName = "NullableAnyOfJitListAccessResponseOutputItemVariant1JitListAccessResponseOutputItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1PgbouncerConfigResponseOutputPoolMode?), TypeInfoPropertyName = "NullableV1PgbouncerConfigResponseOutputPoolMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SupavisorConfigResponseOutputDatabaseType?), TypeInfoPropertyName = "NullableSupavisorConfigResponseOutputDatabaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.SupavisorConfigResponseOutputPoolMode?), TypeInfoPropertyName = "NullableSupavisorConfigResponseOutputPoolMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateSupavisorConfigBodyPoolMode?), TypeInfoPropertyName = "NullableUpdateSupavisorConfigBodyPoolMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.PostgresConfigResponseOutputSessionReplicationRole?), TypeInfoPropertyName = "NullablePostgresConfigResponseOutputSessionReplicationRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdatePostgresConfigBodySessionReplicationRole?), TypeInfoPropertyName = "NullableUpdatePostgresConfigBodySessionReplicationRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1BackupsResponseOutputBackupStatus?), TypeInfoPropertyName = "NullableV1BackupsResponseOutputBackupStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1RestorePointResponseStatus?), TypeInfoPropertyName = "NullableV1RestorePointResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListAllSnippetsSortBy?), TypeInfoPropertyName = "NullableV1ListAllSnippetsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListAllSnippetsSortOrder?), TypeInfoPropertyName = "NullableV1ListAllSnippetsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<global::Supabase.V1GetJitAccessConfigResponseVariant1, global::Supabase.V1GetJitAccessConfigResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfV1GetJitAccessConfigResponseVariant1V1GetJitAccessConfigResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetJitAccessConfigResponseVariant1State?), TypeInfoPropertyName = "NullableV1GetJitAccessConfigResponseVariant1State2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetJitAccessConfigResponseVariant2UnavailableReason?), TypeInfoPropertyName = "NullableV1GetJitAccessConfigResponseVariant2UnavailableReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OneOf<global::Supabase.V1UpdateJitAccessConfigResponseVariant1, global::Supabase.V1UpdateJitAccessConfigResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfV1UpdateJitAccessConfigResponseVariant1V1UpdateJitAccessConfigResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpdateJitAccessConfigResponseVariant1State?), TypeInfoPropertyName = "NullableV1UpdateJitAccessConfigResponseVariant1State2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1UpdateJitAccessConfigResponseVariant2UnavailableReason?), TypeInfoPropertyName = "NullableV1UpdateJitAccessConfigResponseVariant2UnavailableReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.SnippetListOutputDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1ListMigrationsResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.GetProjectDbMetadataResponseOutputDatabase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.GetProjectDbMetadataResponseOutputDatabaseSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitAccessResponseOutputUserRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitAccessResponseOutputUserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitAccessResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitAuthorizeAccessResponseOutputUserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitAuthorizeAccessResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.AnyOf<global::Supabase.JitListAccessResponseOutputItemVariant1, global::Supabase.JitListAccessResponseOutputItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseOutputItemVariant1UserRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseOutputItemVariant1UserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseOutputItemVariant1UserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseOutputItemVariant2UserRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseOutputItemVariant2UserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.JitListAccessResponseOutputItemVariant2UserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.UpdateJitAccessBodyRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.UpdateJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.InviteExternalUserJitAccessBodyRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.InviteExternalUserJitAccessBodyRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.InviteExternalUserJitAccessBodyRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.InviteExternalUserJitResponseOutputUserRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.InviteExternalUserJitResponseOutputUserRoleAllowedNetworksAllowedCidr>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.InviteExternalUserJitResponseOutputUserRoleAllowedNetworksAllowedCidrsV6Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1BackupsResponseOutputBackup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.SupavisorConfigResponseOutput>))]
    internal sealed partial class DatabaseSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatabaseSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DatabaseSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DatabaseSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<global::Supabase.JitListAccessResponseOutputItemVariant1, global::Supabase.JitListAccessResponseOutputItemVariant2>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.V1GetJitAccessConfigResponseVariant1, global::Supabase.V1GetJitAccessConfigResponseVariant2>());
            options.Converters.Add(new global::Supabase.JsonConverters.OneOfJsonConverter<global::Supabase.V1UpdateJitAccessConfigResponseVariant1, global::Supabase.V1UpdateJitAccessConfigResponseVariant2>());
            options.Converters.Add(new global::Supabase.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Supabase.SnippetListOutputDataItemType)

                    || typeToConvert == typeof(global::Supabase.SnippetListOutputDataItemType?)

                    || typeToConvert == typeof(global::Supabase.SnippetListOutputDataItemVisibility)

                    || typeToConvert == typeof(global::Supabase.SnippetListOutputDataItemVisibility?)

                    || typeToConvert == typeof(global::Supabase.SnippetResponseOutputType)

                    || typeToConvert == typeof(global::Supabase.SnippetResponseOutputType?)

                    || typeToConvert == typeof(global::Supabase.SnippetResponseOutputVisibility)

                    || typeToConvert == typeof(global::Supabase.SnippetResponseOutputVisibility?)

                    || typeToConvert == typeof(global::Supabase.JitAccessRequestRequestState)

                    || typeToConvert == typeof(global::Supabase.JitAccessRequestRequestState?)

                    || typeToConvert == typeof(global::Supabase.PlanGateErrorBodyErrorCode)

                    || typeToConvert == typeof(global::Supabase.PlanGateErrorBodyErrorCode?)

                    || typeToConvert == typeof(global::Supabase.SetUpReadReplicaBodyReadReplicaRegion)

                    || typeToConvert == typeof(global::Supabase.SetUpReadReplicaBodyReadReplicaRegion?)

                    || typeToConvert == typeof(global::Supabase.DeleteRolesResponseOutputMessage)

                    || typeToConvert == typeof(global::Supabase.DeleteRolesResponseOutputMessage?)

                    || typeToConvert == typeof(global::Supabase.V1PgbouncerConfigResponseOutputPoolMode)

                    || typeToConvert == typeof(global::Supabase.V1PgbouncerConfigResponseOutputPoolMode?)

                    || typeToConvert == typeof(global::Supabase.SupavisorConfigResponseOutputDatabaseType)

                    || typeToConvert == typeof(global::Supabase.SupavisorConfigResponseOutputDatabaseType?)

                    || typeToConvert == typeof(global::Supabase.SupavisorConfigResponseOutputPoolMode)

                    || typeToConvert == typeof(global::Supabase.SupavisorConfigResponseOutputPoolMode?)

                    || typeToConvert == typeof(global::Supabase.UpdateSupavisorConfigBodyPoolMode)

                    || typeToConvert == typeof(global::Supabase.UpdateSupavisorConfigBodyPoolMode?)

                    || typeToConvert == typeof(global::Supabase.PostgresConfigResponseOutputSessionReplicationRole)

                    || typeToConvert == typeof(global::Supabase.PostgresConfigResponseOutputSessionReplicationRole?)

                    || typeToConvert == typeof(global::Supabase.UpdatePostgresConfigBodySessionReplicationRole)

                    || typeToConvert == typeof(global::Supabase.UpdatePostgresConfigBodySessionReplicationRole?)

                    || typeToConvert == typeof(global::Supabase.V1BackupsResponseOutputBackupStatus)

                    || typeToConvert == typeof(global::Supabase.V1BackupsResponseOutputBackupStatus?)

                    || typeToConvert == typeof(global::Supabase.V1RestorePointResponseStatus)

                    || typeToConvert == typeof(global::Supabase.V1RestorePointResponseStatus?)

                    || typeToConvert == typeof(global::Supabase.V1ListAllSnippetsSortBy)

                    || typeToConvert == typeof(global::Supabase.V1ListAllSnippetsSortBy?)

                    || typeToConvert == typeof(global::Supabase.V1ListAllSnippetsSortOrder)

                    || typeToConvert == typeof(global::Supabase.V1ListAllSnippetsSortOrder?)

                    || typeToConvert == typeof(global::Supabase.V1GetJitAccessConfigResponseVariant1State)

                    || typeToConvert == typeof(global::Supabase.V1GetJitAccessConfigResponseVariant1State?)

                    || typeToConvert == typeof(global::Supabase.V1GetJitAccessConfigResponseVariant2UnavailableReason)

                    || typeToConvert == typeof(global::Supabase.V1GetJitAccessConfigResponseVariant2UnavailableReason?)

                    || typeToConvert == typeof(global::Supabase.V1UpdateJitAccessConfigResponseVariant1State)

                    || typeToConvert == typeof(global::Supabase.V1UpdateJitAccessConfigResponseVariant1State?)

                    || typeToConvert == typeof(global::Supabase.V1UpdateJitAccessConfigResponseVariant2UnavailableReason)

                    || typeToConvert == typeof(global::Supabase.V1UpdateJitAccessConfigResponseVariant2UnavailableReason?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Supabase.SnippetListOutputDataItemType))
                {
                    return new global::Supabase.JsonConverters.SnippetListOutputDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.SnippetListOutputDataItemType?))
                {
                    return new global::Supabase.JsonConverters.SnippetListOutputDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.SnippetListOutputDataItemVisibility))
                {
                    return new global::Supabase.JsonConverters.SnippetListOutputDataItemVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.SnippetListOutputDataItemVisibility?))
                {
                    return new global::Supabase.JsonConverters.SnippetListOutputDataItemVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.SnippetResponseOutputType))
                {
                    return new global::Supabase.JsonConverters.SnippetResponseOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.SnippetResponseOutputType?))
                {
                    return new global::Supabase.JsonConverters.SnippetResponseOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.SnippetResponseOutputVisibility))
                {
                    return new global::Supabase.JsonConverters.SnippetResponseOutputVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.SnippetResponseOutputVisibility?))
                {
                    return new global::Supabase.JsonConverters.SnippetResponseOutputVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.JitAccessRequestRequestState))
                {
                    return new global::Supabase.JsonConverters.JitAccessRequestRequestStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.JitAccessRequestRequestState?))
                {
                    return new global::Supabase.JsonConverters.JitAccessRequestRequestStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.PlanGateErrorBodyErrorCode))
                {
                    return new global::Supabase.JsonConverters.PlanGateErrorBodyErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.PlanGateErrorBodyErrorCode?))
                {
                    return new global::Supabase.JsonConverters.PlanGateErrorBodyErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.SetUpReadReplicaBodyReadReplicaRegion))
                {
                    return new global::Supabase.JsonConverters.SetUpReadReplicaBodyReadReplicaRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.SetUpReadReplicaBodyReadReplicaRegion?))
                {
                    return new global::Supabase.JsonConverters.SetUpReadReplicaBodyReadReplicaRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.DeleteRolesResponseOutputMessage))
                {
                    return new global::Supabase.JsonConverters.DeleteRolesResponseOutputMessageJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.DeleteRolesResponseOutputMessage?))
                {
                    return new global::Supabase.JsonConverters.DeleteRolesResponseOutputMessageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1PgbouncerConfigResponseOutputPoolMode))
                {
                    return new global::Supabase.JsonConverters.V1PgbouncerConfigResponseOutputPoolModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1PgbouncerConfigResponseOutputPoolMode?))
                {
                    return new global::Supabase.JsonConverters.V1PgbouncerConfigResponseOutputPoolModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.SupavisorConfigResponseOutputDatabaseType))
                {
                    return new global::Supabase.JsonConverters.SupavisorConfigResponseOutputDatabaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.SupavisorConfigResponseOutputDatabaseType?))
                {
                    return new global::Supabase.JsonConverters.SupavisorConfigResponseOutputDatabaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.SupavisorConfigResponseOutputPoolMode))
                {
                    return new global::Supabase.JsonConverters.SupavisorConfigResponseOutputPoolModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.SupavisorConfigResponseOutputPoolMode?))
                {
                    return new global::Supabase.JsonConverters.SupavisorConfigResponseOutputPoolModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateSupavisorConfigBodyPoolMode))
                {
                    return new global::Supabase.JsonConverters.UpdateSupavisorConfigBodyPoolModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateSupavisorConfigBodyPoolMode?))
                {
                    return new global::Supabase.JsonConverters.UpdateSupavisorConfigBodyPoolModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.PostgresConfigResponseOutputSessionReplicationRole))
                {
                    return new global::Supabase.JsonConverters.PostgresConfigResponseOutputSessionReplicationRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.PostgresConfigResponseOutputSessionReplicationRole?))
                {
                    return new global::Supabase.JsonConverters.PostgresConfigResponseOutputSessionReplicationRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdatePostgresConfigBodySessionReplicationRole))
                {
                    return new global::Supabase.JsonConverters.UpdatePostgresConfigBodySessionReplicationRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdatePostgresConfigBodySessionReplicationRole?))
                {
                    return new global::Supabase.JsonConverters.UpdatePostgresConfigBodySessionReplicationRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1BackupsResponseOutputBackupStatus))
                {
                    return new global::Supabase.JsonConverters.V1BackupsResponseOutputBackupStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1BackupsResponseOutputBackupStatus?))
                {
                    return new global::Supabase.JsonConverters.V1BackupsResponseOutputBackupStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1RestorePointResponseStatus))
                {
                    return new global::Supabase.JsonConverters.V1RestorePointResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1RestorePointResponseStatus?))
                {
                    return new global::Supabase.JsonConverters.V1RestorePointResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ListAllSnippetsSortBy))
                {
                    return new global::Supabase.JsonConverters.V1ListAllSnippetsSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ListAllSnippetsSortBy?))
                {
                    return new global::Supabase.JsonConverters.V1ListAllSnippetsSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ListAllSnippetsSortOrder))
                {
                    return new global::Supabase.JsonConverters.V1ListAllSnippetsSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ListAllSnippetsSortOrder?))
                {
                    return new global::Supabase.JsonConverters.V1ListAllSnippetsSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1GetJitAccessConfigResponseVariant1State))
                {
                    return new global::Supabase.JsonConverters.V1GetJitAccessConfigResponseVariant1StateJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1GetJitAccessConfigResponseVariant1State?))
                {
                    return new global::Supabase.JsonConverters.V1GetJitAccessConfigResponseVariant1StateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1GetJitAccessConfigResponseVariant2UnavailableReason))
                {
                    return new global::Supabase.JsonConverters.V1GetJitAccessConfigResponseVariant2UnavailableReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1GetJitAccessConfigResponseVariant2UnavailableReason?))
                {
                    return new global::Supabase.JsonConverters.V1GetJitAccessConfigResponseVariant2UnavailableReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1UpdateJitAccessConfigResponseVariant1State))
                {
                    return new global::Supabase.JsonConverters.V1UpdateJitAccessConfigResponseVariant1StateJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1UpdateJitAccessConfigResponseVariant1State?))
                {
                    return new global::Supabase.JsonConverters.V1UpdateJitAccessConfigResponseVariant1StateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1UpdateJitAccessConfigResponseVariant2UnavailableReason))
                {
                    return new global::Supabase.JsonConverters.V1UpdateJitAccessConfigResponseVariant2UnavailableReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1UpdateJitAccessConfigResponseVariant2UnavailableReason?))
                {
                    return new global::Supabase.JsonConverters.V1UpdateJitAccessConfigResponseVariant2UnavailableReasonNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new DatabaseSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}