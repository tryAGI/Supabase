
#nullable enable

namespace Supabase
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1ProjectAdvisorsResponseOutputLint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintName), TypeInfoPropertyName = "V1ProjectAdvisorsResponseOutputLintName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintLevel), TypeInfoPropertyName = "V1ProjectAdvisorsResponseOutputLintLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintFacing), TypeInfoPropertyName = "V1ProjectAdvisorsResponseOutputLintFacing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1ProjectAdvisorsResponseOutputLintCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintCategorie), TypeInfoPropertyName = "V1ProjectAdvisorsResponseOutputLintCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintMetadataType), TypeInfoPropertyName = "V1ProjectAdvisorsResponseOutputLintMetadataType2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetSecurityAdvisorsLintType), TypeInfoPropertyName = "V1GetSecurityAdvisorsLintType2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintName?), TypeInfoPropertyName = "NullableV1ProjectAdvisorsResponseOutputLintName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintLevel?), TypeInfoPropertyName = "NullableV1ProjectAdvisorsResponseOutputLintLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintFacing?), TypeInfoPropertyName = "NullableV1ProjectAdvisorsResponseOutputLintFacing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintCategorie?), TypeInfoPropertyName = "NullableV1ProjectAdvisorsResponseOutputLintCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintMetadataType?), TypeInfoPropertyName = "NullableV1ProjectAdvisorsResponseOutputLintMetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetSecurityAdvisorsLintType?), TypeInfoPropertyName = "NullableV1GetSecurityAdvisorsLintType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1ProjectAdvisorsResponseOutputLint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1ProjectAdvisorsResponseOutputLintCategorie>))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    #pragma warning restore CS0618
    internal sealed partial class AdvisorsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdvisorsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AdvisorsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AdvisorsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            #pragma warning restore CS0618
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            #pragma warning restore CS0618
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            #pragma warning restore CS0618
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            #pragma warning restore CS0618
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            #pragma warning restore CS0618
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            #pragma warning restore CS0618
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            #pragma warning restore CS0618
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<object, double?, string, bool?>());
            #pragma warning restore CS0618
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
                    typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintName)

                    || typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintName?)

                    || typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintLevel)

                    || typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintLevel?)

                    || typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintFacing)

                    || typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintFacing?)

                    || typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintCategorie)

                    || typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintCategorie?)

                    || typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintMetadataType)

                    || typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintMetadataType?)

                    || typeToConvert == typeof(global::Supabase.V1GetSecurityAdvisorsLintType)

                    || typeToConvert == typeof(global::Supabase.V1GetSecurityAdvisorsLintType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintName))
                {
                    return new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseOutputLintNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintName?))
                {
                    return new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseOutputLintNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintLevel))
                {
                    return new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseOutputLintLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintLevel?))
                {
                    return new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseOutputLintLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintFacing))
                {
                    return new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseOutputLintFacingJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintFacing?))
                {
                    return new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseOutputLintFacingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintCategorie))
                {
                    return new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseOutputLintCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintCategorie?))
                {
                    return new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseOutputLintCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintMetadataType))
                {
                    return new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseOutputLintMetadataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1ProjectAdvisorsResponseOutputLintMetadataType?))
                {
                    return new global::Supabase.JsonConverters.V1ProjectAdvisorsResponseOutputLintMetadataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1GetSecurityAdvisorsLintType))
                {
                    return new global::Supabase.JsonConverters.V1GetSecurityAdvisorsLintTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1GetSecurityAdvisorsLintType?))
                {
                    return new global::Supabase.JsonConverters.V1GetSecurityAdvisorsLintTypeNullableJsonConverter();
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
                    0 => new AdvisorsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}