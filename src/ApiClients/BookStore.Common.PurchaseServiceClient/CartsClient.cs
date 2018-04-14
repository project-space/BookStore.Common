using BookStore.Common.ApiClients.Design.Abstractions.PurchaseServiceClient;
using BookStore.Common.ApiClients.Design.Models;
using System.Threading.Tasks;
using Refit;
using BookStore.Common.PurchaseServiceClient.IClients_Refit_;

namespace BookStore.Common.PurchaseServiceClient
{
    public class CartsClient : ICartsClient
    {
        private readonly ICartsClientR cartsClient = RestService.For<ICartsClientR>("http://localhost:50200/");

        public async Task<Cart> GetCart() => await cartsClient.GetCart().ConfigureAwait(false);
    }
}
