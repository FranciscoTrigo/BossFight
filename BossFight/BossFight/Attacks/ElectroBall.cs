using BossFight.UI.Models;

namespace BossFight.Attacks
{
  public class ElectroBall : IAttacks
  {

    private const string Name = "Punch";
    public AttackStats AttackStats { get; set; }



    public ElectroBall()
    {
      AttackStats = new AttackStats(Name, 2, 2);

    }

  }
}