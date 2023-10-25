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
    
    [HttpGet("{pokeId}")]
    [ProducesResponseType(200, Type = typeof(Pokemon))]
    [ProducesResponseType(400)]
    public IActionResult GetPokemon(int pokeId)
    {
      if (!this._pokemonRepository.PokemonExists(pokeId))
      {
        return NotFound();
      }
      
      var pokemon = this._pokemonRepository.GetPokemon(pokeId);
      
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }
      
      return Ok(pokemon);
    }
    
    [HttpGet("{pokeId}/rating")]
    [ProducesResponseType(200, Type = typeof(decimal))]
    [ProducesResponseType(400)]
    public IActionResult GetPokemonRating(int pokeId)
    {
      if (!this._pokemonRepository.PokemonExists(pokeId))
      {
        return NotFound();
      }
      
      var rating = this._pokemonRepository.GetPokemonRating(pokeId);
      
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }
      
      return Ok(rating);
    }
  }
}
