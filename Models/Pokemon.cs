using pokemonReviewApp.Utils;

namespace pokemonReviewApp.Models {
  public class Pokemon {
    public int Id { get; set;}
    public string Name { get; set; }
    public DateTime BirthDate { get; set; } = DateTime.UtcNow;
    public PokemonType Type { get; set; } = PokemonType.Normal;
    
    public ICollection<Review> Reviews { get; set; }
    public ICollection<PokemonOwner> PokemonOwners { get; set; }
    public ICollection<PokemonCategory> PokemonCategories { get; set; }
    
    public void Display() {
      Console.WriteLine(Type);
      Console.WriteLine(Name.DisplayCount());
    }
  }
}
