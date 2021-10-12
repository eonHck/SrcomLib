using SrcomLib.Clients.Interfaces;
using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Interface for building and submitting a Level Id Query
    /// </summary>
    public class LevelsClientIdQuery : ILevelsClientIdQuery
    {
        private readonly LevelsClient _levelsClient;
        internal LevelsClientIdQuery(LevelsClient levelsClient)
        {
            _levelsClient = levelsClient;
        }

        /// <inheritdoc/>
        public ICategoriesSubClientSearchQuery Categories()
        {
            return _levelsClient.Categories();
        }

        /// <inheritdoc/>
        public IVariablesSubClientExecutor Variables()
        {
            return _levelsClient.Variables();
        }

        /// <inheritdoc/>
        public IRecordsClient Records()
        {
            return _levelsClient.Records();
        }

        /// <inheritdoc/>
        public ILevelsClientIdQuery IncludeEmbed(LevelEmbed embed)
        {
            _levelsClient.IncludeEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public ILevelsClientIdQuery IncludeCategoryEmbed(CategoryEmbed embed)
        {
            _levelsClient.IncludeCategoryEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public ILevelsClientIdQuery IncludeEmbeds(List<LevelEmbed> embeds)
        {
            _levelsClient.IncludeEmbeds(embeds);
            return this;
        }

        /// <inheritdoc/>
        public ILevelsClientIdQuery IncludeCategoryEmbeds(List<CategoryEmbed> embeds)
        {
            _levelsClient.IncludeCategoryEmbeds(embeds);
            return this;
        }

        /// <inheritdoc/>
        public async Task<Level> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _levelsClient.GetAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public Level Get(bool ignoreCache = false)
        {
            return _levelsClient.Get(ignoreCache);
        }
    }
}