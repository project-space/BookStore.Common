using BookStore.Common.ApiClients.Design.Abstractions.PurchaseServiceClient;
using BookStore.Common.ApiClients.Design.Models;
using System.Threading.Tasks;
using Refit;
using BookStore.Common.PurchaseServiceClient.IClients_Refit_;

namespace BookStore.Common.PurchaseServiceClient
{
    public class PurchaseClient : IPurchaseClient
    {
        private readonly IPurchaseClientR purchaseClient = RestService.For<IPurchaseClientR>("http://localhost:50200/");

        public async Task<int> CreatePurchase(Order order) => await purchaseClient.CreatePurchase(order).ConfigureAwait(false);
    }
}
