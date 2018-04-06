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
    public class ResponseDeserializer : IResponseDeserializer
    {
        public async Task<T> Deserialize<T>(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<T>(content);
        }

    }
}
