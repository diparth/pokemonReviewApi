using pokemonReviewApp.Data;
using pokemonReviewApp.Interfaces;
using pokemonReviewApp.Models;

namespace pokemonReviewApp.Repository
{
  public class PokemonRepository : IPokemonRepository
  {
    private readonly DataContext _context;
    
    public PokemonRepository(DataContext context)
    {
      this._context = context;
    }
    
    public ICollection<Pokemon> GetPokemons()
    {
      return this._context.Pokemon.OrderBy(p => p.Id).ToList();
    }
  }
}