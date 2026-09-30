#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Gets the list of available regions that can be used for a new project<br/>
        /// This is an **experimental** endpoint. It is subject to change or removal in future versions. Use it with caution, as it may not remain supported or stable.<br/>
        /// This endpoint is currently in its **Beta** stage.
        /// </summary>
        /// <param name="organizationSlug">
        /// Example: tsrqponmlkjihgfedcba
        /// </param>
        /// <param name="continent">
        /// Example: NA
        /// </param>
        /// <param name="desiredInstanceSize"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.RegionsInfoOutput> V1GetAvailableRegionsAsync(
            string organizationSlug,
            global::Supabase.V1GetAvailableRegionsContinent? continent = default,
            global::Supabase.V1GetAvailableRegionsDesiredInstanceSize? desiredInstanceSize = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the list of available regions that can be used for a new project<br/>
        /// This is an **experimental** endpoint. It is subject to change or removal in future versions. Use it with caution, as it may not remain supported or stable.<br/>
        /// This endpoint is currently in its **Beta** stage.
        /// </summary>
        /// <param name="organizationSlug">
        /// Example: tsrqponmlkjihgfedcba
        /// </param>
        /// <param name="continent">
        /// Example: NA
        /// </param>
        /// <param name="desiredInstanceSize"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.AutoSDKHttpResponse<global::Supabase.RegionsInfoOutput>> V1GetAvailableRegionsAsResponseAsync(
            string organizationSlug,
            global::Supabase.V1GetAvailableRegionsContinent? continent = default,
            global::Supabase.V1GetAvailableRegionsDesiredInstanceSize? desiredInstanceSize = default,
            global::Supabase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}