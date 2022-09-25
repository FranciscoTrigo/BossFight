using BossFight.Attacks;
using BossFight.BLL;
using BossFight.UI.Drawables;
using BossFight.UI.Drawables.HeadsUpDisplays;
using BossFight.UI.Drawables.PokemonAvatar;
using BossFight.UI.Models;

namespace BossFight.UI.Pokemon
{
  public class Pikachu : IPokemon
  {
    private readonly IAttackFactory attackFactory;
    private const string Name = "Pikachu";
    public IDrawableBase HeadsUpDisplay { get; set; }
    public IDrawableBase Avatar { get; set; }
    public Stats PokemonStats { get; set; }
    
    public Pikachu(int level, IAttackFactory attackFactory)
    {
      this.attackFactory = attackFactory;
      PokemonStats = new Stats(Name, level);
      HeadsUpDisplay = new HeadsUpDisplay(PokemonStats);

      Avatar = new PikachuAvatar();
    }

    public void SubtractHealth(int damage)
    {
      PokemonStats.CurrentHp -= damage;
      if (PokemonStats.CurrentHp < 0)
      {
        PokemonStats.CurrentHp = 0;
      }
      HeadsUpDisplay = new HeadsUpDisplay(PokemonStats);
    }

    public IAttacks GetNextAttack()
    {
      return attackFactory.SpecificGetRandomAttack(5, 9);
    }
  }
}
