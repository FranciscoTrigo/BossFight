using BossFight.Attacks;
using BossFight.BLL;
using BossFight.UI.Drawables;
using BossFight.UI.Drawables.HeadsUpDisplays;
using BossFight.UI.Drawables.PokemonAvatar;
using BossFight.UI.Models;

namespace BossFight.UI.Pokemon
{
  public class Ditto : IPokemon
  {
    private readonly IAttackFactory attackFactory;
    private const string Name = "Ditto";
    public IDrawableBase HeadsUpDisplay { get; set; }
    public IDrawableBase Avatar { get; set; }
    public Stats PokemonStats { get; set; }
    public IAttacks[] PokemonAttacksArray { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public Ditto(int level, IAttackFactory attackFactory)
    {
      this.attackFactory = attackFactory;
      PokemonStats = new Stats(Name, level);
      HeadsUpDisplay = new HeadsUpDisplay(PokemonStats);

      Avatar = new DittoAvatar();
    }

    public void SubtractHealth(int damage)
    {
      {
        PokemonStats.CurrentHp -= damage;
        if (PokemonStats.CurrentHp < 0)
        {
          PokemonStats.CurrentHp = 0;
        }

        HeadsUpDisplay = new HeadsUpDisplay(PokemonStats);
      }

    }

    IAttacks IPokemon.GetNextAttack()
    {
      return attackFactory.GetRandomAttack(); ;
    }
  }
}
