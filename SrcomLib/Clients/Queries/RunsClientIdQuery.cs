using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for building and submitting a Run Id Query
    /// </summary>
    public class RunsClientIdQuery : IRunsClientIdQuery
    {
        private readonly RunsClient _runsClient;
        internal RunsClientIdQuery(RunsClient runsClient)
        {
            _runsClient = runsClient;
        }

        /// <inheritdoc/>
        public IRunsClientIdQuery IncludeEmbed(RunEmbed embed)
        {
            _runsClient.IncludeEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientIdQuery IncludeCategoryEmbed(CategoryEmbed embed)
        {
            _runsClient.IncludeCategoryEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientIdQuery IncludeGameEmbed(GameEmbed embed)
        {
            _runsClient.IncludeGameEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientIdQuery IncludeLevelEmbed(LevelEmbed embed)
        {
            _runsClient.IncludeLevelEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientIdQuery IncludeEmbeds(List<RunEmbed> embeds)
        {
            _runsClient.IncludeEmbeds(embeds);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientIdQuery IncludeCategoryEmbeds(List<CategoryEmbed> embed)
        {
            _runsClient.IncludeCategoryEmbeds(embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientIdQuery IncludeGameEmbeds(List<GameEmbed> embed)
        {
            _runsClient.IncludeGameEmbeds(embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientIdQuery IncludeLevelEmbeds(List<LevelEmbed> embed)
        {
            _runsClient.IncludeLevelEmbeds(embed);
            return this;
        }

        /// <inheritdoc/>
        public async Task<Run> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _runsClient.GetAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public Run Get(bool ignoreCache = false)
        {
            return _runsClient.Get(ignoreCache);
        }
    }
}