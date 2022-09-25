 using System;
using BossFight.UI.Models;
 using BossFight.UI.Pokemon;
 using Microsoft.VisualBasic;

 namespace BossFight.UI.Drawables.HeadsUpDisplays
{
  public class HeadsUpDisplay : DrawableBase
  {
    public HeadsUpDisplay(Stats stats)
    {
      var characterInfoDisplay = string.Empty;

      
      characterInfoDisplay += GetBasicInfo(stats.Name, stats.Level);
      characterInfoDisplay += GetHealthBar(stats.CurrentHp, stats.MaxHp);
      characterInfoDisplay += GetOutline();

      //Random rnd = new Random();

      //characterInfoDisplay = $"{rnd.Next(4, 44)}";


      SetDrawing(characterInfoDisplay);
    }

    private static string GetBasicInfo(string name, int level)
    {
      var basicInfo = string.Empty;

      basicInfo += ($"{name}{Environment.NewLine}");
      basicInfo += ($"      :L{level}{Environment.NewLine}");

      return basicInfo;
    }

    private static string GetHealthBar(int currentHp, int maxHp)
    {
      var healthBar = string.Empty;

      healthBar += ($"| HP ({currentHp}/{maxHp}):");

      for (var index = 0; index < maxHp; index++)
      {
        healthBar += (index <= currentHp ? '|' : '-');
      }

      healthBar += Environment.NewLine;

      return healthBar;
    }

    private static string GetOutline()
    {
      return "|_______________________________>";
    }
  }
}
