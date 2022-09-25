namespace BossFight.UI.Models
{
  public class Stats
  {
    public string Name { get; set; }
    public int Level { get; set; }
    public int MaxHp { get; set; }
    public int CurrentHp { get; set; }

    public int Speed { get; set; }

    public Stats(string name, int level)
    {
      Name = name;
      Level = level;
      MaxHp = level * Settings.HitPointsPerLevel;
      Speed = level + 2 * 5 / 2;
      CurrentHp = MaxHp;

    }
  }
}
