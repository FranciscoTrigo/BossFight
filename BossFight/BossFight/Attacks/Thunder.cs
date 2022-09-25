using BossFight.UI.Models;

namespace BossFight.Attacks
{
  public class Thunder : IAttacks
  {

    private const string Name = "Thunder";
    public AttackStats AttackStats { get; set; }



    public Thunder()
    {
      AttackStats = new AttackStats(Name, 1, 2);

    }

  }
}