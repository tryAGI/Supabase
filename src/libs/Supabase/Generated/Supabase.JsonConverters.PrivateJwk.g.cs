#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public class PrivateJwkJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.PrivateJwk>
    {
        /// <inheritdoc />
        public override global::Supabase.PrivateJwk Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("alg")) __score0++;
            if (__jsonProps.Contains("d")) __score0++;
            if (__jsonProps.Contains("dp")) __score0++;
            if (__jsonProps.Contains("dq")) __score0++;
            if (__jsonProps.Contains("e")) __score0++;
            if (__jsonProps.Contains("ext")) __score0++;
            if (__jsonProps.Contains("key_ops")) __score0++;
            if (__jsonProps.Contains("kid")) __score0++;
            if (__jsonProps.Contains("kty")) __score0++;
            if (__jsonProps.Contains("n")) __score0++;
            if (__jsonProps.Contains("p")) __score0++;
            if (__jsonProps.Contains("q")) __score0++;
            if (__jsonProps.Contains("qi")) __score0++;
            if (__jsonProps.Contains("use")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("alg")) __score1++;
            if (__jsonProps.Contains("crv")) __score1++;
            if (__jsonProps.Contains("d")) __score1++;
            if (__jsonProps.Contains("ext")) __score1++;
            if (__jsonProps.Contains("key_ops")) __score1++;
            if (__jsonProps.Contains("kid")) __score1++;
            if (__jsonProps.Contains("kty")) __score1++;
            if (__jsonProps.Contains("use")) __score1++;
            if (__jsonProps.Contains("x")) __score1++;
            if (__jsonProps.Contains("y")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("alg")) __score2++;
            if (__jsonProps.Contains("crv")) __score2++;
            if (__jsonProps.Contains("d")) __score2++;
            if (__jsonProps.Contains("ext")) __score2++;
            if (__jsonProps.Contains("key_ops")) __score2++;
            if (__jsonProps.Contains("kid")) __score2++;
            if (__jsonProps.Contains("kty")) __score2++;
            if (__jsonProps.Contains("use")) __score2++;
            if (__jsonProps.Contains("x")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("alg")) __score3++;
            if (__jsonProps.Contains("ext")) __score3++;
            if (__jsonProps.Contains("k")) __score3++;
            if (__jsonProps.Contains("key_ops")) __score3++;
            if (__jsonProps.Contains("kid")) __score3++;
            if (__jsonProps.Contains("kty")) __score3++;
            if (__jsonProps.Contains("use")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1? rsa = default;
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2? ec = default;
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3? okp = default;
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4? oct = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1).Name}");
                        rsa = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2).Name}");
                        ec = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3).Name}");
                        okp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4).Name}");
                        oct = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (rsa == null && ec == null && okp == null && oct == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1).Name}");
                    rsa = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2).Name}");
                    ec = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3).Name}");
                    okp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4).Name}");
                    oct = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Supabase.PrivateJwk(
                rsa,

                ec,

                okp,

                oct
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.PrivateJwk value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRsa)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Rsa!, typeInfo);
            }
            else if (value.IsEc)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ec!, typeInfo);
            }
            else if (value.IsOkp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Okp!, typeInfo);
            }
            else if (value.IsOct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oct!, typeInfo);
            }
        }
    }
}