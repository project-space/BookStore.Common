using BookStore.Common.ApiClients.Design.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Common.ApiClients.Design.Abstractions.PurchaseServiceClient
{ 
    public interface ICartItemClient
    {
        Task<int> AddCartItem(CartItem item);
        void DeleteCartItem(int id);
        Task<List<CartItem>> GetItems(int cartId);
    }
}
