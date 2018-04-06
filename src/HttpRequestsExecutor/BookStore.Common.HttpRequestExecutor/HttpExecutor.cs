using BookStore.Common.HttpRequestExecutor.Design;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Common.HttpRequestExecutor
{
    public class HttpExecutor : IHttpExecutor
    {
        private readonly IRequestSender requestSender;
        private readonly IResponseDeserializer responseDeserializer;

        public HttpExecutor(IRequestSender requestSender, IResponseDeserializer responseDeserializer)
        {
            this.requestSender = requestSender;
            this.responseDeserializer = responseDeserializer;
        }

        public async Task<TResponse> Get<TResponse>(string uri)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, uri))
            {
                var response = await requestSender.Send(request).ConfigureAwait(false);
                var deserialized = await responseDeserializer.Deserialize<TResponse>(response).ConfigureAwait(false);

                return deserialized;
            }
        }

        public async Task<TResponse> Post<TResponse, TBody>(string uri, TBody body)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Post, uri))
            {
                var serializedBody = JsonConvert.SerializeObject(body);
                request.Content = new StringContent(serializedBody, Encoding.UTF8, "application/json");

                var response = await requestSender.Send(request).ConfigureAwait(false);

                return await responseDeserializer.Deserialize<TResponse>(response).ConfigureAwait(false);
            }
        }

        public async Task Delete(string uri)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Delete, uri))
            {
                await requestSender.Send(request).ConfigureAwait(false);
            }
        }
    }
}
