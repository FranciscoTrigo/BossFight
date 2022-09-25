namespace BossFight.UI.Drawables
{
  public interface IDrawableBase
  {
    void SetDrawing(string newDrawing);
    void SetPosition(int x, int y);
    void Draw();
  }
}
