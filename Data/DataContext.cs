using Microsoft.EntityFrameworkCore;
using pokemonReviewApp.Models;

namespace pokemonReviewApp.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Pokemon> Pokemon { get; set; }
    public DbSet<PokemonOwner> PokemonOwners { get; set; }
    public DbSet<PokemonCategory> PokemonCategories { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Reviewer> Reviewers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<PokemonCategory>()
        .HasKey(pokemonCategory => new { pokemonCategory.PokemonId, pokemonCategory.CategoryId });
      modelBuilder.Entity<PokemonCategory>()
        .HasOne(pokemon => pokemon.Pokemon)
        .WithMany(category => category.PokemonCategories)
        .HasForeignKey(pc => pc.PokemonId);
      modelBuilder.Entity<PokemonCategory>()
        .HasOne(category => category.Category)
        .WithMany(pokemon => pokemon.PokemonCategories)
        .HasForeignKey(pc => pc.CategoryId);
        
      modelBuilder.Entity<PokemonOwner>()
        .HasKey(pokemonOwner => new { pokemonOwner.PokemonId, pokemonOwner.OwnerId });
      modelBuilder.Entity<PokemonOwner>()
        .HasOne(pokemon => pokemon.Pokemon)
        .WithMany(owner => owner.PokemonOwners)
        .HasForeignKey(po => po.PokemonId);
      modelBuilder.Entity<PokemonOwner>()
        .HasOne(owner => owner.Owner)
        .WithMany(pokemon => pokemon.PokemonOwners)
        .HasForeignKey(po => po.OwnerId);
    }
  }
}