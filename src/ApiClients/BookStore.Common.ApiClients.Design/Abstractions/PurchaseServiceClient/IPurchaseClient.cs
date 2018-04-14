using BookStore.Common.ApiClients.Design.Models;
using System.Threading.Tasks;

namespace BookStore.Common.ApiClients.Design.Abstractions.PurchaseServiceClient
{
    public interface IPurchaseClient
    {
        Task<int> CreatePurchase(Order order);
    }
}
