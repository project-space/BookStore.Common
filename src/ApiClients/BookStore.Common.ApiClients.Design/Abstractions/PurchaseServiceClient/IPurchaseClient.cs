using BookStore.Common.ApiClients.Design.Models;
using System.Threading.Tasks;
using Refit;

namespace BookStore.Common.ApiClients.Design.Abstractions.PurchaseServiceClient
{
    public interface IPurchaseClient
    {
        [Post("/purchase/create")]
        Task<int> CreatePurchase([Body] Order order);
    }
}
