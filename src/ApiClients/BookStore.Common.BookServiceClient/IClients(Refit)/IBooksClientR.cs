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
    public interface IBooksClientR : IBooksClient
    {
        [Get("/api/books/popular")]
        new Task<List<Book>> GetPopular();

        [Get("/api/books/novelties")]
        new Task<List<Book>> GetNovelties();

        [Get("/api/books/withGenre/{id}")]
        new Task<List<Book>> GetWithGenre(int id);

        [Post("/api/books/byIds")]
        new Task<List<Book>> GetBooks([Body] List<int> ids);

        [Get("/api/books/{id}")]
        new Task<Book> GetBook(int id);
    }
}
