namespace BossFight.UI.Models
{
  public class Position
  {
    public int X { get; }
    public int Y { get; set; }

    public Position(int x, int y)
    {
      X = x;
      Y = y;
    }

    public void IncrementVerticalPosition()
    {
      Y++;
    }
  }
}
