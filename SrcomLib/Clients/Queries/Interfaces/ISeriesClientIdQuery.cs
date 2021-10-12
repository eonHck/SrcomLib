using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for building and submitting a Series Id Query
    /// </summary>
    public interface ISeriesClientIdQuery
    {
        /// <summary>
        /// Get the Games associated with the selected Series Id
        /// </summary>
        /// <returns></returns>
        IGamesSubClientSearchQuery Games();

        /// <summary>
        /// Embed an object in the response
        /// </summary>
        /// <param name="embed"></param>
        /// <returns></returns>
        ISeriesClientIdQuery IncludeEmbed(SeriesEmbed embed);

        /// <summary>
        /// Gets the specified Series data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Series> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Series data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Series Get(bool ignoreCache = false);
    }
}