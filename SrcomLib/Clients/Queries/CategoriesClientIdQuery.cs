using SrcomLib.Clients.Interfaces;
using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for building and submitting a Category Id Query
    /// </summary>
    public class CategoriesClientIdQuery : ICategoriesClientIdQuery
    {
        private readonly CategoriesClient _categoriesClient;
        internal CategoriesClientIdQuery(CategoriesClient categoriesClient)
        {
            _categoriesClient = categoriesClient;
        }

        /// <inheritdoc/>
        public IVariablesSubClientExecutor Variables()
        {
            return _categoriesClient.Variables();
        }

        /// <inheritdoc/>
        public IRecordsClient Records()
        {
            return _categoriesClient.Records();
        }

        /// <inheritdoc/>
        public ICategoriesClientIdQuery IncludeEmbed(CategoryEmbed embed)
        {
            _categoriesClient.IncludeEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public ICategoriesClientIdQuery IncludeGameEmbed(GameEmbed embed)
        {
            _categoriesClient.IncludeGameEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public ICategoriesClientIdQuery IncludeEmbeds(List<CategoryEmbed> embeds)
        {
            _categoriesClient.IncludeEmbeds(embeds);
            return this;
        }

        /// <inheritdoc/>
        public ICategoriesClientIdQuery IncludeGameEmbeds(List<GameEmbed> embeds)
        {
            _categoriesClient.IncludeGameEmbeds(embeds);
            return this;
        }

        /// <inheritdoc/>
        public async Task<Category> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _categoriesClient.GetAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public Category Get(bool ignoreCache = false)
        {
            return _categoriesClient.Get(ignoreCache);
        }
    }
}