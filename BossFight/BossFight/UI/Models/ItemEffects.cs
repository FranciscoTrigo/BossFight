using System;
using System.Collections.Generic;
using System.Text;

namespace BossFight.UI.Models
{
  public class ItemEffects
  {

    public string Name { get; set; }

    public int Damage { get; set; }
    public int Heal { get; set; }

    public ItemEffects(string name, int damage, int heal)
    {
      Name = name;
      Damage = damage;
      Heal = heal;
    }


  }
}
