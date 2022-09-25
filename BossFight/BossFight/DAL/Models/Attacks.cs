using System;
using System.Collections.Generic;
using System.Text;

namespace BossFight.DAL.Models
{
  public class Attacks
  {

    public int Id { get; set; }
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Modifier { get; set; }

  }
}
