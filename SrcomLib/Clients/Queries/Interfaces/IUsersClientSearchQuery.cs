using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for building and submitting a User Search Query
    /// </summary>
    public interface IUsersClientSearchQuery
    {
        /// <summary>
        /// Add a search parameter for the field and value specified to the query
        /// </summary>
        /// <param name="field"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        IUsersClientSearchQuery WithSearch(UserSearchField field, string searchValue);

        /// <summary>
        /// Add multiple search parameters for the fields and values specified to the query
        /// </summary>
        /// <param name="searchParameters"></param>
        /// <returns></returns>
        IUsersClientSearchQuery WithSearch(IDictionary<UserSearchField, string> searchParameters);

        /// <summary>
        /// Set the maximum number of records to return from the search
        /// </summary>
        /// <param name="maxRecords">max value is 200</param>
        /// <returns></returns>
        IUsersClientSearchQuery WithMaxRecordsReturned(uint maxRecords);

        /// <summary>
        /// Sort the results ascending on the specified field
        /// </summary>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        IUsersClientSearchQuery WithSort(UserSortField orderBy);

        /// <summary>
        /// Sort the results descending on the specified field
        /// </summary>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        IUsersClientSearchQuery WithSortDescending(UserSortField orderBy);

        /// <summary>
        /// Execute the search request asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IReadOnlyList<User>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Execute the search request
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        IReadOnlyList<User> ExecuteSearch(bool ignoreCache = false);
    }
}