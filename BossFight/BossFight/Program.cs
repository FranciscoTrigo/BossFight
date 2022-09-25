using System;
using BossFight.Startup;
using Microsoft.Extensions.DependencyInjection;

namespace BossFight
{
  internal class Program
  {
    private static void Main()
    {
      var serviceProvider = ApplicationStart.ConfigureServices();

      var game = serviceProvider.GetService<IGame>();
      game?.StartGame();

      ScrollToTop();
    }

    private static void ScrollToTop()
    {
      Console.SetCursorPosition(0,0);
      Console.CursorVisible = false;
      Console.ReadKey();
    }

  }
}
