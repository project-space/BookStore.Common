using BookStore.Common.BookServiceClient.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace BookStore.Common.BookServiceClient
{
    public class BooksClient
    {
        private static HttpClient httpClient = new HttpClient();

        public List<Book> GetBooks(string action)
        {
            var response = httpClient.GetAsync($"http://localhost:55328/api/books/{action}").Result;
            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<Book>>(json);
        }

        public List<Book> GetBooks(List<int> ids)
        {
            
        }

        public Book GetBook(string id)
        {
            var response = httpClient.GetAsync($"http://localhost:55328/api/books/{id}").Result;
            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<Book>(json);
        }
      

    }
}
