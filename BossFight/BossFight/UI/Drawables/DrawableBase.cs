using System;
using System.Collections.Generic;
using BossFight.UI.Models;

namespace BossFight.UI.Drawables
{
  public abstract class DrawableBase : IDrawableBase




  {


//    public static Action CursorPosition = () => Console.SetCursorPosition(10, 10);

    private string drawing;
    private Position position;

    public void SetDrawing(string newDrawing)
    {
      drawing = newDrawing;
    }

    public void SetPosition(int x, int y)
    {
      position = new Position(x, y);
    }

    public void Draw()
    {
      var individualLines = drawing.Split(Environment.NewLine);

      DrawLines(individualLines);
    }

    private void DrawLines(IEnumerable<string> lines)
    {
      foreach (var line in lines)
      {

          DrawLine(line, position);
          position.IncrementVerticalPosition();

      }
    }

    private static void DrawLine(string line, Position position)
    { 
      Console.SetCursorPosition(position.X, position.Y);
     // CursorPosition();
      Console.WriteLine(line);
    }
  }
}
