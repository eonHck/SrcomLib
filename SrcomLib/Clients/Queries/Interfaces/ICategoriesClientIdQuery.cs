using SrcomLib.Clients.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for building and submitting a Category Id Query
    /// </summary>
    public interface ICategoriesClientIdQuery
    {
        /// <summary>
        /// Get the Variables associated with the selected Category Id
        /// </summary>
        /// <returns></returns>
        IVariablesSubClientExecutor Variables();

        /// <summary>
        /// Get the Records for for the selected Category Id
        /// </summary>
        /// <returns></returns>
        IRecordsClient Records();

        /// <summary>
        /// Embed an object in the response
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ICategoriesClientIdQuery IncludeEmbed(CategoryEmbed embed);

        /// <summary>
        /// Embed an object in the Game embed in the response
        /// Must also embed Game in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ICategoriesClientIdQuery IncludeGameEmbed(GameEmbed embed);

        /// <summary>
        /// Embed multiple objects in the response
        /// </summary>
        /// <param name="embeds"></param>
        /// <returns></returns>
        ICategoriesClientIdQuery IncludeEmbeds(List<CategoryEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Game embed in the response
        /// Must also embed Game in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ICategoriesClientIdQuery IncludeGameEmbeds(List<GameEmbed> embeds);

        /// <summary>
        /// Gets the specified Category data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Category> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Category data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Category Get(bool ignoreCache = false);
    }
}