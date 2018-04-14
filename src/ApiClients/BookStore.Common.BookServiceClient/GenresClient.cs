using BookStore.Common.ApiClients.Design.Abstractions.BookServiceClient;
using BookStore.Common.ApiClients.Design.Models;
using BookStore.Common.BookServiceClient.IClients_Refit_;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace BookStore.Common.BookServiceClient
{
    public class GenresClient : IGenresClient
    {
        private readonly IGenresClientR genresClient = RestService.For<IGenresClientR>("http://localhost:55328/");

        public async Task<Genre> GetGenre(int id) => await genresClient.GetGenre(id).ConfigureAwait(false);

        public async Task<List<Genre>> GetGenres() => await genresClient.GetGenres().ConfigureAwait(false);
    }
}
