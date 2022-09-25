using BossFight.UI.Models;

namespace BossFight.Attacks
{
  public class Punch : IAttacks
  {

    private const string Name = "Punch";
    public AttackStats AttackStats { get; set; }



    public Punch()
    {
      AttackStats = new AttackStats(Name, 2, 2);

    }

  }
}