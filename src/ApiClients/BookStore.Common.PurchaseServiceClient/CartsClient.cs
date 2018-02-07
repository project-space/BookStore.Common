using BookStore.Common.ApiClients.Design.Models;
using BookStore.Common.HttpRequestExecutor.Design;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Common.PurchaseServiceClient
{
    public class CartsClient
    {

        private readonly IHttpExecutor httpExecutor;

        public CartsClient(IHttpExecutor httpExecutor)
        {
            this.httpExecutor = httpExecutor;
        }

        public async Task<Cart> GetCart()
        {

            return await httpExecutor.Get<Cart>($"http://localhost:50200//api/cart");
            
            /*
            var response = httpClient.GetAsync($"http://localhost:50200//api/cart").Result;
            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<Cart>(json);
            */
        }
    }
}
