#nullable enable

namespace Supabase
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Invites an external user to a database for JIT access<br/>
        /// Invites the external user and sets initial roles that can be assumed and for how long
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.InviteExternalUserJitResponse> V1InviteExternalJitAccessAsync(
            string @ref,

            global::Supabase.InviteExternalUserJitAccessBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invites an external user to a database for JIT access<br/>
        /// Invites the external user and sets initial roles that can be assumed and for how long
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.InviteExternalUserJitResponse>> V1InviteExternalJitAccessAsResponseAsync(
            string @ref,

            global::Supabase.InviteExternalUserJitAccessBody request,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invites an external user to a database for JIT access<br/>
        /// Invites the external user and sets initial roles that can be assumed and for how long
        /// </summary>
        /// <param name="ref">
        /// Example: abcdefghijklmnopqrst
        /// </param>
        /// <param name="email"></param>
        /// <param name="roles"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.InviteExternalUserJitResponse> V1InviteExternalJitAccessAsync(
            string @ref,
            string email,
            global::System.Collections.Generic.IList<global::Supabase.InviteExternalUserJitAccessBodyRole> roles,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}