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
    public class CartItemClient
    {
        private static HttpClient httpClient = new HttpClient();

        public void AddCartItem(CartItem item)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(item));
            httpClient.PostAsync($"http://localhost:50200//api/cart-items/add", content).RunSynchronously();
        }

        public List<CartItem> GetItems(int cartId)
        {
            var response = httpClient.GetAsync($"http://localhost:50200//api/cart-items/getitems/{cartId}").Result;
            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<CartItem>>(json);
        }
    }
}
