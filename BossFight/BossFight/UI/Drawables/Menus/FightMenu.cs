namespace BossFight.UI.Drawables.Menus
{
  public class FightMenu : DrawableBase
  {
    public FightMenu()
    {
      SetDrawing(Menu);
    }

    public string Menu = @"============================================
 1 - Fight     2 - Items    3 - Run
============================================";
  }
}
