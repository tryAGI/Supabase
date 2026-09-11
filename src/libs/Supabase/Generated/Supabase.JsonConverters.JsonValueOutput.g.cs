#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Supabase.JsonConverters
{
    /// <inheritdoc />
    public class JsonValueOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Supabase.JsonValueOutput>
    {
        /// <inheritdoc />
        public override global::Supabase.JsonValueOutput Read(
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
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.AnyOf<string, double?, bool?>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(object), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Supabase.AnyOf<string, double?, bool?>? jsonValueOutputVariant1 = default;
            global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>? jsonValueOutputVariant2 = default;
            object? jsonValueOutputVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.AnyOf<string, double?, bool?>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.AnyOf<string, double?, bool?>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.AnyOf<string, double?, bool?>).Name}");
                        jsonValueOutputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>).Name}");
                        jsonValueOutputVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        jsonValueOutputVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (jsonValueOutputVariant1 == null && jsonValueOutputVariant2 == null && jsonValueOutputVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.AnyOf<string, double?, bool?>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.AnyOf<string, double?, bool?>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.AnyOf<string, double?, bool?>).Name}");
                    jsonValueOutputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (jsonValueOutputVariant1 == null && jsonValueOutputVariant2 == null && jsonValueOutputVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>).Name}");
                    jsonValueOutputVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (jsonValueOutputVariant1 == null && jsonValueOutputVariant2 == null && jsonValueOutputVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    jsonValueOutputVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Supabase.JsonValueOutput(
                jsonValueOutputVariant1,

                jsonValueOutputVariant2,

                jsonValueOutputVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Supabase.JsonValueOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsJsonValueOutputVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Supabase.AnyOf<string, double?, bool?>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Supabase.AnyOf<string, double?, bool?>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Supabase.AnyOf<string, double?, bool?>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonValueOutputVariant1!.Value, typeInfo);
            }
            else if (value.IsJsonValueOutputVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::Supabase.JsonValueOutput>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonValueOutputVariant2!, typeInfo);
            }
            else if (value.IsJsonValueOutputVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonValueOutputVariant3!, typeInfo);
            }
        }
    }
}