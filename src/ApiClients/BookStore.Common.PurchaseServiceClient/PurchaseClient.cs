using BookStore.Common.ApiClients.Design.Abstractions.PurchaseServiceClient;
using BookStore.Common.ApiClients.Design.Models;
using BookStore.Common.PurchaseServiceClient.IClients_Refit_;
using Refit;
using SettingsManager;
using System.Threading.Tasks;
using static SettingsManager.SettingsManager;

namespace BookStore.Common.PurchaseServiceClient
{
    public class PurchaseClient : IPurchaseClient
    {
        private static readonly string baseUrl = Read(Settings.PurchaseServiceEndPoint);

        private readonly IPurchaseClientR purchaseClient = RestService.For<IPurchaseClientR>(baseUrl);

        public Task<int> CreatePurchase(Order order) => purchaseClient.CreatePurchase(order);
    }
}
