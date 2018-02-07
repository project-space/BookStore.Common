using BookStore.Common.ApiClients.Design.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Common.ApiClients.Design.Abstractions.PurchaseServiceClient
{
    public interface ICartsClient
    {
        Task<Cart> GetCart();

    }
}
