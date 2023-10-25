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
    
    public Pokemon GetPokemon(int id)
    {
      return this._context.Pokemon.Where(p => p.Id == id).FirstOrDefault();
    }
    
    public Pokemon GetPokemon(string name)
    {
      return this._context.Pokemon.Where(p => p.Name == name).FirstOrDefault();
    }
    
    public decimal GetPokemonRating(int pokeId)
    {
      var review = 0;
      var pokeReviews = this._context.Reviews.Where(r => r.Pokemon.Id == pokeId);
      
      if (pokeReviews.Count() <= 0) {
        return 0;
      }
      
      var ans = (decimal)pokeReviews.Sum(r => r.Rating) / pokeReviews.Count();
      
      if (ans > 0) {
        Console.WriteLine(ans);
      }
      
      return ans;
    }
    
    public bool PokemonExists(int pokeId)
    {
      return this._context.Pokemon.Any(p => p.Id == pokeId);
    }
  }
}