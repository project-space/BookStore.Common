using BookStore.Common.ApiClients.Design.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Common.ApiClients.Design.Abstractions.BookServiceClient
{
    public interface IGenresClient
    {
        Task<Genre> GetGenre(int id);
        Task<List<Genre>> GetGenres();
    }
}
