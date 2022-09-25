namespace BossFight.UI.Drawables.PokemonAvatar
{
  public class EeveeAvatar : DrawableBase
  {

    public EeveeAvatar()
    {
      SetDrawing(AsciiAvatar);
    }

    public const string AsciiAvatar = @"  
       ;-.               ,
        \ '.           .'/
         \  \ .---. .-' /
          '. '     `\_.'
            |(),()  |     ,
            (  __   /   .' \
           .''.___.'--,/\_,|
          {  /     \   }   |
           '.\     /_.'    /
            |'-.-',  `; _.'
            |  |  |   |`
            -----------  ";

  }
}
