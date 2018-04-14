using BookStore.Common.ApiClients.Design.Abstractions.PurchaseServiceClient;
using BookStore.Common.ApiClients.Design.Models;
using BookStore.Common.PurchaseServiceClient.IClients_Refit_;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace BookStore.Common.PurchaseServiceClient
{
    public class CartItemClient : ICartItemClient
    {
        private readonly ICartItemClientR cartItemClient = RestService.For<ICartItemClientR>("http://localhost:50200/");

        public async Task<int> AddCartItem(CartItem item) => await cartItemClient.AddCartItem(item).ConfigureAwait(false);

        public async Task DeleteCartItem(int id) => await cartItemClient.DeleteCartItem(id).ConfigureAwait(false);

        public async Task<List<CartItem>> GetItems(int cartId) => await cartItemClient.GetItems(cartId).ConfigureAwait(false);
    }
}
