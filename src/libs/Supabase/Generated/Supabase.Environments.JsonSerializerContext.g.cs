
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchDetailResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchDetailResponseOutputStatus), TypeInfoPropertyName = "BranchDetailResponseOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateBranchBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateBranchBodyStatus), TypeInfoPropertyName = "UpdateBranchBodyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchResponseOutputStatus), TypeInfoPropertyName = "BranchResponseOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchResponseOutputPreviewProjectStatus), TypeInfoPropertyName = "BranchResponseOutputPreviewProjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchDeleteResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchDeleteResponseOutputMessage), TypeInfoPropertyName = "BranchDeleteResponseOutputMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchActionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchUpdateResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchUpdateResponseOutputMessage), TypeInfoPropertyName = "BranchUpdateResponseOutputMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchRestoreResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchRestoreResponseOutputMessage), TypeInfoPropertyName = "BranchRestoreResponseOutputMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.ListActionRunResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListActionRunResponseOutputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.ListActionRunResponseOutputItemRunStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListActionRunResponseOutputItemRunStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListActionRunResponseOutputItemRunStepName), TypeInfoPropertyName = "ListActionRunResponseOutputItemRunStepName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListActionRunResponseOutputItemRunStepStatus), TypeInfoPropertyName = "ListActionRunResponseOutputItemRunStepStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ActionRunResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.ActionRunResponseOutputRunStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ActionRunResponseOutputRunStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ActionRunResponseOutputRunStepName), TypeInfoPropertyName = "ActionRunResponseOutputRunStepName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ActionRunResponseOutputRunStepStatus), TypeInfoPropertyName = "ActionRunResponseOutputRunStepStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyClone), TypeInfoPropertyName = "UpdateRunStatusBodyClone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyPull), TypeInfoPropertyName = "UpdateRunStatusBodyPull2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyHealth), TypeInfoPropertyName = "UpdateRunStatusBodyHealth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyConfigure), TypeInfoPropertyName = "UpdateRunStatusBodyConfigure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyMigrate), TypeInfoPropertyName = "UpdateRunStatusBodyMigrate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodySeed), TypeInfoPropertyName = "UpdateRunStatusBodySeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyDeploy), TypeInfoPropertyName = "UpdateRunStatusBodyDeploy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusResponseOutputMessage), TypeInfoPropertyName = "UpdateRunStatusResponseOutputMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateBranchBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateBranchBodyDesiredInstanceSize), TypeInfoPropertyName = "CreateBranchBodyDesiredInstanceSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateBranchBodyReleaseChannel), TypeInfoPropertyName = "CreateBranchBodyReleaseChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateBranchBodyPostgresEngine), TypeInfoPropertyName = "CreateBranchBodyPostgresEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnyOf<string, global::System.Guid?>), TypeInfoPropertyName = "AnyOfStringGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.BranchResponseOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchDetailResponseOutputStatus?), TypeInfoPropertyName = "NullableBranchDetailResponseOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateBranchBodyStatus?), TypeInfoPropertyName = "NullableUpdateBranchBodyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchResponseOutputStatus?), TypeInfoPropertyName = "NullableBranchResponseOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchResponseOutputPreviewProjectStatus?), TypeInfoPropertyName = "NullableBranchResponseOutputPreviewProjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchDeleteResponseOutputMessage?), TypeInfoPropertyName = "NullableBranchDeleteResponseOutputMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchUpdateResponseOutputMessage?), TypeInfoPropertyName = "NullableBranchUpdateResponseOutputMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.BranchRestoreResponseOutputMessage?), TypeInfoPropertyName = "NullableBranchRestoreResponseOutputMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListActionRunResponseOutputItemRunStepName?), TypeInfoPropertyName = "NullableListActionRunResponseOutputItemRunStepName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ListActionRunResponseOutputItemRunStepStatus?), TypeInfoPropertyName = "NullableListActionRunResponseOutputItemRunStepStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ActionRunResponseOutputRunStepName?), TypeInfoPropertyName = "NullableActionRunResponseOutputRunStepName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.ActionRunResponseOutputRunStepStatus?), TypeInfoPropertyName = "NullableActionRunResponseOutputRunStepStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyClone?), TypeInfoPropertyName = "NullableUpdateRunStatusBodyClone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyPull?), TypeInfoPropertyName = "NullableUpdateRunStatusBodyPull2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyHealth?), TypeInfoPropertyName = "NullableUpdateRunStatusBodyHealth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyConfigure?), TypeInfoPropertyName = "NullableUpdateRunStatusBodyConfigure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyMigrate?), TypeInfoPropertyName = "NullableUpdateRunStatusBodyMigrate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodySeed?), TypeInfoPropertyName = "NullableUpdateRunStatusBodySeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusBodyDeploy?), TypeInfoPropertyName = "NullableUpdateRunStatusBodyDeploy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateRunStatusResponseOutputMessage?), TypeInfoPropertyName = "NullableUpdateRunStatusResponseOutputMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateBranchBodyDesiredInstanceSize?), TypeInfoPropertyName = "NullableCreateBranchBodyDesiredInstanceSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateBranchBodyReleaseChannel?), TypeInfoPropertyName = "NullableCreateBranchBodyReleaseChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.CreateBranchBodyPostgresEngine?), TypeInfoPropertyName = "NullableCreateBranchBodyPostgresEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnyOf<string, global::System.Guid?>?), TypeInfoPropertyName = "NullableAnyOfStringGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.ListActionRunResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.ListActionRunResponseOutputItemRunStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.ActionRunResponseOutputRunStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.BranchResponseOutput>))]
    internal sealed partial class EnvironmentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnvironmentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EnvironmentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Supabase.BranchDetailResponseOutputStatus)

                    || typeToConvert == typeof(global::Supabase.BranchDetailResponseOutputStatus?)

                    || typeToConvert == typeof(global::Supabase.UpdateBranchBodyStatus)

                    || typeToConvert == typeof(global::Supabase.UpdateBranchBodyStatus?)

                    || typeToConvert == typeof(global::Supabase.BranchResponseOutputStatus)

                    || typeToConvert == typeof(global::Supabase.BranchResponseOutputStatus?)

                    || typeToConvert == typeof(global::Supabase.BranchResponseOutputPreviewProjectStatus)

                    || typeToConvert == typeof(global::Supabase.BranchResponseOutputPreviewProjectStatus?)

                    || typeToConvert == typeof(global::Supabase.BranchDeleteResponseOutputMessage)

                    || typeToConvert == typeof(global::Supabase.BranchDeleteResponseOutputMessage?)

                    || typeToConvert == typeof(global::Supabase.BranchUpdateResponseOutputMessage)

                    || typeToConvert == typeof(global::Supabase.BranchUpdateResponseOutputMessage?)

                    || typeToConvert == typeof(global::Supabase.BranchRestoreResponseOutputMessage)

                    || typeToConvert == typeof(global::Supabase.BranchRestoreResponseOutputMessage?)

                    || typeToConvert == typeof(global::Supabase.ListActionRunResponseOutputItemRunStepName)

                    || typeToConvert == typeof(global::Supabase.ListActionRunResponseOutputItemRunStepName?)

                    || typeToConvert == typeof(global::Supabase.ListActionRunResponseOutputItemRunStepStatus)

                    || typeToConvert == typeof(global::Supabase.ListActionRunResponseOutputItemRunStepStatus?)

                    || typeToConvert == typeof(global::Supabase.ActionRunResponseOutputRunStepName)

                    || typeToConvert == typeof(global::Supabase.ActionRunResponseOutputRunStepName?)

                    || typeToConvert == typeof(global::Supabase.ActionRunResponseOutputRunStepStatus)

                    || typeToConvert == typeof(global::Supabase.ActionRunResponseOutputRunStepStatus?)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyClone)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyClone?)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyPull)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyPull?)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyHealth)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyHealth?)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyConfigure)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyConfigure?)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyMigrate)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyMigrate?)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusBodySeed)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusBodySeed?)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyDeploy)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyDeploy?)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusResponseOutputMessage)

                    || typeToConvert == typeof(global::Supabase.UpdateRunStatusResponseOutputMessage?)

                    || typeToConvert == typeof(global::Supabase.CreateBranchBodyDesiredInstanceSize)

                    || typeToConvert == typeof(global::Supabase.CreateBranchBodyDesiredInstanceSize?)

                    || typeToConvert == typeof(global::Supabase.CreateBranchBodyReleaseChannel)

                    || typeToConvert == typeof(global::Supabase.CreateBranchBodyReleaseChannel?)

                    || typeToConvert == typeof(global::Supabase.CreateBranchBodyPostgresEngine)

                    || typeToConvert == typeof(global::Supabase.CreateBranchBodyPostgresEngine?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Supabase.BranchDetailResponseOutputStatus))
                {
                    return new global::Supabase.JsonConverters.BranchDetailResponseOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.BranchDetailResponseOutputStatus?))
                {
                    return new global::Supabase.JsonConverters.BranchDetailResponseOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateBranchBodyStatus))
                {
                    return new global::Supabase.JsonConverters.UpdateBranchBodyStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateBranchBodyStatus?))
                {
                    return new global::Supabase.JsonConverters.UpdateBranchBodyStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.BranchResponseOutputStatus))
                {
                    return new global::Supabase.JsonConverters.BranchResponseOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.BranchResponseOutputStatus?))
                {
                    return new global::Supabase.JsonConverters.BranchResponseOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.BranchResponseOutputPreviewProjectStatus))
                {
                    return new global::Supabase.JsonConverters.BranchResponseOutputPreviewProjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.BranchResponseOutputPreviewProjectStatus?))
                {
                    return new global::Supabase.JsonConverters.BranchResponseOutputPreviewProjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.BranchDeleteResponseOutputMessage))
                {
                    return new global::Supabase.JsonConverters.BranchDeleteResponseOutputMessageJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.BranchDeleteResponseOutputMessage?))
                {
                    return new global::Supabase.JsonConverters.BranchDeleteResponseOutputMessageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.BranchUpdateResponseOutputMessage))
                {
                    return new global::Supabase.JsonConverters.BranchUpdateResponseOutputMessageJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.BranchUpdateResponseOutputMessage?))
                {
                    return new global::Supabase.JsonConverters.BranchUpdateResponseOutputMessageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.BranchRestoreResponseOutputMessage))
                {
                    return new global::Supabase.JsonConverters.BranchRestoreResponseOutputMessageJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.BranchRestoreResponseOutputMessage?))
                {
                    return new global::Supabase.JsonConverters.BranchRestoreResponseOutputMessageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.ListActionRunResponseOutputItemRunStepName))
                {
                    return new global::Supabase.JsonConverters.ListActionRunResponseOutputItemRunStepNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.ListActionRunResponseOutputItemRunStepName?))
                {
                    return new global::Supabase.JsonConverters.ListActionRunResponseOutputItemRunStepNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.ListActionRunResponseOutputItemRunStepStatus))
                {
                    return new global::Supabase.JsonConverters.ListActionRunResponseOutputItemRunStepStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.ListActionRunResponseOutputItemRunStepStatus?))
                {
                    return new global::Supabase.JsonConverters.ListActionRunResponseOutputItemRunStepStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.ActionRunResponseOutputRunStepName))
                {
                    return new global::Supabase.JsonConverters.ActionRunResponseOutputRunStepNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.ActionRunResponseOutputRunStepName?))
                {
                    return new global::Supabase.JsonConverters.ActionRunResponseOutputRunStepNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.ActionRunResponseOutputRunStepStatus))
                {
                    return new global::Supabase.JsonConverters.ActionRunResponseOutputRunStepStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.ActionRunResponseOutputRunStepStatus?))
                {
                    return new global::Supabase.JsonConverters.ActionRunResponseOutputRunStepStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyClone))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusBodyCloneJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyClone?))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusBodyCloneNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyPull))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusBodyPullJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyPull?))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusBodyPullNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyHealth))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusBodyHealthJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyHealth?))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusBodyHealthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyConfigure))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusBodyConfigureJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyConfigure?))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusBodyConfigureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyMigrate))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusBodyMigrateJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyMigrate?))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusBodyMigrateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusBodySeed))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusBodySeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusBodySeed?))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusBodySeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyDeploy))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusBodyDeployJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusBodyDeploy?))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusBodyDeployNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusResponseOutputMessage))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusResponseOutputMessageJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateRunStatusResponseOutputMessage?))
                {
                    return new global::Supabase.JsonConverters.UpdateRunStatusResponseOutputMessageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.CreateBranchBodyDesiredInstanceSize))
                {
                    return new global::Supabase.JsonConverters.CreateBranchBodyDesiredInstanceSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.CreateBranchBodyDesiredInstanceSize?))
                {
                    return new global::Supabase.JsonConverters.CreateBranchBodyDesiredInstanceSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.CreateBranchBodyReleaseChannel))
                {
                    return new global::Supabase.JsonConverters.CreateBranchBodyReleaseChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.CreateBranchBodyReleaseChannel?))
                {
                    return new global::Supabase.JsonConverters.CreateBranchBodyReleaseChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.CreateBranchBodyPostgresEngine))
                {
                    return new global::Supabase.JsonConverters.CreateBranchBodyPostgresEngineJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.CreateBranchBodyPostgresEngine?))
                {
                    return new global::Supabase.JsonConverters.CreateBranchBodyPostgresEngineNullableJsonConverter();
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
                    0 => new EnvironmentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}