﻿using BookStore.Common.ApiClients.Design.Abstractions.BookServiceClient;
using BookStore.Common.ApiClients.Design.Models;
using BookStore.Common.HttpRequestExecutor.Design;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Common.BookServiceClient
{
    public class BooksClient : IBooksClient
    {
        private readonly IHttpExecutor httpExecutor;

        public BooksClient(IHttpExecutor httpExecutor)
        {
            this.httpExecutor = httpExecutor;
        }

        public async Task<List<Book>> GetPopular()
        {
            return await httpExecutor.Get<List<Book>>($"http://localhost:55328/api/books/popular");
        }

        public async Task<List<Book>> GetNovelties()
        {
            return await httpExecutor.Get<List<Book>>($"http://localhost:55328/api/books/novelties");
        }

        public async Task<List<Book>> GetWithGenre(int id)
        {
            return await httpExecutor.Get<List<Book>>($"http://localhost:55328/api/books/withGenre/{id}");
        }

        public async Task<List<Book>> GetBooks(List<int> ids)
        {
            return await httpExecutor.Post<List<Book>,List<int>>($"http://localhost:55328/api/books/byIds", ids);
        }

        public async Task<Book> GetBook(int id)
        {
            return await httpExecutor.Get<Book>($"http://localhost:55328/api/books/{id}");
        }
      

    }
}
