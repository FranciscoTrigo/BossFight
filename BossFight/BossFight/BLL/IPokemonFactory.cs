using BossFight.UI.Models;
using BossFight.UI.Pokemon;

namespace BossFight.BLL
{
  public interface IPokemonFactory
  {

    

    public IPokemon CreatePokemon(int level, PokemonType.Type pokemonType);

    public IPokemon GetRandomPokemon();
  }
}
