using BossFight.Attacks;
using BossFight.UI.Drawables;
using BossFight.UI.Models;

namespace BossFight.UI.Pokemon
{
  public interface IPokemon
  {
    public IDrawableBase HeadsUpDisplay { get; set; }
    public IDrawableBase Avatar { get; set; }
    public Stats PokemonStats { get; set; }
    void SubtractHealth(int damage);
    public IAttacks GetNextAttack();
  }
}
