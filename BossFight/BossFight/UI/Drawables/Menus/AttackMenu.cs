namespace BossFight.UI.Drawables.Menus
{
  public class AttackMenu : DrawableBase
  {

    public AttackMenu()
    {
      SetDrawing(Menu);
    }

    public string Menu = @"=============================
1 - Stab  2 - Kick
3 - Punch 4 - Bite  5 - Roll
=============================";

  }
}
