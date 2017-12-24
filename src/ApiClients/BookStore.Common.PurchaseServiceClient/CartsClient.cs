using BookStore.Common.PurchaseServiceClient.Models;
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
        private static HttpClient httpClient = new HttpClient();

        public Cart GetCart()
        {
            var response = httpClient.GetAsync($"http://localhost:50200//api/cart").Result;
            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<Cart>(json);
        }
    }
}
