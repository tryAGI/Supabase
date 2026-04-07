#nullable enable

namespace Supabase
{
    public partial interface IRestClient
    {
        /// <summary>
        /// Gets project's postgrest config
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.PostgrestConfigWithJWTSecretResponse> V1GetPostgrestServiceConfigAsync(
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}