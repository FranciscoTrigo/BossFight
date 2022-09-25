using BossFight.Attacks;
using BossFight.UI.Models;

namespace BossFight.BLL
{
  public interface IAttackFactory
  {

    public IAttacks CreateAttacks(AttackType.Type attackType);

    public IAttacks GetRandomAttack();

    public IAttacks SpecificGetRandomAttack(int startAttack, int endAttack);
  }
}
