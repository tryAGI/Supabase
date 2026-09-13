
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnyOf<global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant1, global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant2, global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant3>), TypeInfoPropertyName = "V1ListEntitlementsResponseOutputEntitlementConfigVariant3_84922f95a0bffb43")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnyOf<global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant1, global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant2, global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant3>?), TypeInfoPropertyName = "V1ListEntitlementsResponseOutputEntitlementConfigVariant3_870ed66bed747865")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationResponseV1Output))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateOrganizationV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1ListEntitlementsResponseOutputEntitlement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeature))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureKey), TypeInfoPropertyName = "V1ListEntitlementsResponseOutputEntitlementFeatureKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureType), TypeInfoPropertyName = "V1ListEntitlementsResponseOutputEntitlementFeatureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementType), TypeInfoPropertyName = "V1ListEntitlementsResponseOutputEntitlementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OrganizationMemberResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OrganizationSlugResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OrganizationSlugResponseOutputPlan), TypeInfoPropertyName = "V1OrganizationSlugResponseOutputPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1OrganizationSlugResponseOutputOptInTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OrganizationSlugResponseOutputOptInTag), TypeInfoPropertyName = "V1OrganizationSlugResponseOutputOptInTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1OrganizationSlugResponseOutputAllowedReleaseChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OrganizationSlugResponseOutputAllowedReleaseChannel), TypeInfoPropertyName = "V1OrganizationSlugResponseOutputAllowedReleaseChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponseOutputProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponseOutputPreviewWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewWarning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponseOutputPreviewError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponseOutputPreviewInfoItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewInfoItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.OrganizationProjectClaimResponseOutputPreviewMembersExceedingFreeProjectLimitItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewMembersExceedingFreeProjectLimitItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan), TypeInfoPropertyName = "OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan), TypeInfoPropertyName = "OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.OrganizationResponseV1Output>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1OrganizationMemberResponseOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureKey?), TypeInfoPropertyName = "NullableV1ListEntitlementsResponseOutputEntitlementFeatureKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureType?), TypeInfoPropertyName = "NullableV1ListEntitlementsResponseOutputEntitlementFeatureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementType?), TypeInfoPropertyName = "NullableV1ListEntitlementsResponseOutputEntitlementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OrganizationSlugResponseOutputPlan?), TypeInfoPropertyName = "NullableV1OrganizationSlugResponseOutputPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OrganizationSlugResponseOutputOptInTag?), TypeInfoPropertyName = "NullableV1OrganizationSlugResponseOutputOptInTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OrganizationSlugResponseOutputAllowedReleaseChannel?), TypeInfoPropertyName = "NullableV1OrganizationSlugResponseOutputAllowedReleaseChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan?), TypeInfoPropertyName = "NullableOrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan?), TypeInfoPropertyName = "NullableOrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1ListEntitlementsResponseOutputEntitlement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1OrganizationSlugResponseOutputOptInTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1OrganizationSlugResponseOutputAllowedReleaseChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.OrganizationProjectClaimResponseOutputPreviewWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.OrganizationProjectClaimResponseOutputPreviewError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.OrganizationProjectClaimResponseOutputPreviewInfoItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.OrganizationProjectClaimResponseOutputPreviewMembersExceedingFreeProjectLimitItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.OrganizationResponseV1Output>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1OrganizationMemberResponseOutput>))]
    internal sealed partial class OrganizationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static OrganizationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private OrganizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant1, global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant2, global::Supabase.V1ListEntitlementsResponseOutputEntitlementConfigVariant3>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
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
                    typeToConvert == typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureKey)

                    || typeToConvert == typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureKey?)

                    || typeToConvert == typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureType)

                    || typeToConvert == typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureType?)

                    || typeToConvert == typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementType)

                    || typeToConvert == typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementType?)

                    || typeToConvert == typeof(global::Supabase.V1OrganizationSlugResponseOutputPlan)

                    || typeToConvert == typeof(global::Supabase.V1OrganizationSlugResponseOutputPlan?)

                    || typeToConvert == typeof(global::Supabase.V1OrganizationSlugResponseOutputOptInTag)

                    || typeToConvert == typeof(global::Supabase.V1OrganizationSlugResponseOutputOptInTag?)

                    || typeToConvert == typeof(global::Supabase.V1OrganizationSlugResponseOutputAllowedReleaseChannel)

                    || typeToConvert == typeof(global::Supabase.V1OrganizationSlugResponseOutputAllowedReleaseChannel?)

                    || typeToConvert == typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan)

                    || typeToConvert == typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan?)

                    || typeToConvert == typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan)

                    || typeToConvert == typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureKey))
                {
                    return new global::Supabase.JsonConverters.V1ListEntitlementsResponseOutputEntitlementFeatureKeyJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureKey?))
                {
                    return new global::Supabase.JsonConverters.V1ListEntitlementsResponseOutputEntitlementFeatureKeyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureType))
                {
                    return new global::Supabase.JsonConverters.V1ListEntitlementsResponseOutputEntitlementFeatureTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementFeatureType?))
                {
                    return new global::Supabase.JsonConverters.V1ListEntitlementsResponseOutputEntitlementFeatureTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementType))
                {
                    return new global::Supabase.JsonConverters.V1ListEntitlementsResponseOutputEntitlementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ListEntitlementsResponseOutputEntitlementType?))
                {
                    return new global::Supabase.JsonConverters.V1ListEntitlementsResponseOutputEntitlementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1OrganizationSlugResponseOutputPlan))
                {
                    return new global::Supabase.JsonConverters.V1OrganizationSlugResponseOutputPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1OrganizationSlugResponseOutputPlan?))
                {
                    return new global::Supabase.JsonConverters.V1OrganizationSlugResponseOutputPlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1OrganizationSlugResponseOutputOptInTag))
                {
                    return new global::Supabase.JsonConverters.V1OrganizationSlugResponseOutputOptInTagJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1OrganizationSlugResponseOutputOptInTag?))
                {
                    return new global::Supabase.JsonConverters.V1OrganizationSlugResponseOutputOptInTagNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1OrganizationSlugResponseOutputAllowedReleaseChannel))
                {
                    return new global::Supabase.JsonConverters.V1OrganizationSlugResponseOutputAllowedReleaseChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1OrganizationSlugResponseOutputAllowedReleaseChannel?))
                {
                    return new global::Supabase.JsonConverters.V1OrganizationSlugResponseOutputAllowedReleaseChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan))
                {
                    return new global::Supabase.JsonConverters.OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlan?))
                {
                    return new global::Supabase.JsonConverters.OrganizationProjectClaimResponseOutputPreviewSourceSubscriptionPlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan))
                {
                    return new global::Supabase.JsonConverters.OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlan?))
                {
                    return new global::Supabase.JsonConverters.OrganizationProjectClaimResponseOutputPreviewTargetSubscriptionPlanNullableJsonConverter();
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
                    0 => new OrganizationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}