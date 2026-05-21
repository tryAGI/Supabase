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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Supabase.CreateSigningKeyBodyPrivateJwkDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1? rsa = default;
            if (discriminator?.Kty == global::Supabase.CreateSigningKeyBodyPrivateJwkDiscriminatorKty.Rsa)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant1)}");
                rsa = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2? ec = default;
            if (discriminator?.Kty == global::Supabase.CreateSigningKeyBodyPrivateJwkDiscriminatorKty.Ec)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant2)}");
                ec = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3? okp = default;
            if (discriminator?.Kty == global::Supabase.CreateSigningKeyBodyPrivateJwkDiscriminatorKty.Okp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant3)}");
                okp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4? oct = default;
            if (discriminator?.Kty == global::Supabase.CreateSigningKeyBodyPrivateJwkDiscriminatorKty.Oct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Supabase.CreateSigningKeyBodyPrivateJwkVariant4)}");
                oct = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Supabase.PrivateJwk(
                discriminator?.Kty,
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