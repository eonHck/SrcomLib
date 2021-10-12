using System;
using System.Linq;
using System.Net.Http;

namespace SrcomLib
{
    internal class SimpleHttpClientFactory
    {
        private HttpClientHandler _handler;
        private DateTime _handlerRenewTime;
        private readonly TimeSpan _handlerLifeSpan = TimeSpan.FromMinutes(20);

        private static SimpleHttpClientFactory factory;

        public static SimpleHttpClientFactory CreateHttpClientFactory()
        {
            return factory ?? (factory = new SimpleHttpClientFactory());
        }

        private SimpleHttpClientFactory() { }

        public HttpClient CreateClient(string userAgent)
        {
            var client = new HttpClient(GetOrCreateHandler(), false);
            client.DefaultRequestHeaders.Add("User-Agent", userAgent);
            return client;
        }

        private HttpClientHandler GetOrCreateHandler()
        {
            if (!ShouldRenewHandler())
            {
                return _handler;
            }

            _handler?.Dispose();
            _handler = new HttpClientHandler();
            _handlerRenewTime = DateTime.UtcNow.Add(_handlerLifeSpan);
            return _handler;
        }

        private bool ShouldRenewHandler()
        {
            return _handler is null || DateTime.UtcNow.CompareTo(_handlerRenewTime) >= 0;
        }
    }
}