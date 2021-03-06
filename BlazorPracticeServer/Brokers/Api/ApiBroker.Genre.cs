﻿using BlazorPracticeServer.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial class ApiBroker
    {
        private const string _genreUrl = "/api/genre";

        public async ValueTask<IEnumerable<Genre>> GetAllGenresAsync() =>
            await GetAllAsync<Genre>(_genreUrl);

        public async ValueTask<Genre> GetGenreById(int id) =>
            await GetAsync<Genre>(_genreUrl + $"/{id}");

        public async ValueTask<Genre> PostGenreAsync(Genre genre) =>
            await PostAsync(_genreUrl, genre);

        public async ValueTask<Genre> PutGenreAsync(Genre genre, int id) =>
            await PutAsync(_genreUrl + $"/{id}", genre);

        public async ValueTask<Genre> DeleteGenreAsync(int id) =>
            await DeleteAsync<Genre>(_genreUrl + $"/{id}");

    }
}
