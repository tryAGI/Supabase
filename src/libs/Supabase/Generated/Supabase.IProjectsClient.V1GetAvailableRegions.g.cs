#nullable enable

namespace Supabase
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// [Beta] Gets the list of available regions that can be used for a new project
        /// </summary>
        /// <param name="organizationSlug">
        /// Example: tsrqponmlkjihgfedcba
        /// </param>
        /// <param name="continent">
        /// Example: NA
        /// </param>
        /// <param name="desiredInstanceSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "SUPABASE_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Supabase.RegionsInfo> V1GetAvailableRegionsAsync(
            string organizationSlug,
            global::Supabase.V1GetAvailableRegionsContinent? continent = default,
            global::Supabase.V1GetAvailableRegionsDesiredInstanceSize? desiredInstanceSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}