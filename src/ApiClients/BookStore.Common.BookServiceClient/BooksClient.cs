using BookStore.Common.BookServiceClient.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

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
            HttpContent content = new StringContent(JsonConvert.SerializeObject(ids), Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync($"http://localhost:55328/api/books/byIds", content).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<Book>>(json);
        }

        public Book GetBook(string id)
        {
            var response = httpClient.GetAsync($"http://localhost:55328/api/books/{id}").Result;
            var json = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<Book>(json);
        }
      

    }
}
