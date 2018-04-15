using BookStore.Common.ApiClients.Design.Abstractions.BookServiceClient;
using BookStore.Common.ApiClients.Design.Models;
using BookStore.Common.BookServiceClient.IClients_Refit_;
using Refit;
using SettingsManager;
using System.Collections.Generic;
using System.Threading.Tasks;
using static SettingsManager.SettingsManager;

namespace BookStore.Common.BookServiceClient
{
    public class GenresClient : IGenresClient
    {
        private static readonly string baseUrl = Read(Settings.BookServiceEndPoint);

        private readonly IGenresClientR genresClient = RestService.For<IGenresClientR>(baseUrl);

        public Task<Genre> GetGenre(int id) => genresClient.GetGenre(id);

        public Task<List<Genre>> GetGenres() => genresClient.GetGenres();
    }
}
