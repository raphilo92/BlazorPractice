﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial class ApiBroker
    {
        private const string _personUrl = "/api/person";

        public async ValueTask<IEnumerable<Person>> GetAllPersonAsync() =>
            await GetAllAsync<Person>(_personUrl);

        public async ValueTask<Person> GetPersonByIdAsync(int id) =>
            await GetAsync<Person>(_personUrl + $"/{id}");

        public async ValueTask<IEnumerable<Person>> GetAllPeopleByName(string searchText) =>
            await GetAllFilteredAsync<Person>(_personUrl + $"/search/{searchText}");

        public async ValueTask<Person> PostPersonAsync(Person person) =>
            await PostAsync(_personUrl, person);

        public async ValueTask<Person> PutPersonAsync(Person person, int id) =>
            await PutAsync(_personUrl + $"/{id}", person);

        public async ValueTask<Person> DeletePersonAsync(int id) =>
            await DeleteAsync<Person>(_personUrl + $"/{id}");
    }
}