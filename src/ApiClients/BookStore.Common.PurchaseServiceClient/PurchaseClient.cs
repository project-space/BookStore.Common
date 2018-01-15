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
    public class PurchaseClient
    {
        private static HttpClient httpClient = new HttpClient();

        public void CreatePurchase(Order order)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json");
            httpClient.PostAsync($"http://localhost:50200/api/purchase/create", content).Wait();
        }

    }
}
