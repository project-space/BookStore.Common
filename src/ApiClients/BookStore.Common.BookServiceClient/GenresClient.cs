using BookStore.Common.BookServiceClient.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace BookStore.Common.BookServiceClient
{
    public class GenresClient
    {
        private static HttpClient httpClient = new HttpClient();

        public Genre GetGenre(string action)
        {
            var response = httpClient.GetAsync($"http://localhost:55328/api/genres/{action}").Result;
            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<Genre>(json);
        }

        public List<Genre> GetGenres()
        {
            var response = httpClient.GetAsync($"http://localhost:55328/api/genres/genres").Result;
            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<Genre>>(json);
        }
    }
}
