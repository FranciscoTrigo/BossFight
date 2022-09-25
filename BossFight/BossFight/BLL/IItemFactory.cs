using System;
using System.Collections.Generic;
using System.Text;
using BossFight.UI.Models;
using BossFight.Items;

namespace BossFight.BLL
{
  public interface IItemFactory
  {

    public IItems CreateItems(ItemType.Type itemType);


  }
}
