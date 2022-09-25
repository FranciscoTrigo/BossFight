using BossFight.UI.Models;

namespace BossFight.Attacks
{
  public class Stab : IAttacks
  {

    private const string Name = "Stab";
    public AttackStats AttackStats { get; set; }

    
    
    public Stab()
    {
      AttackStats = new AttackStats(Name, 3, 8);

    }
  
}
}
