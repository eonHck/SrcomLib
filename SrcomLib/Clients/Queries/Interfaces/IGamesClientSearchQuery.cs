using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for building and submitting a Game Search Query
    /// </summary>
    public interface IGamesClientSearchQuery
    {
        /// <summary>
        /// Add a search parameter for the field and value specified to the query
        /// </summary>
        /// <param name="field"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        IGamesClientSearchQuery WithSearch(GameSearchField field, string searchValue);

        /// <summary>
        /// Add multiple search parameters for the fields and values specified to the query
        /// </summary>
        /// <param name="searchParameters"></param>
        /// <returns></returns>
        IGamesClientSearchQuery WithSearch(IDictionary<GameSearchField, string> searchParameters);

        /// <summary>
        /// Set the maximum number of records to return from the search
        /// </summary>
        /// <param name="maxRecords">max value is 200</param>
        /// <returns></returns>
        IGamesClientSearchQuery WithMaxRecordsReturned(uint maxRecords);

        /// <summary>
        /// Embed an object in the response
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IGamesClientSearchQuery IncludeEmbed(GameEmbed embed);

        /// <summary>
        /// Embed an object in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IGamesClientSearchQuery IncludeCategoryEmbed(CategoryEmbed embed);

        /// <summary>
        /// Embed an object in the Level embed in the response
        /// Must also embed Level in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IGamesClientSearchQuery IncludeLevelEmbed(LevelEmbed embed);

        /// <summary>
        /// Embed multiple objects in the response
        /// </summary>
        /// <param name="embeds"></param>
        /// <returns></returns>
        IGamesClientSearchQuery IncludeEmbeds(List<GameEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IGamesClientSearchQuery IncludeCategoryEmbeds(List<CategoryEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Level embed in the response
        /// Must also embed Level in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IGamesClientSearchQuery IncludeLevelEmbeds(List<LevelEmbed> embeds);

        /// <summary>
        /// Sort the results ascending on the specified field
        /// </summary>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        IGamesClientSearchQuery WithSort(GameSortField orderBy);

        /// <summary>
        /// Sort the results descending on the specified field
        /// </summary>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        IGamesClientSearchQuery WithSortDescending(GameSortField orderBy);

        /// <summary>
        /// Execute the search request asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IReadOnlyList<Game>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Execute the search request
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        IReadOnlyList<Game> ExecuteSearch(bool ignoreCache = false);
    }
}