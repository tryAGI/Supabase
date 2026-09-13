
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1StorageBucketResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseOutputFeatures))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseOutputFeaturesImageTransformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseOutputFeaturesS3Protocol))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseOutputFeaturesPurgeCache))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseOutputFeaturesIcebergCatalog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseOutputFeaturesVectorBuckets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseOutputCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseOutputExternal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseOutputExternalUpstreamTarget), TypeInfoPropertyName = "StorageConfigResponseOutputExternalUpstreamTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyFeatures))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyFeaturesImageTransformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyFeaturesS3Protocol))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyFeaturesPurgeCache))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyFeaturesIcebergCatalog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyFeaturesVectorBuckets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyExternal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyExternalUpstreamTarget), TypeInfoPropertyName = "UpdateStorageConfigBodyExternalUpstreamTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1StorageBucketResponseOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.StorageConfigResponseOutputExternalUpstreamTarget?), TypeInfoPropertyName = "NullableStorageConfigResponseOutputExternalUpstreamTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.UpdateStorageConfigBodyExternalUpstreamTarget?), TypeInfoPropertyName = "NullableUpdateStorageConfigBodyExternalUpstreamTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1StorageBucketResponseOutput>))]
    internal sealed partial class StorageSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StorageSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static StorageSourceGenerationContext Default { get; } = new(DefaultOptions);

        private StorageSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Supabase.StorageConfigResponseOutputExternalUpstreamTarget)

                    || typeToConvert == typeof(global::Supabase.StorageConfigResponseOutputExternalUpstreamTarget?)

                    || typeToConvert == typeof(global::Supabase.UpdateStorageConfigBodyExternalUpstreamTarget)

                    || typeToConvert == typeof(global::Supabase.UpdateStorageConfigBodyExternalUpstreamTarget?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Supabase.StorageConfigResponseOutputExternalUpstreamTarget))
                {
                    return new global::Supabase.JsonConverters.StorageConfigResponseOutputExternalUpstreamTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.StorageConfigResponseOutputExternalUpstreamTarget?))
                {
                    return new global::Supabase.JsonConverters.StorageConfigResponseOutputExternalUpstreamTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateStorageConfigBodyExternalUpstreamTarget))
                {
                    return new global::Supabase.JsonConverters.UpdateStorageConfigBodyExternalUpstreamTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.UpdateStorageConfigBodyExternalUpstreamTarget?))
                {
                    return new global::Supabase.JsonConverters.UpdateStorageConfigBodyExternalUpstreamTargetNullableJsonConverter();
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
                    0 => new StorageSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}