using Microsoft.AspNetCore.Mvc;
using pokemonReviewApp.Interfaces;
using pokemonReviewApp.Models;

namespace pokemonReviewApp.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PokemonController : Controller
  {
    private readonly IPokemonRepository _pokemonRepository;
    
    public PokemonController(IPokemonRepository pokemonRepository)
    {
      this._pokemonRepository = pokemonRepository;
    }
    
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
    public IActionResult GetPokemons()
    {
      var pokemons = this._pokemonRepository.GetPokemons();
      
      if(!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }
      
      return Ok(pokemons);
    }
  }
}
