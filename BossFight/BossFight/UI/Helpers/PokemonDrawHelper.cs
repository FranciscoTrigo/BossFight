using System;
using BossFight.UI.Drawables.Menus;
using BossFight.UI.Pokemon;

namespace BossFight.UI.Helpers
{
  public class PokemonDrawHelper : IPokemonDrawHelper
  {
    public void DrawPlayer(IPokemon pokemon)
    {

      pokemon.Avatar.SetPosition(2, 8);
      pokemon.Avatar.Draw();

      pokemon.HeadsUpDisplay.SetPosition(80, 20);
      pokemon.HeadsUpDisplay.Draw();
    }

    public void DrawMenu()
    {
      var menu = new FightMenu();
      menu.SetPosition(40, 27);
      menu.Draw();
    }

    public void DrawFightMenu()
    {
      var attackMenu = new AttackMenu();
      attackMenu.SetPosition(40, 24);
      attackMenu.Draw();
      Console.WriteLine("Choose an attack");
    }

    public void DrawItemMenu()
    {
      var itemMenu = new ItemMenu();
      itemMenu.SetPosition(40, 24);
      itemMenu.Draw();
      Console.WriteLine("Choose an item!");
    }

    public void ClearFightMenu()
    {
      var clearaAttackMenu = new ClearedAttackMenu();
      clearaAttackMenu.SetPosition(40, 24);
      clearaAttackMenu.Draw();
    }

    public void DrawEnemy(IPokemon pokemon)
    {

      pokemon.Avatar.SetPosition(90, 1);
      pokemon.Avatar.Draw();

      pokemon.HeadsUpDisplay.SetPosition(0, 0);
      pokemon.HeadsUpDisplay.Draw();

    }

    public void ShowWinMessage()
    {
      Console.Clear();
      Console.WriteLine("You win!");
    }

    public void ShowNotification(string notification)
    {
      Console.SetCursorPosition(0, 26);
      Console.WriteLine(notification);
    }

    public void ShowDefeatMessage()
    {
      Console.Clear();
      Console.WriteLine("You lose!");
    }

    public void DrawScreen(IPokemon player, IPokemon target)
    {
      DrawPlayer(player);
      DrawEnemy(target);
      DrawMenu();
     // ShowNotification("Choose an action!");
    }

    public void ClearNotification()
    {
      ShowNotification("                                          \n                                          \n                                          \n                                          ");
    }

    public void ShowRunMessage()
    {
      Console.Clear();
      Console.WriteLine("You ran away from battle! Game ended");
    }

  }
}
