using Microsoft.Extensions.Caching.Memory;
using SrcomLib.ApiObjects.ResponseObjects;
using SrcomLib.Clients;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SrcomLib.Clients.Interfaces;

namespace SrcomLib
{
    /// <summary>
    /// Main entry point for accessing the speedrun.com api client
    /// </summary>
    public class SrcomClient
    {
        private const string BaseUri = @"https://www.speedrun.com/api/v1/";
        private static readonly SimpleHttpClientFactory httpClientFactory = SimpleHttpClientFactory.CreateHttpClientFactory();
        private readonly MemoryCache _cache;
        private readonly SrcomClientOptions _options;
        private readonly ObjectClients _clients;
        private readonly IApi _api;

        /// <summary>
        /// Access for Categories data
        /// </summary>
        public ICategoriesClient Categories => _clients.Categories;

        /// <summary>
        /// Access for Developers data
        /// </summary>
        public IDevelopersClient Developers => _clients.Developers;

        /// <summary>
        /// Access for Engines data
        /// </summary>
        public IEnginesClient Engines => _clients.Engines;

        /// <summary>
        /// Access for Games data
        /// </summary>
        public IGamesClient Games => _clients.Games;

        /// <summary>
        /// Access for GameTypes data
        /// </summary>
        public IGameTypesClient GameTypes => _clients.GameTypes;

        /// <summary>
        /// Access for Genres data
        /// </summary>
        public IGenresClient Genres => _clients.Genres;

        /// <summary>
        /// Access for Guests data
        /// </summary>
        public IGuestsClient Guests => _clients.Guests;

        /// <summary>
        /// Access for Leaderboards data
        /// </summary>
        public ILeaderboardClient Leaderboards => _clients.Leaderboards;

        /// <summary>
        /// Access for Levels data
        /// </summary>
        public ILevelsClient Levels => _clients.Levels;

        /// <summary>
        /// Access for Platforms data
        /// </summary>
        public IPlatformsClient Platforms => _clients.Platforms;

        /// <summary>
        /// Access for Publishers data
        /// </summary>
        public IPublishersClient Publishers => _clients.Publishers;

        /// <summary>
        /// Access for Regions data
        /// </summary>
        public IRegionsClient Regions => _clients.Regions;

        /// <summary>
        /// Access for Runs data
        /// </summary>
        public IRunsClient Runs => _clients.Runs;

        /// <summary>
        /// Access for Series data
        /// </summary>
        public ISeriesClient Series => _clients.Series;

        /// <summary>
        /// Access for Users data
        /// </summary>
        public IUsersClient Users => _clients.Users;

        /// <summary>
        /// Access for Variables data
        /// </summary>
        public IVariablesClient Variables => _clients.Variables;


        /// <summary>
        /// Constructor with default options
        /// </summary>
        public SrcomClient() : this(new SrcomClientOptions()) { }

        /// <summary>
        /// Constructor with overridden options
        /// </summary>
        /// <param name="clientOptions"></param>
        public SrcomClient(SrcomClientOptions clientOptions)
        {
            _options = clientOptions;
            _cache = new MemoryCache(_options.MemoryCacheOptions);
            _clients = new ObjectClients(this, _options.MaxSearchRecords);
            _api = new Api(_options.UserAgent, _options.AsyncRetryPolicy, _options.SynchronousRetryPolicy, httpClientFactory);
        }

        internal SrcomClient(IApi api)
        {
            _options = new SrcomClientOptions();
            _cache = new MemoryCache(_options.MemoryCacheOptions);
            _clients = new ObjectClients(this, _options.MaxSearchRecords);
            _api = api;
        }

        internal T Get<T>(string uriSuffix, bool ignoreCache = false)
        {
            return Get<T>(GetFullUri(uriSuffix), ignoreCache);
        }

        internal async Task<T> GetAsync<T>(string uriSuffix, CancellationToken cancellationToken, bool ignoreCache = false)
        {
            return await GetAsync<T>(GetFullUri(uriSuffix), cancellationToken, ignoreCache).ConfigureAwait(false);
        }

        internal List<T> GetPaged<T>(string uriSuffix, uint maxRecords = 100, bool ignoreCache = false)
        {
            return GetPaged<T>(GetFullUri(uriSuffix), maxRecords, ignoreCache);
        }

        internal async Task<List<T>> GetPagedAsync<T>(string uriSuffix, CancellationToken cancellationToken, uint maxRecords = 100, bool ignoreCache = false)
        {
            return await GetPagedAsync<T>(GetFullUri(uriSuffix), cancellationToken, maxRecords, ignoreCache).ConfigureAwait(false);
        }

        private Uri GetFullUri(string uriSuffix) => new Uri($"{BaseUri}{uriSuffix}");

        private T Get<T>(Uri uri, bool ignoreCache = false)
        {
            if (_cache.TryGetValue(uri.ToString(), out T data, ignoreCache)) return data;

            data = _api.Get<T>(uri);
            _cache.Set(uri.ToString(), data, _options.CacheTimeout, ignoreCache);

            return data;
        }

        private async Task<T> GetAsync<T>(Uri uri, CancellationToken cancellationToken, bool ignoreCache = false)
        {
            if (_cache.TryGetValue(uri.ToString(), out T data, ignoreCache)) return data;

            data = await _api.GetAsync<T>(uri, cancellationToken).ConfigureAwait(false);
            _cache.Set(uri.ToString(), data, _options.CacheTimeout, ignoreCache);

            return data;
        }

        private List<T> GetPaged<T>(Uri uri, uint maxRecords = 100, bool ignoreCache = false)
        {
            var data = new List<T>();

            while (data.Count < maxRecords)
            {
                var responseData = GetSinglePage<T>(uri, ignoreCache);
                data.AddRange(responseData.Data);
                if (!responseData.Pagination.TryGetNextUri(out uri)) break;
            }

            if (data.Count > maxRecords) data.RemoveRange((int)maxRecords, data.Count - (int)maxRecords);

            return data;
        }

        private async Task<List<T>> GetPagedAsync<T>(Uri uri, CancellationToken cancellationToken, uint maxRecords = 100, bool ignoreCache = false)
        {
            var data = new List<T>();

            while (data.Count < maxRecords)
            {
                var responseData = await GetSinglePageAsync<T>(uri, cancellationToken, ignoreCache).ConfigureAwait(false);
                data.AddRange(responseData.Data);
                if (!responseData.Pagination.TryGetNextUri(out uri)) break;
            }

            if (data.Count > maxRecords) data.RemoveRange((int)maxRecords, data.Count - (int)maxRecords);

            return data;
        }

        private ApiResponseObject<List<T>> GetSinglePage<T>(Uri uri, bool ignoreCache = false)
        {
            if (_cache.TryGetValue(uri.ToString(), out ApiResponseObject<List<T>> responseData, ignoreCache)) return responseData;

            responseData = _api.GetApiResponseObject<List<T>>(uri);
            _cache.Set(uri.ToString(), responseData, _options.CacheTimeout, ignoreCache);
            return responseData;
        }

        private async Task<ApiResponseObject<List<T>>> GetSinglePageAsync<T>(Uri uri, CancellationToken cancellationToken, bool ignoreCache = false)
        {
            if (_cache.TryGetValue(uri.ToString(), out ApiResponseObject<List<T>> responseData, ignoreCache)) return responseData;

            responseData = await _api.GetApiResponseObjectAsync<List<T>>(uri, cancellationToken).ConfigureAwait(false);
            _cache.Set(uri.ToString(), responseData, _options.CacheTimeout, ignoreCache);
            return responseData;
        }
    }
}