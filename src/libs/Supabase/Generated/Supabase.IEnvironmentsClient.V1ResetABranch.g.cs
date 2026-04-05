#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Supabase
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Resets a database branch<br/>
        /// Resets the specified database branch
        /// </summary>
        /// <param name="branchIdOrRef"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Supabase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.BranchUpdateResponse> V1ResetABranchAsync(
            global::Supabase.OneOf<string, global::System.Guid?> branchIdOrRef,

            global::Supabase.BranchActionBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resets a database branch<br/>
        /// Resets the specified database branch
        /// </summary>
        /// <param name="branchIdOrRef"></param>
        /// <param name="migrationVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Supabase.BranchUpdateResponse> V1ResetABranchAsync(
#pragma warning disable CS0618 // Type or member is obsolete
            global::Supabase.OneOf<string, global::System.Guid?> branchIdOrRef,
#pragma warning disable CS0618 // Type or member is obsolete
            string? migrationVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}