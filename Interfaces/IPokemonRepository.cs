using pokemonReviewApp.Models;

namespace pokemonReviewApp.Interfaces
{
  public interface IPokemonRepository
  {
    ICollection<Pokemon> GetPokemons(); 
  }
}