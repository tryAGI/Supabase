
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnalyticsResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnyOf<string, global::Supabase.AnalyticsResponseOutputError>), TypeInfoPropertyName = "AnyOfStringAnalyticsResponseOutputError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnalyticsResponseOutputError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.AnalyticsResponseOutputErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnalyticsResponseOutputErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiCountResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiCountResponseOutputResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiCountResponseOutputResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnyOf<string, global::Supabase.V1GetUsageApiCountResponseOutputError>), TypeInfoPropertyName = "AnyOfStringV1GetUsageApiCountResponseOutputError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiCountResponseOutputError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiCountResponseOutputErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiCountResponseOutputErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiRequestsCountResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiRequestsCountResponseOutputResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiRequestsCountResponseOutputResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnyOf<string, global::Supabase.V1GetUsageApiRequestsCountResponseOutputError>), TypeInfoPropertyName = "AnyOfStringV1GetUsageApiRequestsCountResponseOutputError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiRequestsCountResponseOutputError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Supabase.V1GetUsageApiRequestsCountResponseOutputErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetUsageApiRequestsCountResponseOutputErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetProjectUsageApiCountInterval), TypeInfoPropertyName = "V1GetProjectUsageApiCountInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetProjectFunctionCombinedStatsInterval), TypeInfoPropertyName = "V1GetProjectFunctionCombinedStatsInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnyOf<string, global::Supabase.AnalyticsResponseOutputError>?), TypeInfoPropertyName = "NullableAnyOfStringAnalyticsResponseOutputError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnyOf<string, global::Supabase.V1GetUsageApiCountResponseOutputError>?), TypeInfoPropertyName = "NullableAnyOfStringV1GetUsageApiCountResponseOutputError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.AnyOf<string, global::Supabase.V1GetUsageApiRequestsCountResponseOutputError>?), TypeInfoPropertyName = "NullableAnyOfStringV1GetUsageApiRequestsCountResponseOutputError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetProjectUsageApiCountInterval?), TypeInfoPropertyName = "NullableV1GetProjectUsageApiCountInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1GetProjectFunctionCombinedStatsInterval?), TypeInfoPropertyName = "NullableV1GetProjectFunctionCombinedStatsInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.AnalyticsResponseOutputErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1GetUsageApiCountResponseOutputResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1GetUsageApiCountResponseOutputErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1GetUsageApiRequestsCountResponseOutputResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Supabase.V1GetUsageApiRequestsCountResponseOutputErrorError>))]
    internal sealed partial class AnalyticsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnalyticsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AnalyticsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AnalyticsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::Supabase.AnalyticsResponseOutputError>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::Supabase.V1GetUsageApiCountResponseOutputError>());
            options.Converters.Add(new global::Supabase.JsonConverters.AnyOfJsonConverter<string, global::Supabase.V1GetUsageApiRequestsCountResponseOutputError>());
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
                    typeToConvert == typeof(global::Supabase.V1GetProjectUsageApiCountInterval)

                    || typeToConvert == typeof(global::Supabase.V1GetProjectUsageApiCountInterval?)

                    || typeToConvert == typeof(global::Supabase.V1GetProjectFunctionCombinedStatsInterval)

                    || typeToConvert == typeof(global::Supabase.V1GetProjectFunctionCombinedStatsInterval?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Supabase.V1GetProjectUsageApiCountInterval))
                {
                    return new global::Supabase.JsonConverters.V1GetProjectUsageApiCountIntervalJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1GetProjectUsageApiCountInterval?))
                {
                    return new global::Supabase.JsonConverters.V1GetProjectUsageApiCountIntervalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1GetProjectFunctionCombinedStatsInterval))
                {
                    return new global::Supabase.JsonConverters.V1GetProjectFunctionCombinedStatsIntervalJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1GetProjectFunctionCombinedStatsInterval?))
                {
                    return new global::Supabase.JsonConverters.V1GetProjectFunctionCombinedStatsIntervalNullableJsonConverter();
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
                    0 => new AnalyticsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}