using System;
using BossFight;
using BossFight.Attacks;
using BossFight.BLL;
using BossFight.Pokemon;
using BossFight.UI.Helpers;
using BossFight.UI.Models;
using BossFight.UI.Pokemon;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using FakeItEasy;
using FluentAssertions;
using Xunit;

namespace BossFight_Tests
{
  public class PokemonFactoryTests
  {
    private IPokemon pokemon;
    private IPokemonFactory pokemonFactory;
    private IAttackFactory attackFactory;

    private PokemonFactory GetSystemUnderTest()
    {

      pokemon = A.Fake<IPokemon>();
      pokemonFactory = A.Fake<IPokemonFactory>();
      attackFactory = A.Fake<IAttackFactory>();

      return new PokemonFactory(attackFactory);
    }

    [Fact]
    public void PokemonFactory_Correct()
    {
      var sut = GetSystemUnderTest();

      var fakeDitto = new Ditto(1, new AttackFactory());
      var fakeFrancisco = new Francisco(1, new AttackFactory());
      var fakePikachu = new Pikachu(1, new AttackFactory());

      A.CallTo(() => pokemonFactory.CreatePokemon(1, PokemonType.Type.Ditto)).Returns(fakeDitto);
      A.CallTo(() => pokemonFactory.CreatePokemon(1, PokemonType.Type.Francisco)).Returns(fakeFrancisco);
      A.CallTo(() => pokemonFactory.CreatePokemon(1, PokemonType.Type.Pikachu)).Returns(fakePikachu);


      var result = pokemonFactory.CreatePokemon(1, PokemonType.Type.Ditto);
      result.Should().Be(fakeDitto);
    }

    [Fact]
    public void CreatePokemon_CanCreateDitto()
    {
      var sut = GetSystemUnderTest();
      var fakeDitto = new Ditto(1,new AttackFactory());
      A.CallTo(() => pokemonFactory.CreatePokemon(1, PokemonType.Type.Ditto)).Returns(fakeDitto);
      var result = pokemonFactory.CreatePokemon(1, PokemonType.Type.Ditto);
      result.Should().Be(fakeDitto);
    }

    [Fact]
    public void CreatePokemon_CanCreatePikachu()
    {
      var sut = GetSystemUnderTest();
      var fakePikachu = new Pikachu(1, new AttackFactory());
      A.CallTo(() => pokemonFactory.CreatePokemon(1, PokemonType.Type.Ditto)).Returns(fakePikachu);
      var result = pokemonFactory.CreatePokemon(1, PokemonType.Type.Ditto);
      result.Should().Be(fakePikachu);
    }

    [Fact]
    public void CreatePokemon_CanCreateFrancisco()
    {
      var sut = GetSystemUnderTest();
      var fakeFrancisco = new Francisco(1, new AttackFactory());
      A.CallTo(() => pokemonFactory.CreatePokemon(1, PokemonType.Type.Francisco)).Returns(fakeFrancisco);
      var result = pokemonFactory.CreatePokemon(1, PokemonType.Type.Francisco);
      result.Should().Be(fakeFrancisco);
    }


  }
}
