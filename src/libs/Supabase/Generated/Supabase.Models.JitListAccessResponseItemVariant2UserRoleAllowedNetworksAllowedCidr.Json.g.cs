#nullable enable

namespace Supabase
{
    public sealed partial class JitListAccessResponseItemVariant2UserRoleAllowedNetworksAllowedCidr
    {
        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the generated default JsonSerializerContext.
        /// </summary>
        public string ToJson()
        {
            return ToJson(global::Supabase.SourceGenerationContext.Default);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            if (jsonSerializerOptions is null)
            {
                return ToJson(global::Supabase.SourceGenerationContext.Default);
            }

            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Supabase.JitListAccessResponseItemVariant2UserRoleAllowedNetworksAllowedCidr? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Supabase.JitListAccessResponseItemVariant2UserRoleAllowedNetworksAllowedCidr),
                jsonSerializerContext) as global::Supabase.JitListAccessResponseItemVariant2UserRoleAllowedNetworksAllowedCidr;
        }

        /// <summary>
        /// Deserializes a JSON string using the generated default JsonSerializerContext.
        /// </summary>
        public static global::Supabase.JitListAccessResponseItemVariant2UserRoleAllowedNetworksAllowedCidr? FromJson(
            string json)
        {
            return FromJson(
                json,
                global::Supabase.SourceGenerationContext.Default);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Supabase.JitListAccessResponseItemVariant2UserRoleAllowedNetworksAllowedCidr? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            if (jsonSerializerOptions is null)
            {
                return FromJson(
                    json,
                    global::Supabase.SourceGenerationContext.Default);
            }

            return global::System.Text.Json.JsonSerializer.Deserialize<global::Supabase.JitListAccessResponseItemVariant2UserRoleAllowedNetworksAllowedCidr>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::Supabase.JitListAccessResponseItemVariant2UserRoleAllowedNetworksAllowedCidr?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::Supabase.JitListAccessResponseItemVariant2UserRoleAllowedNetworksAllowedCidr),
                jsonSerializerContext).ConfigureAwait(false)) as global::Supabase.JitListAccessResponseItemVariant2UserRoleAllowedNetworksAllowedCidr;
        }

        /// <summary>
        /// Deserializes a JSON stream using the generated default JsonSerializerContext.
        /// </summary>
        public static global::System.Threading.Tasks.ValueTask<global::Supabase.JitListAccessResponseItemVariant2UserRoleAllowedNetworksAllowedCidr?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream)
        {
            return FromJsonStreamAsync(
                jsonStream,
                global::Supabase.SourceGenerationContext.Default);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::Supabase.JitListAccessResponseItemVariant2UserRoleAllowedNetworksAllowedCidr?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            if (jsonSerializerOptions is null)
            {
                return FromJsonStreamAsync(
                    jsonStream,
                    global::Supabase.SourceGenerationContext.Default);
            }

            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::Supabase.JitListAccessResponseItemVariant2UserRoleAllowedNetworksAllowedCidr?>(
                jsonStream,
                jsonSerializerOptions);
        }
    }
}
