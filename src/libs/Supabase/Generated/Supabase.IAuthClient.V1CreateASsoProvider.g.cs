#nullable enable

namespace Supabase
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Creates a new SSO provider
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.CreateProviderResponse> V1CreateASsoProviderAsync(
            string @ref,

            global::Supabase.CreateProviderBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new SSO provider
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="type">
        /// What type of provider will be created
        /// </param>
        /// <param name="metadataXml"></param>
        /// <param name="metadataUrl"></param>
        /// <param name="domains"></param>
        /// <param name="attributeMapping"></param>
        /// <param name="nameIdFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.CreateProviderResponse> V1CreateASsoProviderAsync(
            string @ref,
            global::Supabase.CreateProviderBodyType type = default,
            string? metadataXml = default,
            string? metadataUrl = default,
            global::System.Collections.Generic.IList<string>? domains = default,
            global::Supabase.CreateProviderBodyAttributeMapping? attributeMapping = default,
            global::Supabase.CreateProviderBodyNameIdFormat? nameIdFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}