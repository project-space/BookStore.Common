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
    public interface IPurchaseClientR : IPurchaseClient
    {
        [Post("/api/purchase/create")]
        new Task<int> CreatePurchase([Body] Order order);
    }
}
