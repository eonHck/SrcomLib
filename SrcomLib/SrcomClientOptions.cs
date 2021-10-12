using Microsoft.Extensions.Caching.Memory;
using Polly;
using Polly.Retry;
using System;
using System.Net.Http;

namespace SrcomLib
{
    /// <summary>
    /// Options for use in the SrcomClient constructor to control behavior
    /// </summary>
    public class SrcomClientOptions
    {
        private const int _cacheSizeDefault = 50;
        private const int _apiRetryCount = 5;
        private const uint _maxSearchRecords = 200;
        private readonly TimeSpan _cacheTimeoutDefault = new TimeSpan(1, 0, 0);
        private readonly string _userAgentDefault = "SrcomLib/0.1";

        /// <summary>
        /// The maximum number of api responses to save in the cache, default is 50
        /// </summary>
        public int CacheSize { get; set; }

        /// <summary>
        /// The number of times to retry on an API failure
        /// </summary>
        public int ApiRetryCount { get; set; }

        /// <summary>
        /// Default maximum number of records to be returned from a request, can be overriden on individual calls
        /// </summary>
        public uint MaxSearchRecords { get; set; }

        /// <summary>
        /// User Agent string to pass to the speedrun.com api
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// The amount of time for records to be kept in the cache before being removed as stale data
        /// </summary>
        public TimeSpan CacheTimeout { get; set; }

        internal AsyncRetryPolicy AsyncRetryPolicy => Policy.Handle<HttpRequestException>().WaitAndRetryAsync(ApiRetryCount, i => TimeSpan.FromSeconds(i));
        internal RetryPolicy SynchronousRetryPolicy => Policy.Handle<HttpRequestException>().WaitAndRetry(ApiRetryCount, i => TimeSpan.FromSeconds(i));
        internal MemoryCacheOptions MemoryCacheOptions => new MemoryCacheOptions() { SizeLimit = CacheSize };


        /// <summary>
        /// Default Constructor
        /// </summary>
        public SrcomClientOptions()
        {
            CacheSize = _cacheSizeDefault;
            ApiRetryCount = _apiRetryCount;
            MaxSearchRecords = _maxSearchRecords;
            CacheTimeout = _cacheTimeoutDefault;
            UserAgent = _userAgentDefault;
        }
    }
}