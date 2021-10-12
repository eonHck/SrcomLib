using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    public class CategoriesSubClientSearchQuery : ICategoriesSubClientSearchQuery
    {
        private readonly CategoriesClient _categoriesClient;
        internal CategoriesSubClientSearchQuery(CategoriesClient categoriesClient)
        {
            _categoriesClient = categoriesClient;
        }

        /// <inheritdoc/>
        public ICategoriesSubClientSearchQuery ExcludeMiscellaneousCategories()
        {
            _categoriesClient.ExcludeMiscellanousCategories();
            return this;
        }

        /// <inheritdoc/>
        public ICategoriesSubClientSearchQuery WithSort(CategorySortField orderBy)
        {
            _categoriesClient.WithSort(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public ICategoriesSubClientSearchQuery WithSortDescending(CategorySortField orderBy)
        {
            _categoriesClient.WithSortDescending(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Category>> GetListAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _categoriesClient.GetListAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Category> GetList(bool ignoreCache = false)
        {
            return _categoriesClient.GetList(ignoreCache);
        }
    }
}