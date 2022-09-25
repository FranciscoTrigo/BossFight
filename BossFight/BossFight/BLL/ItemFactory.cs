using BossFight.Items;
using BossFight.UI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BossFight.BLL
{
  public class ItemFactory : IItemFactory
  {
    public IItems CreateItems(ItemType.Type itemType)
    {
      if (itemType == ItemType.Type.Bomb)
      {
        return new Bomb();
      }
      if (itemType == ItemType.Type.Potion)
      {
        return new Potion();
      }

      throw new Exception();

    }
  }
}
