
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OAuthTokenBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OAuthTokenBodyGrantType), TypeInfoPropertyName = "OAuthTokenBodyGrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OAuthTokenResponseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OAuthTokenResponseOutputTokenType), TypeInfoPropertyName = "OAuthTokenResponseOutputTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OAuthRevokeTokenBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1AuthorizeUserResponseType), TypeInfoPropertyName = "V1AuthorizeUserResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1AuthorizeUserCodeChallengeMethod), TypeInfoPropertyName = "V1AuthorizeUserCodeChallengeMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OauthAuthorizeProjectClaimResponseType), TypeInfoPropertyName = "V1OauthAuthorizeProjectClaimResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OauthAuthorizeProjectClaimCodeChallengeMethod), TypeInfoPropertyName = "V1OauthAuthorizeProjectClaimCodeChallengeMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OAuthTokenBodyGrantType?), TypeInfoPropertyName = "NullableOAuthTokenBodyGrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.OAuthTokenResponseOutputTokenType?), TypeInfoPropertyName = "NullableOAuthTokenResponseOutputTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1AuthorizeUserResponseType?), TypeInfoPropertyName = "NullableV1AuthorizeUserResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1AuthorizeUserCodeChallengeMethod?), TypeInfoPropertyName = "NullableV1AuthorizeUserCodeChallengeMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OauthAuthorizeProjectClaimResponseType?), TypeInfoPropertyName = "NullableV1OauthAuthorizeProjectClaimResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Supabase.V1OauthAuthorizeProjectClaimCodeChallengeMethod?), TypeInfoPropertyName = "NullableV1OauthAuthorizeProjectClaimCodeChallengeMethod2")]
    internal sealed partial class OAuthSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OAuthSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static OAuthSourceGenerationContext Default { get; } = new(DefaultOptions);

        private OAuthSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Supabase.OAuthTokenBodyGrantType)

                    || typeToConvert == typeof(global::Supabase.OAuthTokenBodyGrantType?)

                    || typeToConvert == typeof(global::Supabase.OAuthTokenResponseOutputTokenType)

                    || typeToConvert == typeof(global::Supabase.OAuthTokenResponseOutputTokenType?)

                    || typeToConvert == typeof(global::Supabase.V1AuthorizeUserResponseType)

                    || typeToConvert == typeof(global::Supabase.V1AuthorizeUserResponseType?)

                    || typeToConvert == typeof(global::Supabase.V1AuthorizeUserCodeChallengeMethod)

                    || typeToConvert == typeof(global::Supabase.V1AuthorizeUserCodeChallengeMethod?)

                    || typeToConvert == typeof(global::Supabase.V1OauthAuthorizeProjectClaimResponseType)

                    || typeToConvert == typeof(global::Supabase.V1OauthAuthorizeProjectClaimResponseType?)

                    || typeToConvert == typeof(global::Supabase.V1OauthAuthorizeProjectClaimCodeChallengeMethod)

                    || typeToConvert == typeof(global::Supabase.V1OauthAuthorizeProjectClaimCodeChallengeMethod?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Supabase.OAuthTokenBodyGrantType))
                {
                    return new global::Supabase.JsonConverters.OAuthTokenBodyGrantTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.OAuthTokenBodyGrantType?))
                {
                    return new global::Supabase.JsonConverters.OAuthTokenBodyGrantTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.OAuthTokenResponseOutputTokenType))
                {
                    return new global::Supabase.JsonConverters.OAuthTokenResponseOutputTokenTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.OAuthTokenResponseOutputTokenType?))
                {
                    return new global::Supabase.JsonConverters.OAuthTokenResponseOutputTokenTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1AuthorizeUserResponseType))
                {
                    return new global::Supabase.JsonConverters.V1AuthorizeUserResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1AuthorizeUserResponseType?))
                {
                    return new global::Supabase.JsonConverters.V1AuthorizeUserResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1AuthorizeUserCodeChallengeMethod))
                {
                    return new global::Supabase.JsonConverters.V1AuthorizeUserCodeChallengeMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1AuthorizeUserCodeChallengeMethod?))
                {
                    return new global::Supabase.JsonConverters.V1AuthorizeUserCodeChallengeMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1OauthAuthorizeProjectClaimResponseType))
                {
                    return new global::Supabase.JsonConverters.V1OauthAuthorizeProjectClaimResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1OauthAuthorizeProjectClaimResponseType?))
                {
                    return new global::Supabase.JsonConverters.V1OauthAuthorizeProjectClaimResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1OauthAuthorizeProjectClaimCodeChallengeMethod))
                {
                    return new global::Supabase.JsonConverters.V1OauthAuthorizeProjectClaimCodeChallengeMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Supabase.V1OauthAuthorizeProjectClaimCodeChallengeMethod?))
                {
                    return new global::Supabase.JsonConverters.V1OauthAuthorizeProjectClaimCodeChallengeMethodNullableJsonConverter();
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
                    0 => new OAuthSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}