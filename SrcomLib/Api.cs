using Newtonsoft.Json;
using Polly.Retry;
using SrcomLib.ApiObjects.ResponseObjects;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib
{
    internal class Api : IApi
    {
        private readonly SimpleHttpClientFactory _httpClientFactory;
        private readonly AsyncRetryPolicy _asyncRetryPolicy;
        private readonly RetryPolicy _synchronousRetryPolicy;
        private readonly string _userAgent;

        public Api(string userAgent, AsyncRetryPolicy asyncRetryPolicy, RetryPolicy synchronousRetryPolicy, SimpleHttpClientFactory httpClientFactory)
        {
            _userAgent = (!string.IsNullOrEmpty(userAgent)) ? userAgent : throw new ArgumentNullException(nameof(userAgent)); 
            _asyncRetryPolicy = asyncRetryPolicy ?? throw new ArgumentNullException(nameof(asyncRetryPolicy));
            _synchronousRetryPolicy = synchronousRetryPolicy ?? throw new ArgumentNullException(nameof(synchronousRetryPolicy));
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }

        public async Task<TApiObject> GetAsync<TApiObject>(Uri uri, CancellationToken cancellationToken)
        {
            var responseObject = await GetApiResponseObjectAsync<TApiObject>(uri, cancellationToken).ConfigureAwait(false);
            return responseObject.Data;
        }

        public TApiObject Get<TApiObject>(Uri uri)
        {
            var responseObject = GetApiResponseObject<TApiObject>(uri);
            return responseObject.Data;
        }

        public async Task<ApiResponseObject<TApiObject>> GetApiResponseObjectAsync<TApiObject>(Uri uri, CancellationToken cancellationToken)
        {
            return await _asyncRetryPolicy.ExecuteAsync(async () =>
            {
                HttpResponseMessage response = await _httpClientFactory.CreateClient(_userAgent)
                    .GetAsync(uri, cancellationToken)
                    .ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<ApiResponseObject<TApiObject>>(json);
            }).ConfigureAwait(false);
        }

        public ApiResponseObject<TApiObject> GetApiResponseObject<TApiObject>(Uri uri)
        {
            return _synchronousRetryPolicy.Execute(() =>
            {
                var json = string.Empty;
                var request = (HttpWebRequest)WebRequest.Create(uri);

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    using (var reader = new StreamReader(stream))
                    {
                        if ((int)response.StatusCode >= 500 || response.StatusCode == HttpStatusCode.RequestTimeout)
                        {
                            throw new HttpRequestException($"Get Request {uri} failed");
                        }
                        json = reader.ReadToEnd();
                    }
                }

                return JsonConvert.DeserializeObject<ApiResponseObject<TApiObject>>(json);
            });
        }
    }
}