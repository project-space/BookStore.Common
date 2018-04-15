using BookStore.Common.ApiClients.Design.Abstractions.PurchaseServiceClient;
using BookStore.Common.ApiClients.Design.Models;
using BookStore.Common.PurchaseServiceClient.IClients_Refit_;
using Refit;
using SettingsManager;
using System.Collections.Generic;
using System.Threading.Tasks;
using static SettingsManager.SettingsManager;

namespace BookStore.Common.PurchaseServiceClient
{
    public class CartItemClient : ICartItemClient
    {
        private static readonly string baseUrl = Read(Settings.PurchaseServiceEndPoint);

        private readonly ICartItemClientR cartItemClient = RestService.For<ICartItemClientR>(baseUrl);

        public Task<int> AddCartItem(CartItem item) => cartItemClient.AddCartItem(item);

        public Task DeleteCartItem(int id) => cartItemClient.DeleteCartItem(id);

        public Task<List<CartItem>> GetItems(int cartId) => cartItemClient.GetItems(cartId);
    }
}
