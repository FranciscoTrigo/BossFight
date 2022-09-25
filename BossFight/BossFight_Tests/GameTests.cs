using BossFight;
using BossFight.Attacks;
using BossFight.BLL;
using BossFight.Pokemon;
using BossFight.UI.Helpers;
using BossFight.UI.Models;
using BossFight.UI.Pokemon;
using FakeItEasy;
using System;
using Xunit;

namespace BossFight_Tests
{
  public class GameTests
  {
    private IPokemonDrawHelper drawHelper;
    private IPokemonFactory pokemonFactory;
    private IPokemonFightHelper pokemonFight;
    private IAttackFactory attackFactory;
    private IItemFactory itemFactory;
    private IpokemonItemHelper pokemonItem;

    private Game GetSystemUnderTest()
    {
      drawHelper = A.Fake<IPokemonDrawHelper>();
      pokemonFactory = A.Fake<IPokemonFactory>();
      pokemonFight = A.Fake<IPokemonFightHelper>();
      attackFactory = A.Fake<IAttackFactory>();

      return new Game(drawHelper, pokemonFactory, pokemonFight, attackFactory, itemFactory, pokemonItem);
    }

    [Fact]
    public void StartGame_CallsCorrectMethods()
    {
      //Arrange
      var sut = GetSystemUnderTest();

      attackFactory = new AttackFactory();

      var fakePikachu = new Pikachu(2, attackFactory);
      var fakeFrancisco = new Francisco(2, attackFactory);
      var fakeStab = new Stab();

      sut.getRandomPOkemon = factory => new Pikachu(2, attackFactory);


      A.CallTo(() => pokemonFactory.CreatePokemon(1, PokemonType.Type.Pikachu)).Returns(fakePikachu);
      A.CallTo(() => pokemonFactory.CreatePokemon(1, PokemonType.Type.Francisco)).Returns(fakeFrancisco);


      A.CallTo(() => pokemonFight.AttackPokemon(fakeFrancisco, fakeStab, fakePikachu)).Invokes(() =>
      {
        fakePikachu.SubtractHealth(100);
      });

      sut.consoleReadKey = () => new ConsoleKeyInfo('1', (ConsoleKey)'1', false, false, false);
      sut.clearConsole = () => { };

      //Act
      sut.StartGame();

      //Assert

      A.CallTo(() => drawHelper.ShowNotification("Choose an action")).MustHaveHappened();
      A.CallTo(() => drawHelper.ClearNotification()).MustHaveHappened();
      A.CallTo(() => drawHelper.DrawFightMenu()).MustHaveHappened();
      A.CallTo(() => drawHelper.ClearFightMenu()).MustHaveHappened();
      A.CallTo(() => drawHelper.DrawScreen(A<IPokemon>.Ignored, A<IPokemon>.Ignored)).MustHaveHappened();

      A.CallTo(() => pokemonFight.AttackPokemon(A<IPokemon>.Ignored, A<IAttacks>.Ignored, A<IPokemon>.Ignored)).MustHaveHappened();
    }
  }
}
