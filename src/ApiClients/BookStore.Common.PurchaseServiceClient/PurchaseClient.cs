using BookStore.Common.ApiClients.Design.Models;
using BookStore.Common.HttpRequestExecutor.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Common.PurchaseServiceClient
{
    public class PurchaseClient
    {

        private readonly IHttpExecutor httpExecutor;

        public PurchaseClient(IHttpExecutor httpExecutor)
        {
            this.httpExecutor = httpExecutor;
        }

        public async Task<int> CreatePurchase(Order order)
        {
            return await httpExecutor.Post<int, Order>($"http://localhost:50200/api/purchase/create", order);
            /*
            HttpContent content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json");
            httpClient.PostAsync($"http://localhost:50200/api/purchase/create", content).Wait();
            */
        }

    }
}
