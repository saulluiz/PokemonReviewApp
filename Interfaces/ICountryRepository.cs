﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
      
        Country GetCountry(int id);
        Country GetCountryByOwnerId(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);
        bool CountryExist(int id);
        bool CreateCountry(Country country);
        bool Save();
        bool UpdateCountry(Country country);
        bool DeleteCountry(Country country);
    }
}
