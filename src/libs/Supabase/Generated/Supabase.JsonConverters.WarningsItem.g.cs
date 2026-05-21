#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public class WarningsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.WarningsItem>
    {
        /// <inheritdoc />
        public override global::Supabase.WarningsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.ProjectUpgradeEligibilityResponseWarningDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.ProjectUpgradeEligibilityResponseWarningDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Supabase.ProjectUpgradeEligibilityResponseWarningDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1? pgGraphqlIntrospectionChange = default;
            if (discriminator?.Type == global::Supabase.ProjectUpgradeEligibilityResponseWarningDiscriminatorType.PgGraphqlIntrospectionChange)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1)}");
                pgGraphqlIntrospectionChange = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Supabase.WarningsItem(
                discriminator?.Type,
                pgGraphqlIntrospectionChange
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.WarningsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPgGraphqlIntrospectionChange)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.ProjectUpgradeEligibilityResponseWarningVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PgGraphqlIntrospectionChange!, typeInfo);
            }
        }
    }
}