using BossFight.BLL;
using BossFight.UI.Helpers;
using BossFight.UI.Models;
using System;
using BossFight.DAL;
using BossFight.UI.Pokemon;
using System.Linq;
using BossFight.Attacks;

namespace BossFight
{
  public class Game : IGame
  {
    public Func<ConsoleKeyInfo> consoleReadKey = () => Console.ReadKey();
    public Action clearConsole = () => Console.Clear();
    private IPokemonDrawHelper drawHelper1;
    private IPokemonFactory pokemonFactory1;
    private IPokemonFightHelper pokemonFight1;
    private IAttackFactory attackFactory1;
    private IItemFactory itemFactory1;
    private IpokemonItemHelper pokemonItemHelper1;

    public Func<IPokemonFactory, IPokemon> getRandomPOkemon { get; set; } 


    private readonly IPokemonDrawHelper drawHelper;
    private readonly IPokemonFactory pokemonFactory;

    private readonly IPokemonFightHelper pokemonFight;
    private readonly IAttackFactory attackFactory;
    private readonly IBossFightRepository _bossFightRepository;

    private readonly IItemFactory itemFactory;
    private readonly IpokemonItemHelper pokemonItem;

    public Game(IPokemonDrawHelper drawHelper, IPokemonFactory pokemonFactory, IPokemonFightHelper pokemonFight,
      IAttackFactory attackFactory, IBossFightRepository bossFightRepository, IItemFactory itemFactory, IpokemonItemHelper pokemonItem)
    {
      this.getRandomPOkemon = factory => factory.GetRandomPokemon();
      this.drawHelper = drawHelper;
      this.pokemonFactory = pokemonFactory;
      this.pokemonFight = pokemonFight;
      this.attackFactory = attackFactory;
      this.pokemonItem = pokemonItem;
      _bossFightRepository = bossFightRepository;
      this.itemFactory = itemFactory;
    }

    public Game(IPokemonDrawHelper drawHelper, IPokemonFactory pokemonFactory, IPokemonFightHelper pokemonFight, IAttackFactory attackFactory, IItemFactory itemFactory, IpokemonItemHelper ipokemonItem)
    {
      this.drawHelper = drawHelper;
      this.pokemonFactory = pokemonFactory;
      this.pokemonFight = pokemonFight;
      this.attackFactory = attackFactory;
      this.itemFactory = itemFactory;
      this.pokemonItem = pokemonItem;
    }

    public void StartGame()
    {



      var pikachu = pokemonFactory.CreatePokemon(2, PokemonType.Type.Pikachu);
      var francisco = pokemonFactory.CreatePokemon(2, PokemonType.Type.Francisco);
      

      var stabAttack = attackFactory.CreateAttacks(AttackType.Type.Stab);
      var kickAttack = attackFactory.CreateAttacks(AttackType.Type.Kick);
      var punchAttack = attackFactory.CreateAttacks(AttackType.Type.Punch);
      var biteAttack = attackFactory.CreateAttacks(AttackType.Type.Bite);
      var rollAttack = attackFactory.CreateAttacks(AttackType.Type.Roll);

      var potion = itemFactory.CreateItems(ItemType.Type.Potion);
      var bomb = itemFactory.CreateItems(ItemType.Type.Bomb);





      drawHelper.DrawScreen(francisco, pikachu);


      Boolean keepFighting = true;
      while (keepFighting)
      {

        drawHelper.ShowNotification("Choose an action!");
        ConsoleKeyInfo menuSelection = consoleReadKey();
        switch (menuSelection.KeyChar)
        {
          case '1':
            drawHelper.DrawFightMenu();

            // Lets select an attack
            ConsoleKeyInfo attackSelection = consoleReadKey();
            switch (attackSelection.KeyChar)
            {
              case '1':
                drawHelper.ClearFightMenu();
                pokemonFight.AttackPokemon(francisco, stabAttack, pikachu);
                break;
              case '2':
                drawHelper.ClearFightMenu();
                pokemonFight.AttackPokemon(francisco, kickAttack, pikachu);
                break;
              case '3':
                drawHelper.ClearFightMenu();
                pokemonFight.AttackPokemon(francisco, punchAttack, pikachu);
                break;
              case '4':
                drawHelper.ClearFightMenu();
                pokemonFight.AttackPokemon(francisco, biteAttack, pikachu);
                break;
              case '5':
                drawHelper.ClearFightMenu();
                pokemonFight.AttackPokemon(francisco, rollAttack, pikachu);
                break;

            }

            // Redraw enemy HUD after attack and see if they died
            consoleReadKey();
            drawHelper.ClearNotification();
            drawHelper.DrawScreen(francisco, pikachu);


            consoleReadKey();
            if (!CheckIfBattleEnds(francisco, pikachu))
            {
              keepFighting = false;
              break;
            }


            // let the enemy attack
            drawHelper.ClearNotification();
            drawHelper.ShowNotification("Enemy's turn!");
            consoleReadKey();
            pokemonFight.EnemyAttack(pikachu, francisco);

            // Redraw player HUD after attack and see if player died
            drawHelper.DrawPlayer(francisco);
            if (!CheckIfBattleEnds(francisco, pikachu))
            {
              keepFighting = false;
              break;
            }
            consoleReadKey();
            drawHelper.ClearNotification();

            drawHelper.DrawScreen(francisco, pikachu);


            break;

          case '2':
            drawHelper.DrawItemMenu();

            // Lets select an item
            ConsoleKeyInfo itemSelection = consoleReadKey();
            switch (itemSelection.KeyChar)
            {
              case '1': //potion
                drawHelper.ClearFightMenu();
                pokemonItem.UseItem(francisco, potion, pikachu);
                break;
              case '2':
                drawHelper.ClearFightMenu();
                pokemonItem.UseItem(francisco, bomb, pikachu);
                break;
            }


            consoleReadKey();
            drawHelper.ClearNotification();
            if (!CheckIfBattleEnds(francisco, pikachu))
            {
              keepFighting = false;
              break;
            }

            // let the enemy attack
            drawHelper.ClearNotification();
            drawHelper.ShowNotification("Enemy's turn!");
            consoleReadKey();
            pokemonFight.EnemyAttack(pikachu, francisco);

            drawHelper.DrawScreen(francisco, pikachu);

            break;


          case '3':
            RunFromBattle();
            break;
        }
        CheckIfBattleEnds(francisco, pikachu);
      }
    }

    public bool CheckIfBattleEnds(IPokemon player, IPokemon enemy)
    {
      if (enemy.PokemonStats.CurrentHp <= 0)
      {
        drawHelper.ShowWinMessage();
        return false;
      }
      else if (player.PokemonStats.CurrentHp <= 0)
      {
        drawHelper.ShowDefeatMessage();
        return false;
      }

      return true;
    }

    public IPokemon pokemonFromDB()
    {
      var allPokemon = _bossFightRepository.Query<DAL.Models.Pokemon>("Select Name, Health, Speed FROM dbo.Pokemon ORDER BY NEWID()");
      var pokemonList = allPokemon.ToList();
      var randomPokemon = pokemonList[3];

      PokemonType.Type.TryParse(randomPokemon.Name, out PokemonType.Type randomPokemonType);
      var enemyPokemon = pokemonFactory.CreatePokemon(2, randomPokemonType);
      return enemyPokemon;
    }


    public IAttacks AttackFromDB(string currentPokemon)
    {
      var allAttacks = _bossFightRepository.Query<DAL.Models.Attacks>("Select a.name FROM" +
        " dbo.Attacks a" +
        "INNER JOIN dbo.PokemonAttackXref xr" +
        "ON a.Id = xr.AttackID" +
        "WHERE xr.PokemonID = (SELECT ID FROM dbo.Pokemon WHERE Name = 'Francisco')"        );
      var attackList = allAttacks.ToList();
      var randomAttack = attackList[1];

      AttackType.Type.TryParse(randomAttack.Name, out AttackType.Type myAttack);
      var enemyAttack = attackFactory.CreateAttacks(myAttack);

      return enemyAttack;
    }

    public void RunFromBattle()
    {
      drawHelper.ShowRunMessage();
    }

  }
}
