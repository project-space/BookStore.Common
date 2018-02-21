using BookStore.Common.ApiClients.Design.Abstractions.PurchaseServiceClient;
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
    public class CartsClient : ICartsClient
    {

        private readonly IHttpExecutor httpExecutor;

        public CartsClient(IHttpExecutor httpExecutor)
        {
            this.httpExecutor = httpExecutor;
        }

        public async Task<Cart> GetCart()
        {

            return await httpExecutor.Get<Cart>($"http://localhost:50200//api/cart").ConfigureAwait(false);
            
            /*
            var response = httpClient.GetAsync($"http://localhost:50200//api/cart").Result;
            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<Cart>(json);
            */
        }
    }
}
