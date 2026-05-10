#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public class Attributes2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.Attributes2>
    {
        /// <inheritdoc />
        public override global::Supabase.Attributes2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.DiskRequestBodyAttributesDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.DiskRequestBodyAttributesDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Supabase.DiskRequestBodyAttributesDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Supabase.DiskRequestBodyAttributesVariant1? gp3 = default;
            if (discriminator?.Type == global::Supabase.DiskRequestBodyAttributesDiscriminatorType.Gp3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.DiskRequestBodyAttributesVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.DiskRequestBodyAttributesVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Supabase.DiskRequestBodyAttributesVariant1)}");
                gp3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Supabase.DiskRequestBodyAttributesVariant2? io2 = default;
            if (discriminator?.Type == global::Supabase.DiskRequestBodyAttributesDiscriminatorType.Io2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.DiskRequestBodyAttributesVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.DiskRequestBodyAttributesVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Supabase.DiskRequestBodyAttributesVariant2)}");
                io2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Supabase.Attributes2(
                discriminator?.Type,
                gp3,

                io2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.Attributes2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGp3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.DiskRequestBodyAttributesVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.DiskRequestBodyAttributesVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.DiskRequestBodyAttributesVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gp3!, typeInfo);
            }
            else if (value.IsIo2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.DiskRequestBodyAttributesVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.DiskRequestBodyAttributesVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.DiskRequestBodyAttributesVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Io2!, typeInfo);
            }
        }
    }
}