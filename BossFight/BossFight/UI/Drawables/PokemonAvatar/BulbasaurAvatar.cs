namespace BossFight.UI.Drawables.PokemonAvatar
{
  public class BulbasaurAvatar : DrawableBase
  {

    public BulbasaurAvatar()
    {
      SetDrawing(AsciiAvatar);
    }

    public const string AsciiAvatar = @"
            ____M___
           (  /   \ \
     \ ----/\ (    ) )
     / O  O  |---- _/
    |   _         \
     \__U____/ _(  |
      |_/   |_/  |_/";

  }
}
