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
            if (__jsonProps.Contains("code")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("code")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Supabase.V1CreateProjectBodyRegionSelectionVariant1? specific = default;
            global::Supabase.V1CreateProjectBodyRegionSelectionVariant2? smartGroup = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        specific = global::System.Text.Json.JsonSerializer.Deserialize<global::Supabase.V1CreateProjectBodyRegionSelectionVariant1>(__rawJson, options);
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
                        smartGroup = global::System.Text.Json.JsonSerializer.Deserialize<global::Supabase.V1CreateProjectBodyRegionSelectionVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (specific == null && smartGroup == null)
            {
                try
                {
                    specific = global::System.Text.Json.JsonSerializer.Deserialize<global::Supabase.V1CreateProjectBodyRegionSelectionVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    smartGroup = global::System.Text.Json.JsonSerializer.Deserialize<global::Supabase.V1CreateProjectBodyRegionSelectionVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Supabase.RegionSelection(
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

            if (value.IsSpecific)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Specific, typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant1), options);
            }
            else if (value.IsSmartGroup)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SmartGroup, typeof(global::Supabase.V1CreateProjectBodyRegionSelectionVariant2), options);
            }
        }
    }
}