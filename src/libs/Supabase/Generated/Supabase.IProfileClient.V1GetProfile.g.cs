#nullable enable

namespace Supabase
{
    public partial interface IProfileClient
    {
        /// <summary>
        /// Gets the user's profile
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1ProfileResponse> V1GetProfileAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}