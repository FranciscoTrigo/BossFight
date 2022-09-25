using BossFight.UI.Models;

namespace BossFight.Items
{
  public class Bomb : IItems
  {

    private const string name = "Potion";
    public ItemEffects ItemEffects { get; set; }

    public Bomb()
    {
      ItemEffects = new ItemEffects("Bomb", 5, 0);
    }

  }
}