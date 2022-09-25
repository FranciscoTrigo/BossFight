namespace BossFight.UI.Drawables.PokemonAvatar
{
  public class FranciscoAvatar : DrawableBase
  {
    public FranciscoAvatar()
    {
      SetDrawing(HeroAscii);
    }

    private const string HeroAscii = @"
   .------\ /------.
   |       -       |
   |               |
   |               |
   |               |
_______________________
===========.===========
  / ~~~~~     ~~~~~ \
 /|     |     |\
 W   ---  / \  ---   W
 \.      |o o|      ./
  |                 |
  \    #########    /
   \  ## ----- ##  /
    \##         ##/
     \_____v_____/";
  }
}
