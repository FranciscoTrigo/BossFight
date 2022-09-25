using BossFight.Attacks;
using BossFight.UI.Pokemon;
using System;
using BossFight.UI.Helpers;
using BossFight.UI.Models;
using BossFight.Items;

namespace BossFight.BLL
{
  class PokemonItemHelper : IpokemonItemHelper
  { 

    private readonly IPokemonDrawHelper drawHelper;
    private readonly ItemEffects itemAttacks;

  
   public PokemonItemHelper(IPokemonDrawHelper drawHelper)
    {
      this.drawHelper = drawHelper;
      this.itemAttacks = itemAttacks;
    }
    
    
    
    
    public void UseItem(IPokemon player, IItems item, IPokemon enemy)
    {
      if (item.ItemEffects.Damage > 0)
      {
        enemy.SubtractHealth(item.ItemEffects.Damage);
        drawHelper.ShowNotification($"You used a {item.ItemEffects.Name}! {enemy.PokemonStats.Name} received {item.ItemEffects.Damage}\n points of damage!");
      }
      else
      {
        player.SubtractHealth((item.ItemEffects.Heal * -1));
        drawHelper.ShowNotification($"You used a {item.ItemEffects.Name}! {player.PokemonStats.Name} received {item.ItemEffects.Heal}\n points of healing!");
      }
    }
  }
}
