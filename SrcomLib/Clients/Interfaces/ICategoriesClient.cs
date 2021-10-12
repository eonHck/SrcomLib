using SrcomLib.Clients.Queries.Interfaces;
using System.Collections.Generic;

namespace SrcomLib.Clients.Interfaces
{
    /// <summary>
    /// Interface for starting building a Category request
    /// </summary>
    public interface ICategoriesClient
    {
        /// <summary>
        /// Add the Category Id to the request
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ICategoriesClientIdQuery WithId(string id);

        /// <summary>
        /// Embed an object in the response
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ICategoriesClient IncludeEmbed(CategoryEmbed embed);

        /// <summary>
        /// Embed an object in the Game embed in the response
        /// Must also embed Game in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ICategoriesClient IncludeGameEmbed(GameEmbed embed);

        /// <summary>
        /// Embed multiple objects in the response
        /// </summary>
        /// <param name="embeds"></param>
        /// <returns></returns>
        ICategoriesClient IncludeEmbeds(List<CategoryEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Game embed in the response
        /// Must also embed Game in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ICategoriesClient IncludeGameEmbeds(List<GameEmbed> embeds);
    }
}