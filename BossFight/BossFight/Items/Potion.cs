using BossFight.UI.Models;

namespace BossFight.Items
{
  public class Potion : IItems
  {

    private const string name = "Potion";
    public ItemEffects ItemEffects { get; set; }

    public Potion()
    {
      ItemEffects = new ItemEffects("Potion", 0, 5);
    }

  }
}