using PokemonReview.App.Models;

namespace PokemonReview.App.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();

        Country GetCountry(int id);

        Country GetCountryByOwner(int ownerId);

        ICollection<Owner> GetOwnersFromACountry(int countryId);

        bool CountryExists(int countryId);
    }
}
