using BookStore.Common.ApiClients.Design.Abstractions.PurchaseServiceClient;
using BookStore.Common.ApiClients.Design.Models;
using BookStore.Common.HttpRequestExecutor.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
/*
namespace BookStore.Common.PurchaseServiceClient
{
    public class PurchaseClient : IPurchaseClient
    {
        
        private readonly IHttpExecutor httpExecutor;

        private String baseUrl = "http://localhost:50200/api";

        public PurchaseClient(IHttpExecutor httpExecutor)
        {
            this.httpExecutor = httpExecutor;
        }

        
        public async Task<int> CreatePurchase(Order order)
        {
            return await httpExecutor.Post<int, Order>($"http://localhost:50200/api/purchase/create", order);
        
        }

    }
}
*/