using System;
using BossFight.Items;
using BossFight.UI.Pokemon;

namespace BossFight.BLL
{
  public interface IpokemonItemHelper
  {

    public void UseItem(IPokemon player, IItems item, IPokemon enemy);

  }
}
