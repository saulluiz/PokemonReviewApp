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
    }
}