using BookStore.Common.ApiClients.Design.Abstractions.BookServiceClient;
using BookStore.Common.ApiClients.Design.Models;
using BookStore.Common.HttpRequestExecutor.Design;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BookStore.Common.BookServiceClient
{
    public class GenresClient : IGenresClient
    {
        private readonly IHttpExecutor httpExecutor;

        public GenresClient(IHttpExecutor httpExecutor)
        {
            this.httpExecutor = httpExecutor;
        }

        public async Task<Genre> GetGenre(int id)
        {
            return await httpExecutor.Get<Genre>($"http://localhost:55328/api/genres/genres/{id}").ConfigureAwait(false);
          
        }

        public async Task<List<Genre>> GetGenres()
        {
            return await httpExecutor.Get<List<Genre>>($"http://localhost:55328/api/genres/genres").ConfigureAwait(false);
           
        }
    }
}
