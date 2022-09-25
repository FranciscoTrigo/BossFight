using BossFight.UI.Models;

namespace BossFight.Attacks
{
  public class Bite : IAttacks
  {

    private const string Name = "Bite";
    public AttackStats AttackStats { get; set; }



    public Bite()
    {
      AttackStats = new AttackStats(Name, 2, 1);

    }

  }
}