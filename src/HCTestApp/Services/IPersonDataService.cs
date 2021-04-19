using HCTestApp.Models;
using System;
using System.Collections.Generic;

namespace HCTestApp.Services
{
    public interface IPersonDataService
    {
        IEnumerable<PersonModel> GetPeople();
    }
    public class PersonDataService : IPersonDataService
    {
        public IEnumerable<PersonModel> GetPeople()
        {
            return new List<PersonModel>()
            {
                new PersonModel() { FirstName = "John", LastName = "Smith", BirthDate = DateTime.Today }
            };
        }
    }
}