using BookStore.Common.ApiClients.Design.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Common.ApiClients.Design.Abstractions.BookServiceClient
{
    public interface IBooksClient
    {
        Task<List<Book>> GetPopular();
        Task<List<Book>> GetNovelties();
        Task<List<Book>> GetBooks(List<int> ids);
        Task<Book> GetBook(int id);
    }
}
