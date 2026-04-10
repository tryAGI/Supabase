#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Generate TypeScript types<br/>
        /// Returns the TypeScript types of your schema for use with supabase-js.
        /// </summary>
        /// <param name="includedSchemas">
        /// Default Value: public<br/>
        /// Example: public,auth
        /// </param>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.TypescriptResponse> V1GenerateTypescriptTypesAsync(
            string @ref,
            string? includedSchemas = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}