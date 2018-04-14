using BookStore.Common.ApiClients.Design.Abstractions.PurchaseServiceClient;
using BookStore.Common.ApiClients.Design.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace BookStore.Common.PurchaseServiceClient.IClients_Refit_
{
    public interface ICartItemClientR : ICartItemClient
    {
        [Post("/api/cart-items/add")]
        new Task<int> AddCartItem([Body] CartItem item);

        [Delete("/api/cart-items/delete/{id}")]
        new Task DeleteCartItem(int id);

        [Get("/api/cart-items/getitems/{cartId}")]
        new Task<List<CartItem>> GetItems(int cartId);
    }
}
