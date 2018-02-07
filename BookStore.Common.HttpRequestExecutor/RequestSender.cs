using BookStore.Common.HttpRequestExecutor.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Common.HttpRequestExecutor
{
    public class RequestSender : IRequestSender
    {
        private readonly HttpClient httpClient = new HttpClient();

        public async Task<HttpResponseMessage> Send(HttpRequestMessage request)
        {
            var response = await httpClient.SendAsync(request);
            return response;
        }
    }
}
