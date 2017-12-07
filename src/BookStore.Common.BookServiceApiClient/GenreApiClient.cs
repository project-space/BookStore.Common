using BookStore.Common.BookServiceApiClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace BookStore.Common.BookServiceApiClient
{
    public class GenreApiClient
    {
        private static HttpClient httpClient = new HttpClient();

        public Genre GetGenre(string action)
        {
            
            var response = httpClient.GetAsync($"http://localhost:55328/api/genres/{action}").Result;
            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<Genre>(json);
        }
    }
}