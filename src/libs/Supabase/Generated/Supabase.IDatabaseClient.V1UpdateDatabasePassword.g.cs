#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Updates the database password
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1UpdatePasswordResponse> V1UpdateDatabasePasswordAsync(
            string @ref,

            global::Supabase.V1UpdatePasswordBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the database password
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="password"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.V1UpdatePasswordResponse> V1UpdateDatabasePasswordAsync(
            string @ref,
            string password,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}