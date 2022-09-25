using BossFight.UI.Models;

namespace BossFight.Attacks
{
  public class Kick : IAttacks
  {

    private const string Name = "Kick";
    public AttackStats AttackStats { get; set; }



    public Kick()
    {
      AttackStats = new AttackStats(Name, 5, 5);

    }

  }
}