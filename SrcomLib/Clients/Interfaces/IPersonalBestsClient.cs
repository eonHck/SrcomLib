using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Interfaces
{
    /// <summary>
    /// Interface for Building a Personal Bests Sub-Query
    /// </summary>
    public interface IPersonalBestsClient
    {
        /// <summary>
        /// Add a search parameter for the field and value specified to the query
        /// </summary>
        /// <param name="field"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        IPersonalBestsClient WithSearch(PersonalBestsSearchField field, string searchValue);

        /// <summary>
        /// Add multiple search parameters for the fields and values specified to the query
        /// </summary>
        /// <param name="searchParameters"></param>
        /// <returns></returns>
        IPersonalBestsClient WithSearch(IDictionary<PersonalBestsSearchField, string> searchParameters);

        /// <summary>
        /// Embed an object in the response
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IPersonalBestsClient IncludeEmbed(PersonalBestsEmbed embed);

        /// <summary>
        /// Embed an object in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IPersonalBestsClient IncludeCategoryEmbed(CategoryEmbed embed);

        /// <summary>
        /// Embed an object in the Game embed in the response
        /// Must also embed Game in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IPersonalBestsClient IncludeGameEmbed(GameEmbed embed);

        /// <summary>
        /// Embed an object in the Level embed in the response
        /// Must also embed Level in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IPersonalBestsClient IncludeLevelEmbed(LevelEmbed embed);

        /// <summary>
        /// Embed multiple objects in the response
        /// </summary>
        /// <param name="embeds"></param>
        /// <returns></returns>
        IPersonalBestsClient IncludeEmbeds(List<PersonalBestsEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IPersonalBestsClient IncludeCategoryEmbeds(List<CategoryEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Game embed in the response
        /// Must also embed Game in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IPersonalBestsClient IncludeGameEmbeds(List<GameEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Level embed in the response
        /// Must also embed Level in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        IPersonalBestsClient IncludeLevelEmbeds(List<LevelEmbed> embeds);

        /// <summary>
        /// Gets the specified Personal Bests data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IReadOnlyList<PersonalBests>> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Personal Bests data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        IReadOnlyList<PersonalBests> Get(bool ignoreCache = false);
    }
}