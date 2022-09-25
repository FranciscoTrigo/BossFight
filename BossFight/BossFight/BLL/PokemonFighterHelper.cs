using BossFight.Attacks;
using BossFight.UI.Pokemon;
using System;
using BossFight.UI.Helpers;
using BossFight.UI.Models;

namespace BossFight.BLL
{
  public class PokemonFighterHelper : IPokemonFightHelper
  {


    private readonly PokemonAttacks pokemonAttacks;
    private readonly IPokemonDrawHelper drawHelper;

    public PokemonFighterHelper(IPokemonDrawHelper drawHelper)
    {
      this.drawHelper = drawHelper;
      this.pokemonAttacks = pokemonAttacks;
    }

    public void AttackPokemon(IPokemon pokemon, IAttacks attack, IPokemon target)
    {

      var battleMesage = String.Empty;
      // Make values for damage and dodge
      int attackDamage = CalculateDamage(attack.AttackStats.Damage, attack.AttackStats.Modifier);
      Boolean canDodge = CanDodge(target.PokemonStats.Speed, pokemon.PokemonStats.Level);
      battleMesage += $"{pokemon.PokemonStats.Name} attacks {target.PokemonStats.Name} with {attack.AttackStats.Name}!\n";
      
      // See if can dodge
      if (canDodge == true)
      {
        battleMesage += $"{target.PokemonStats.Name} was able do dodge!\n                       ";
      }
      else
      {
        battleMesage += $"{target.PokemonStats.Name} received {attackDamage} of damage!!!\n";
        target.SubtractHealth(attackDamage);
        battleMesage += $"{target.PokemonStats.Name} HP is now {target.PokemonStats.CurrentHp}.";
      }
      drawHelper.ShowNotification(battleMesage);
    }


    public int CalculateDamage(int damage, int modifier)
    {
      Random rnd = new Random();
      int attackDamage = 0;
      attackDamage = damage + (rnd.Next(1, modifier));
      return attackDamage;
    }

    public bool CanDodge(int targetSpeed, int attackerLevel)
    {
      bool Dodge;
      Random rnd = new Random();
      int dodge = rnd.Next(targetSpeed);
      if ((dodge + attackerLevel+35) % 7 == 0)
      {
        Dodge = true;
      }
      else
      {
        Dodge = false;
      }

      return Dodge;
    }

    public void EnemyAttack(IPokemon enemy, IPokemon player)
    {
      // Select an attack at random from maybe a list in the pokemon stats
      // and pass it to AttackPokemon()



      AttackPokemon(enemy, enemy.GetNextAttack(), player);
    }

    public void EnemyAttackSQL(IPokemon enemy, IPokemon player)
    {

    }




  }



}
