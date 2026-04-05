#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Get PostgREST OpenAPI spec<br/>
        /// Returns the PostgREST OpenAPI specification for the project. This is the replacement for querying `/rest/v1/` directly with the anon key.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="schema">
        /// Default Value: public
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> V1GetDatabaseOpenapiAsync(
            string @ref,
            string? schema = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}