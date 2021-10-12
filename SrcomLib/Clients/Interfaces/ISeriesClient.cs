using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Interfaces
{
    /// <summary>
    /// Interface for starting building a Series request
    /// </summary>
    public interface ISeriesClient
    {
        /// <summary>
        /// Add the Series Id to the request
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ISeriesClientIdQuery WithId(string id);

        /// <summary>
        /// Add a search parameter for the field and value specified to the query
        /// </summary>
        /// <param name="field"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        ISeriesClientSearchQuery WithSearch(SeriesSearchField field, string searchValue);

        /// <summary>
        /// Add multiple search parameters for the fields and values specified to the query
        /// </summary>
        /// <param name="searchParameters"></param>
        /// <returns></returns>
        ISeriesClientSearchQuery WithSearch(IDictionary<SeriesSearchField, string> searchParameters);

        /// <summary>
        /// Set the maximum number of records to return from the search
        /// </summary>
        /// <param name="maxRecords">max value is 200</param>
        /// <returns></returns>
        ISeriesClientSearchQuery WithMaxRecordsReturned(uint maxRecords);

        /// <summary>
        /// Embed an object in the response
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ISeriesClient IncludeEmbed(SeriesEmbed embed);

        /// <summary>
        /// Sort the results ascending on the specified field
        /// </summary>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        ISeriesClientSearchQuery WithSort(SeriesSortField orderBy);

        /// <summary>
        /// Sort the results descending on the specified field
        /// </summary>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        ISeriesClientSearchQuery WithSortDescending(SeriesSortField orderBy);

        /// <summary>
        /// Execute the search request asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IReadOnlyList<Series>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Execute the search request
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        IReadOnlyList<Series> ExecuteSearch(bool ignoreCache = false);
    }
}