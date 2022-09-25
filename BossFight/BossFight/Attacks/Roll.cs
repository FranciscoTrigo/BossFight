using BossFight.UI.Models;

namespace BossFight.Attacks
{
  public class Roll : IAttacks
  {

    private const string Name = "Roll";
    public AttackStats AttackStats { get; set; }



    public Roll()
    {
      AttackStats = new AttackStats(Name, 1, 3);

    }

  }
}