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
    public interface ICartsClientR : ICartsClient
    {
        [Get("/api/cart")]
        new Task<Cart> GetCart();
    }
}
