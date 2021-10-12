using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for building and submitting a Run Id Query
    /// </summary>
    public interface IRunsClientIdQuery
    {
        /// <summary>
        /// Embed an object in the response
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IRunsClientIdQuery IncludeEmbed(RunEmbed embed);

        /// <summary>
        /// Embed an object in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IRunsClientIdQuery IncludeCategoryEmbed(CategoryEmbed embed);

        /// <summary>
        /// Embed an object in the Game embed in the response
        /// Must also embed Game in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IRunsClientIdQuery IncludeGameEmbed(GameEmbed embed);

        /// <summary>
        /// Embed an object in the Level embed in the response
        /// Must also embed Level in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IRunsClientIdQuery IncludeLevelEmbed(LevelEmbed embed);

        /// <summary>
        /// Embed multiple objects in the response
        /// </summary>
        /// <param name="embeds"></param>
        /// <returns></returns>
        IRunsClientIdQuery IncludeEmbeds(List<RunEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IRunsClientIdQuery IncludeCategoryEmbeds(List<CategoryEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Game embed in the response
        /// Must also embed Game in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IRunsClientIdQuery IncludeGameEmbeds(List<GameEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Level embed in the response
        /// Must also embed Level in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IRunsClientIdQuery IncludeLevelEmbeds(List<LevelEmbed> embeds);

        /// <summary>
        /// Gets the specified Run data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Run> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Run data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Run Get(bool ignoreCache = false);
    }
}