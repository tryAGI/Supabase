#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public class JitStateResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.JitStateResponse>
    {
        /// <inheritdoc />
        public override global::Supabase.JitStateResponse Read(
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
            if (__jsonProps.Contains("appliedSuccessfully")) __score0++;
            if (__jsonProps.Contains("state")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("state")) __score1++;
            if (__jsonProps.Contains("unavailableReason")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Supabase.JitStateResponseVariant1? jitStateResponseVariant1 = default;
            global::Supabase.JitStateResponseVariant2? unavailable = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.JitStateResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.JitStateResponseVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.JitStateResponseVariant1).Name}");
                        jitStateResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.JitStateResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.JitStateResponseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.JitStateResponseVariant2).Name}");
                        unavailable = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (jitStateResponseVariant1 == null && unavailable == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.JitStateResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.JitStateResponseVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.JitStateResponseVariant1).Name}");
                    jitStateResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.JitStateResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.JitStateResponseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.JitStateResponseVariant2).Name}");
                    unavailable = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Supabase.JitStateResponse(
                jitStateResponseVariant1,

                unavailable
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.JitStateResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsJitStateResponseVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.JitStateResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.JitStateResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.JitStateResponseVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JitStateResponseVariant1!, typeInfo);
            }
            else if (value.IsUnavailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.JitStateResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.JitStateResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.JitStateResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unavailable!, typeInfo);
            }
        }
    }
}