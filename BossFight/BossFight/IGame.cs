using System;
using BossFight.BLL;
using BossFight.UI.Pokemon;

namespace BossFight
{
  public interface IGame
  {
    public void StartGame();
    public Func<IPokemonFactory, IPokemon> getRandomPOkemon { get; set; }

  }
}
