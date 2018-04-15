using BookStore.Common.ApiClients.Design.Abstractions.PurchaseServiceClient;
using BookStore.Common.ApiClients.Design.Models;
using BookStore.Common.PurchaseServiceClient.IClients_Refit_;
using Refit;
using SettingsManager;
using System.Threading.Tasks;
using static SettingsManager.SettingsManager;

namespace BookStore.Common.PurchaseServiceClient
{
    public class CartsClient : ICartsClient
    {
        private static readonly string baseUrl = Read(Settings.PurchaseServiceEndPoint);

        private readonly ICartsClientR cartsClient = RestService.For<ICartsClientR>(baseUrl);

        public Task<Cart> GetCart() => cartsClient.GetCart();
    }
}
