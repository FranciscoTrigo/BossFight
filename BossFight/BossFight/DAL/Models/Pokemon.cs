using BossFight.Attacks;
using BossFight.UI.Drawables;
using BossFight.UI.Models;
using BossFight.UI.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;

namespace BossFight.DAL.Models
{
  public class Pokemon
  {
    public int Id { get; set; }
   public string Name { get; set; }

    public int Health { get; set; }
    public int Speed { get; set; }


  }
}
