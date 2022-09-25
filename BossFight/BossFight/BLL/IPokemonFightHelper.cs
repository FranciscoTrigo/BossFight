using System;
using BossFight.Attacks;
using BossFight.UI.Pokemon;

namespace BossFight.BLL
{
  public interface IPokemonFightHelper
  {
    public void AttackPokemon(IPokemon pokemon, IAttacks attack, IPokemon target);

    public int CalculateDamage(int damage, int modifier);

    public Boolean CanDodge(int targetSpeed, int attackerLevel);

    public void EnemyAttack(IPokemon enemy, IPokemon player);

    public void EnemyAttackSQL(IPokemon enemy, IPokemon player);

  }



}
