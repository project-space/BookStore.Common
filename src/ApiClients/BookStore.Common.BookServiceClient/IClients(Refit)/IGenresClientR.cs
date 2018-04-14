using BookStore.Common.ApiClients.Design.Abstractions.BookServiceClient;
using BookStore.Common.ApiClients.Design.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace BookStore.Common.BookServiceClient.IClients_Refit_
{
    public interface IGenresClientR : IGenresClient
    {
        [Get("/genres/{id}")]
        new Task<Genre> GetGenre(int id);

        [Get("/genres/genres/")]
        new Task<List<Genre>> GetGenres();
    }
}
