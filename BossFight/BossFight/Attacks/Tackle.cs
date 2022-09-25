using BossFight.UI.Models;

namespace BossFight.Attacks
{
  public class Tackle : IAttacks
  {

    private const string Name = "Tackle";
    public AttackStats AttackStats { get; set; }



    public Tackle()
    {
      AttackStats = new AttackStats(Name, 2, 2);

    }

  }
}