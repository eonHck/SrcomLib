using SrcomLib.Clients.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for building and submitting a Level Id Query
    /// </summary>
    public interface ILevelsClientIdQuery
    {
        /// <summary>
        /// Get the Categories associated with the selected Level Id
        /// </summary>
        /// <returns></returns>
        ICategoriesSubClientSearchQuery Categories();

        /// <summary>
        /// Get the Variables associated with the selected Level Id
        /// </summary>
        /// <returns></returns>
        IVariablesSubClientExecutor Variables();

        /// <summary>
        /// Get the Records for for the selected Level Id
        /// </summary>
        /// <returns></returns>
        IRecordsClient Records();

        /// <summary>
        /// Embed an object in the response
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ILevelsClientIdQuery IncludeEmbed(LevelEmbed embed);

        /// <summary>
        /// Embed an object in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ILevelsClientIdQuery IncludeCategoryEmbed(CategoryEmbed embed);

        /// <summary>
        /// Embed multiple objects in the response
        /// </summary>
        /// <param name="embeds"></param>
        /// <returns></returns>
        ILevelsClientIdQuery IncludeEmbeds(List<LevelEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ILevelsClientIdQuery IncludeCategoryEmbeds(List<CategoryEmbed> embeds);

        /// <summary>
        /// Gets the specified Level data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Level> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Game data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Level Get(bool ignoreCache = false);
    }
}