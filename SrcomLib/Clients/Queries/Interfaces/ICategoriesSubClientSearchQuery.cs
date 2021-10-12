using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for Building a Category Sub-Query
    /// </summary>
    public interface ICategoriesSubClientSearchQuery
    {
        /// <summary>
        /// Exclude Miscellaneous Categories from the results
        /// </summary>
        /// <returns></returns>
        ICategoriesSubClientSearchQuery ExcludeMiscellaneousCategories();

        /// <summary>
        /// Sort the results ascending on the specified field
        /// </summary>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        ICategoriesSubClientSearchQuery WithSort(CategorySortField orderBy);

        /// <summary>
        /// Sort the results descending on the specified field
        /// </summary>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        ICategoriesSubClientSearchQuery WithSortDescending(CategorySortField orderBy);

        /// <summary>
        /// Gets a List of Category data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IReadOnlyList<Category>> GetListAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a List of Category data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        IReadOnlyList<Category> GetList(bool ignoreCache = false);
    }
}