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
    public class CartItemClient
    {
        private readonly IHttpExecutor httpExecutor;

        public CartItemClient(IHttpExecutor httpExecutor)
        {
            this.httpExecutor = httpExecutor;
        }


        public async Task<int> AddCartItem(CartItem item)
        {
            return await httpExecutor.Post<int,CartItem>($"http://localhost:50200/api/cart-items/add", item);
            /**
            HttpContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
            httpClient.PostAsync($"http://localhost:50200/api/cart-items/add", content).Wait();
            **/
        }

        public async void DeleteCartItem(int id)
        {
            await httpExecutor.Delete($"http://localhost:50200/api/cart-items/delete/{id}");

            /**
            httpClient.DeleteAsync($"http://localhost:50200/api/cart-items/delete/{id}").Wait();
            **/
        }


        public async Task<List<CartItem>> GetItems(int cartId)
        {
            return await httpExecutor.Get<List<CartItem>>($"http://localhost:50200//api/cart-items/getitems/{cartId}");

            /**
            var response = httpClient.GetAsync($"http://localhost:50200//api/cart-items/getitems/{cartId}").Result;
            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<CartItem>>(json);
             **/
        }
    }
}
