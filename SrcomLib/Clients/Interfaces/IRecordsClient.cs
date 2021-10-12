using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Interfaces
{
    /// <summary>
    /// Interface for Building a Records Sub-Query
    /// </summary>
    public interface IRecordsClient
    {
        /// <summary>
        /// Set the maximum number of records to return from the search
        /// </summary>
        /// <param name="maxRecords">max value is 200</param>
        /// <returns></returns>
        IRecordsClient WithMaxRecordsReturned(uint maxRecords);

        /// <summary>
        /// Embed an object in the response
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IRecordsClient IncludeEmbed(LeaderboardEmbed embed);

        /// <summary>
        /// Embed an object in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IRecordsClient IncludeCategoryEmbed(CategoryEmbed embed);

        /// <summary>
        /// Embed an object in the Game embed in the response
        /// Must also embed Game in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IRecordsClient IncludeGameEmbed(GameEmbed embed);

        /// <summary>
        /// Embed an object in the Level embed in the response
        /// Must also embed Level in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IRecordsClient IncludeLevelEmbed(LevelEmbed embed);

        /// <summary>
        /// Embed multiple objects in the response
        /// </summary>
        /// <param name="embeds"></param>
        /// <returns></returns>
        IRecordsClient IncludeEmbeds(List<LeaderboardEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IRecordsClient IncludeCategoryEmbeds(List<CategoryEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Game embed in the response
        /// Must also embed Game in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IRecordsClient IncludeGameEmbeds(List<GameEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Level embed in the response
        /// Must also embed Level in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IRecordsClient IncludeLevelEmbeds(List<LevelEmbed> embeds);

        /// <summary>
        /// Execute the search request asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IReadOnlyList<Leaderboard>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Execute the search request
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        IReadOnlyList<Leaderboard> ExecuteSearch(bool ignoreCache = false);

    }
}