namespace BossFight.UI.Models
{
  public class AttackStats
  {

    public string Name { get; set; }

    public int Damage { get; set; }

    public int Modifier { get; set; }

    public AttackStats(string name, int damage, int modifier)
    {
      Name = name;
      Damage = damage;
      Modifier = modifier;
    }

  }
}
