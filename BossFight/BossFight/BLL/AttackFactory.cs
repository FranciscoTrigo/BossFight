using System;
using System.Linq;
using BossFight.Attacks;
using BossFight.UI.Models;


namespace BossFight.BLL
{
  public class AttackFactory : IAttackFactory
  {
    public IAttacks CreateAttacks(AttackType.Type attackType)
    {
      if (attackType == AttackType.Type.Stab)
      {
        return new Stab();
      }

      if (attackType == AttackType.Type.Bite)
      {
        return new Bite();
      }

      if (attackType == AttackType.Type.Kick)
      {
        return new Kick();
      }

      if (attackType == AttackType.Type.Punch)
      {
        return new Punch();
      }

      if (attackType == AttackType.Type.Roll)
      {
        return new Roll();
      }

      if (attackType == AttackType.Type.ElectroBall)
      {
        return new ElectroBall();
      }

      if (attackType == AttackType.Type.QuickAttack)
      {
        return new QuickAttack();
      }

      if (attackType == AttackType.Type.Spark)
      {
        return new Spark();
      }

      if (attackType == AttackType.Type.Tackle)
      {
        return new Tackle();
      }

      if (attackType == AttackType.Type.Thunder)
      {
        return new Thunder();
      }

      throw new Exception();

    }

    public IAttacks GetRandomAttack()
    {
      var random = new Random();
      var allAttackIds = Enum.GetValues(typeof(AttackType.Type)).Cast<int>().ToList();
      var randomlyPickedAttackId = random.Next(0, allAttackIds.Count);

      var attackType = (AttackType.Type)randomlyPickedAttackId;
      var pickedAttack = CreateAttacks(attackType);
      return pickedAttack;
    }

    public IAttacks SpecificGetRandomAttack(int startAttack, int endAttack)
    {
      var random = new Random();
      var randomlyPickedAttackId = random.Next(startAttack, endAttack);

      var attackType = (AttackType.Type)randomlyPickedAttackId;
      var pickedAttack = CreateAttacks(attackType);
      return pickedAttack;
    }


  }
}
