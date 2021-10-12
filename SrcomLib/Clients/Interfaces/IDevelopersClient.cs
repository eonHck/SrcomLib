using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Interfaces
{
    /// <summary>
    /// Interface for starting building a Developer request
    /// </summary>
    public interface IDevelopersClient
    {
        /// <summary>
        /// Add the Developer Id to the request
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IDevelopersClientIdQuery WithId(string id);

        /// <summary>
        /// Set the maximum number of records to return from the search
        /// </summary>
        /// <param name="maxRecords">max value is 200</param>
        /// <returns></returns>
        IDevelopersClientSearchQuery WithMaxRecordsReturned(uint maxRecords);

        /// <summary>
        /// Sort the results ascending on the specified field
        /// </summary>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        IDevelopersClientSearchQuery WithSort(DeveloperSortField orderBy);

        /// <summary>
        /// Sort the results descending on the specified field
        /// </summary>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        IDevelopersClientSearchQuery WithSortDescending(DeveloperSortField orderBy);

        /// <summary>
        /// Execute the search request asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IReadOnlyList<Developer>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Execute the search request
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        IReadOnlyList<Developer> ExecuteSearch(bool ignoreCache = false);
    }
}