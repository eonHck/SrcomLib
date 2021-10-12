using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for building and submitting a Run search Query
    /// </summary>
    public class RunsClientSearchQuery : IRunsClientSearchQuery
    {
        private readonly RunsClient _runsClient;
        internal RunsClientSearchQuery(RunsClient runsClient)
        {
            _runsClient = runsClient;
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery WithSearch(RunSearchField field, string searchValue)
        {
            _runsClient.WithSearch(field, searchValue);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery WithSearch(IDictionary<RunSearchField, string> searchParameters)
        {
            _runsClient.WithSearch(searchParameters);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _runsClient.WithMaxRecordsReturned(maxRecords);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery IncludeEmbed(RunEmbed embed)
        {
            _runsClient.IncludeEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery IncludeCategoryEmbed(CategoryEmbed embed)
        {
            _runsClient.IncludeCategoryEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery IncludeGameEmbed(GameEmbed embed)
        {
            _runsClient.IncludeGameEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery IncludeLevelEmbed(LevelEmbed embed)
        {
            _runsClient.IncludeLevelEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery IncludeEmbeds(List<RunEmbed> embeds)
        {
            _runsClient.IncludeEmbeds(embeds);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery IncludeCategoryEmbeds(List<CategoryEmbed> embed)
        {
            _runsClient.IncludeCategoryEmbeds(embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery IncludeGameEmbeds(List<GameEmbed> embed)
        {
            _runsClient.IncludeGameEmbeds(embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery IncludeLevelEmbeds(List<LevelEmbed> embed)
        {
            _runsClient.IncludeLevelEmbeds(embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery WithSort(RunSortField orderBy)
        {
            _runsClient.WithSort(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery WithSortDescending(RunSortField orderBy)
        {
            _runsClient.WithSortDescending(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Run>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _runsClient.ExecuteSearchAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Run> ExecuteSearch(bool ignoreCache = false)
        {
            return _runsClient.ExecuteSearch(ignoreCache);
        }
    }
}