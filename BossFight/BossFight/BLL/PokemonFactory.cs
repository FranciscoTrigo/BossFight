using BossFight.Pokemon;
using BossFight.UI.Models;
using BossFight.UI.Pokemon;
using System;
using System.Linq;

namespace BossFight.BLL
{
  public class PokemonFactory : IPokemonFactory
  {
    private readonly IAttackFactory _attackFactory;

    public PokemonFactory(IAttackFactory attackFactory)
    {
      _attackFactory = attackFactory;
    }



    public IPokemon CreatePokemon(int level, PokemonType.Type pokemonType)
    {
      if (pokemonType == PokemonType.Type.Ditto)
      {
        return new Ditto(level, _attackFactory);
      }
      if (pokemonType == PokemonType.Type.Pikachu)
      {
        return new Pikachu(level, _attackFactory);
      }
      if (pokemonType == PokemonType.Type.Francisco)
      {
        return new Francisco(level, _attackFactory);
      }
      if (pokemonType == PokemonType.Type.Bulbasaur)
      {
        return new Bulbasaur(level, _attackFactory);
      }
      if (pokemonType == PokemonType.Type.Eevee)
      {
        return new Eevee(level, _attackFactory);
      }

      throw new Exception();

    }

    public IPokemon GetRandomPokemon()
    {
      var random = new Random();
      var allPokemonIds = Enum.GetValues(typeof(PokemonType.Type)).Cast<int>().ToList();
      var randomlyPickedPokemonId = random.Next(0, allPokemonIds.Count);

      var pokemonType = (PokemonType.Type)randomlyPickedPokemonId;
      var pickedPokemon = CreatePokemon(2, pokemonType);
      return pickedPokemon;
    }

  }
}
