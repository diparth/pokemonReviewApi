using pokemonReviewApp.Data;
using pokemonReviewApp.Models;

namespace pokemonReviewApp
{
	public class Seed
	{
		private readonly DataContext dataContext;

		public Seed(DataContext context)
		{
			this.dataContext = context;
		}

		public void SeeDataContext()
		{
			if (!dataContext.PokemonOwners.Any())
			{
				var pokemonOwners = new List<PokemonOwner>()
				{
					new PokemonOwner()
					{
						Pokemon = new Pokemon()
						{
							Name = "Pikachu",
							BirthDate = new DateTime(1993, 09, 30),
							PokemonCategories = new List<PokemonCategory>()
							{
								new PokemonCategory { Category = new Category() { Name = "Electric" } }
							},
							Type = PokemonType.Electric,
							Reviews = new List<Review>()
							{
								new Review()
								{
									Title = "Pikachu",
									Text = "Pickahu is the best pokemon, because it is electric",
									Rating = 5,
									Reviewer = new Reviewer()
									{
										FirstName = "Bruce",
										LastName = "Wayne"
									}
								}
							}
						},
						Owner = new Owner()
						{
							FirstName = "Ash",
							LastName = "Ketchum",
							Gym = "Tokyo",
							Country = new Country() { Name = "Japan" }
						}
					},
					new PokemonOwner()
					{
						Pokemon = new Pokemon()
						{
							Name = "Squirtle",
							BirthDate = new DateTime(1994, 7, 19),
							PokemonCategories = new List<PokemonCategory>()
							{
								new PokemonCategory { Category = new Category() { Name = "Water" } }
							},
							Type = PokemonType.Water,
							Reviews = new List<Review>()
							{
								new Review
								{
									Title = "Squirtle",
									Text = "squirtle is the best pokemon, because it is electric",
									Rating = 5,
									Reviewer = new Reviewer()
									{
										FirstName = "Teddy",
										LastName = "Smith"
									}
								}
							}
						},
						Owner = new Owner()
						{
							FirstName = "Harry",
							LastName = "Potter",
							Gym = "Mistys Gym",
							Country = new Country() { Name = "Saffron City" }
						}
					}
				};
				
				dataContext.PokemonOwners.AddRange(pokemonOwners);
				dataContext.SaveChanges();
			}
		}
	}
}
