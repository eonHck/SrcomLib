using SrcomLib.Clients.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for building and submitting a Game Id Query
    /// </summary>
    public interface IGamesClientIdQuery
    {
        /// <summary>
        /// Get the Categories associated with the selected Game Id
        /// </summary>
        /// <returns></returns>
        ICategoriesSubClientSearchQuery Categories();

        /// <summary>
        /// Get the Derived Games associated with the selected Game Id
        /// </summary>
        /// <returns></returns>
        IGamesSubClientSearchQuery DerivedGames();

        /// <summary>
        /// Get the Levels associated with the selected Game Id
        /// </summary>
        /// <returns></returns>
        ILevelsSubClientSearchQuery Levels();

        /// <summary>
        /// Get the Variables associated with the selected Game Id
        /// </summary>
        /// <returns></returns>
        IVariablesSubClientExecutor Variables();

        /// <summary>
        /// Get the Records for for the selected Game Id
        /// </summary>
        /// <returns></returns>
        IRecordsClient Records();

        /// <summary>
        /// Embed an object in the response
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IGamesClientIdQuery IncludeEmbed(GameEmbed embed);

        /// <summary>
        /// Embed an object in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IGamesClientIdQuery IncludeCategoryEmbed(CategoryEmbed embed);

        /// <summary>
        /// Embed an object in the Level embed in the response
        /// Must also embed Level in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IGamesClientIdQuery IncludeLevelEmbed(LevelEmbed embed);

        /// <summary>
        /// Embed multiple objects in the response
        /// </summary>
        /// <param name="embeds"></param>
        /// <returns></returns>
        IGamesClientIdQuery IncludeEmbeds(List<GameEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IGamesClientIdQuery IncludeCategoryEmbeds(List<CategoryEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Level embed in the response
        /// Must also embed Level in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IGamesClientIdQuery IncludeLevelEmbeds(List<LevelEmbed> embeds);

        /// <summary>
        /// Gets the specified Game data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Game> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Game data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Game Get(bool ignoreCache = false);
    }
}