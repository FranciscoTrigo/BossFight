using BossFight.UI.Models;

namespace BossFight.Attacks
{
  public class TailPunch : IAttacks
  {

    private const string Name = "Tail Punch";
    public AttackStats AttackStats { get; set; }



    public TailPunch()
    {
      AttackStats = new AttackStats(Name, 2, 2);

    }

  }
}