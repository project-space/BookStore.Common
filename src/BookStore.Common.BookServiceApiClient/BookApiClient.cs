using BookStore.Common.BookServiceApiClient.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;



namespace BookStore.Common.BookServiceApiClient
{
    public class BookApiClient 
    {
        private static HttpClient httpClient = new HttpClient();

        private List<Book> GetBooks(string action)
        {
            var response = httpClient.GetAsync($"http://localhost:55328/api/books/{action}").Result;
            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<Book>>(json);
        }
    }
}