using SrcomLib.Clients.Queries.Interfaces;
using System.Collections.Generic;

namespace SrcomLib.Clients.Interfaces
{
    /// <summary>
    /// Interface for starting building a Level request
    /// </summary>
    public interface ILevelsClient
    {
        /// <summary>
        /// Add the Level Id to the request
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ILevelsClientIdQuery WithId(string id);

        /// <summary>
        /// Embed an object in the response
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ILevelsClient IncludeEmbed(LevelEmbed embed);

        /// <summary>
        /// Embed an object in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ILevelsClient IncludeCategoryEmbed(CategoryEmbed embed);

        /// <summary>
        /// Embed multiple objects in the response
        /// </summary>
        /// <param name="embeds"></param>
        /// <returns></returns>
        ILevelsClient IncludeEmbeds(List<LevelEmbed> embeds);

        /// <summary>
        /// Embed multiple objects in the Category embed in the response
        /// Must also embed Category in the request for this to matter
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ILevelsClient IncludeCategoryEmbeds(List<CategoryEmbed> embeds);
    }
}