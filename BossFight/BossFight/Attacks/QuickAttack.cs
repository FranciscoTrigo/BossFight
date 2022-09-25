using BossFight.UI.Models;

namespace BossFight.Attacks
{
  public class QuickAttack : IAttacks
  {

    private const string Name = "Quick Attack";
    public AttackStats AttackStats { get; set; }



    public QuickAttack()
    {
      AttackStats = new AttackStats(Name, 3, 1);

    }

  }
}