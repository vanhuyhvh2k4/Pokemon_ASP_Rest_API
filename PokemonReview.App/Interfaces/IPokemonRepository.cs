using PokemonReview.App.Models;

namespace PokemonReview.App.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}
