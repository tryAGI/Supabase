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
            if (__jsonProps.Contains("iops")) __score0++;
            if (__jsonProps.Contains("size_gb")) __score0++;
            if (__jsonProps.Contains("throughput_mibps")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("iops")) __score1++;
            if (__jsonProps.Contains("size_gb")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Supabase.DiskRequestBodyAttributesVariant1? gp3 = default;
            global::Supabase.DiskRequestBodyAttributesVariant2? io2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        gp3 = global::System.Text.Json.JsonSerializer.Deserialize<global::Supabase.DiskRequestBodyAttributesVariant1>(__rawJson, options);
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
                        io2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Supabase.DiskRequestBodyAttributesVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (gp3 == null && io2 == null)
            {
                try
                {
                    gp3 = global::System.Text.Json.JsonSerializer.Deserialize<global::Supabase.DiskRequestBodyAttributesVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    io2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Supabase.DiskRequestBodyAttributesVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Supabase.Attributes2(
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

            if (value.IsGp3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gp3, typeof(global::Supabase.DiskRequestBodyAttributesVariant1), options);
            }
            else if (value.IsIo2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Io2, typeof(global::Supabase.DiskRequestBodyAttributesVariant2), options);
            }
        }
    }
}