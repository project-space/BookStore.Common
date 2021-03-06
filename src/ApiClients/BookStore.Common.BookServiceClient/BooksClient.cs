﻿using BookStore.Common.ApiClients.Design.Abstractions.BookServiceClient;
using BookStore.Common.ApiClients.Design.Models;
using BookStore.Common.BookServiceClient.IClients_Refit_;
using System.Collections.Generic;
using SettingsManager;
using System.Threading.Tasks;
using Refit;
using static SettingsManager.SettingsManager;


namespace BookStore.Common.BookServiceClient
{
    public class BooksClient : IBooksClient
    {
        private static readonly string baseUrl = Read(Settings.BookServiceEndPoint);

        private readonly IBooksClientR booksClient = RestService.For<IBooksClientR>(baseUrl);

        public async Task<List<Book>> GetPopular() => await booksClient.GetPopular().ConfigureAwait(false);
        
        public async Task<List<Book>> GetNovelties() => await booksClient.GetNovelties().ConfigureAwait(false);
         
        public async Task<List<Book>> GetWithGenre(int id) => await booksClient.GetWithGenre(id).ConfigureAwait(false);
        
        public async Task<List<Book>> GetBooks(List<int> ids) => await booksClient.GetBooks(ids).ConfigureAwait(false);
        
        public async Task<Book> GetBook(int id) => await booksClient.GetBook(id).ConfigureAwait(false);
    }
}
