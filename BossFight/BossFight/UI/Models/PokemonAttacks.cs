using System;
using BossFight.Attacks;
using BossFight.BLL;

namespace BossFight.UI.Models
{
  public class PokemonAttacks
  {

    private readonly IAttackFactory attackFactory;


    public PokemonAttacks(IAttackFactory attackFactory)
    {
      this.attackFactory = attackFactory;
    }

    public IAttacks SelectAttack()
    {


      var sparkAttack = attackFactory.CreateAttacks(AttackType.Type.Spark);
      var electroBallkAttack = attackFactory.CreateAttacks(AttackType.Type.ElectroBall);
      var tacklekAttack = attackFactory.CreateAttacks(AttackType.Type.Tackle);
      var thunderAttack = attackFactory.CreateAttacks(AttackType.Type.Thunder);
      var quickAttackAttack = attackFactory.CreateAttacks(AttackType.Type.QuickAttack);


      IAttacks[] pikachuAttacks = 
      {
        electroBallkAttack,
        quickAttackAttack, sparkAttack, tacklekAttack, thunderAttack
      };

      Random rnd = new Random();
      int attackNumber = rnd.Next(0, 4);


      return pikachuAttacks[attackNumber];


    }

  }
}
