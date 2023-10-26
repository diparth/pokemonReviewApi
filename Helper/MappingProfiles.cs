using AutoMapper;
using pokemonReviewApp.Dto;
using pokemonReviewApp.Models;

namespace pokemonReviewApp.Helper
{
  public class MappingProfiles: Profile
  {
    public MappingProfiles()
    {
      CreateMap<Pokemon, PokemonDto>();
    }
  } 
}
