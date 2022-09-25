using BossFight.UI.Pokemon;

namespace BossFight.UI.Helpers
{
  public interface 
    IPokemonDrawHelper
  {
    public void DrawEnemy(IPokemon pokemon);

    public void DrawMenu();

    public void DrawPlayer(IPokemon pokemon);
    void ShowWinMessage();

    public void ShowNotification(string notification);
    void ShowDefeatMessage();
    void DrawFightMenu();

    void DrawItemMenu();

    void ClearFightMenu();

    public void DrawScreen(IPokemon player, IPokemon target);
    public void ClearNotification();

    public void ShowRunMessage();

  }
}
