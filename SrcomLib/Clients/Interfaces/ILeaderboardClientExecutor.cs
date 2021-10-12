using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SrcomLib.ResponseObjects;

namespace SrcomLib.Clients.Interfaces
{
    /// <summary>
    /// Interface for finalizing Leaderboard requests
    /// </summary>
    public interface ILeaderboardClientExecutor
    {
        /// <summary>
        /// Add a search parameter to the request
        /// </summary>
        /// <param name="field"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        ILeaderboardClientExecutor WithSearch(LeaderboardSearchField field, string searchValue);

        /// <summary>
        /// Add a variable search parameter to the request
        /// </summary>
        /// <param name="variableId"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        ILeaderboardClientExecutor WithVariableSearch(string variableId, string searchValue);

        /// <summary>
        /// Add multiple search parameters to the request
        /// </summary>
        /// <param name="searchParameters"></param>
        /// <returns></returns>
        ILeaderboardClientExecutor WithSearch(IDictionary<LeaderboardSearchField, string> searchParameters);

        /// <summary>
        /// Add multiple variable search parameters to the request
        /// </summary>
        /// <param name="variableSearchParameters"></param>
        /// <returns></returns>
        ILeaderboardClientExecutor WithVariableSearch(IDictionary<string, string> variableSearchParameters);

        /// <summary>
        /// Include the specified embedded data in the response
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ILeaderboardClientExecutor IncludeEmbed(LeaderboardEmbed embed);

        /// <summary>
        /// Embed an object in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ILeaderboardClientExecutor IncludeCategoryEmbed(CategoryEmbed embed);

        /// <summary>
        /// Embed an object in the Game embed in the response
        /// Must also embed Game in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ILeaderboardClientExecutor IncludeGameEmbed(GameEmbed embed);

        /// <summary>
        /// Embed an object in the Level embed in the response
        /// Must also embed Level in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ILeaderboardClientExecutor IncludeLevelEmbed(LevelEmbed embed);

        /// <summary>
        /// Include the specified list of embedded data in the response
        /// </summary>
        /// <param name="embeds"></param>
        /// <returns></returns>
        ILeaderboardClientExecutor IncludeEmbeds(List<LeaderboardEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ILeaderboardClientExecutor IncludeCategoryEmbeds(List<CategoryEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Game embed in the response
        /// Must also embed Game in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ILeaderboardClientExecutor IncludeGameEmbeds(List<GameEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Level embed in the response
        /// Must also embed Level in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ILeaderboardClientExecutor IncludeLevelEmbeds(List<LevelEmbed> embeds);

        /// <summary>
        /// Gets the specified Leaderboard data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Leaderboard> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Leaderboard data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Leaderboard Get(bool ignoreCache = false);
    }
}