using BossFight.UI.Models;

namespace BossFight.Attacks
{
  public class Spark : IAttacks
  {

    private const string Name = "Spark";
    public AttackStats AttackStats { get; set; }



    public Spark()
    {
      AttackStats = new AttackStats(Name, 2, 2);

    }

  }
}