#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public class RegionSelectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.RegionSelection>
    {
        /// <inheritdoc />
        public override global::Supabase.RegionSelection Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.V1CreateProjectBodyRegionSelectionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.V1CreateProjectBodyRegionSelectionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Supabase.V1CreateProjectBodyRegionSelectionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Supabase.V1CreateProjectBodyRegionSelectionVariant1? specific = default;
            if (discriminator?.Type == global::Supabase.V1CreateProjectBodyRegionSelectionDiscriminatorType.Specific)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.V1CreateProjectBodyRegionSelectionVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant1)}");
                specific = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Supabase.V1CreateProjectBodyRegionSelectionVariant2? smartGroup = default;
            if (discriminator?.Type == global::Supabase.V1CreateProjectBodyRegionSelectionDiscriminatorType.SmartGroup)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.V1CreateProjectBodyRegionSelectionVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant2)}");
                smartGroup = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Supabase.RegionSelection(
                discriminator?.Type,
                specific,

                smartGroup
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.RegionSelection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSpecific)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.V1CreateProjectBodyRegionSelectionVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Specific!, typeInfo);
            }
            else if (value.IsSmartGroup)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.V1CreateProjectBodyRegionSelectionVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SmartGroup!, typeInfo);
            }
        }
    }
}