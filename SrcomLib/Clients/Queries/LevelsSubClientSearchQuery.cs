using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Interface for Building a Level Sub-Query
    /// </summary>
    public class LevelsSubClientSearchQuery : ILevelsSubClientSearchQuery
    {
        private readonly LevelsClient _levelsClient;
        internal LevelsSubClientSearchQuery(LevelsClient levelsClient)
        {
            _levelsClient = levelsClient;
        }

        /// <inheritdoc/>
        public ILevelsSubClientSearchQuery WithSort(LevelSortField orderBy)
        {
            _levelsClient.WithSort(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public ILevelsSubClientSearchQuery WithSortDescending(LevelSortField orderBy)
        {
            _levelsClient.WithSortDescending(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Level>> GetListAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _levelsClient.GetListAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Level> GetList(bool ignoreCache = false)
        {
            return _levelsClient.GetList(ignoreCache);
        }
    }
}