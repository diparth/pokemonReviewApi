using pokemonReviewApp.Models;

namespace pokemonReviewApp.Dto
{
  public class PokemonDto
  {
    public int Id { get; set;}
    public string Name { get; set; }
    public DateTime BirthDate { get; set; } = DateTime.UtcNow;
    public PokemonType Type { get; set; } = PokemonType.Normal;
  }
}
