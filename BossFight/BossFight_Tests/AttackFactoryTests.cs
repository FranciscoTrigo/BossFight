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
  public class AttackFactoryTests
  {

    private IAttackFactory attackFactory;
    private IAttacks attacks;

    private AttackFactory GetSystemUnderTest()
    {
      attacks = A.Fake<IAttacks>();
      attackFactory = A.Fake<IAttackFactory>();

      return new AttackFactory();
    }

    [Fact]
    public void AttackFactory_Correct()
    {
      var sut = GetSystemUnderTest();
      var fakeStab = new Stab();
      var fakeBite = new Bite();
      var fakeKick = new Kick();
      var fakePunch = new Punch();
      var fakeRoll = new Roll();
      var fakeElectroBall = new ElectroBall();
      var fakeQuickAttack = new QuickAttack();
      var fakeSpark = new Spark();
      var fakeTacke = new Tackle();
      var fakeThunder = new Thunder();


      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Stab)).Returns(fakeStab);
      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Bite)).Returns(fakeBite);
      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Kick)).Returns(fakeKick);
      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Punch)).Returns(fakePunch);
      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Roll)).Returns(fakeRoll);
      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.ElectroBall)).Returns(fakeElectroBall);
      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.QuickAttack)).Returns(fakeQuickAttack);
      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Spark)).Returns(fakeSpark);
      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Tackle)).Returns(fakeTacke);
      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Thunder)).Returns(fakeThunder);

      var result = attackFactory.CreateAttacks(AttackType.Type.Spark).Should().Be(fakeSpark);


    }

    [Fact]
    public void CreateAttack_CanCreateStab()
    {
      var sut = GetSystemUnderTest();
      var fakeStab = new Stab();
      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Stab)).Returns(fakeStab);
      var result = attackFactory.CreateAttacks(AttackType.Type.Stab);
      result.Should().Be(fakeStab);
    }

    [Fact]
    public void CreateAttack_CanCreateBite()
    {
      var sut = GetSystemUnderTest();
      var fakeBite = new Bite();
      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Bite)).Returns(fakeBite);
      var result = attackFactory.CreateAttacks(AttackType.Type.Bite);
      result.Should().Be(fakeBite);
    }

    [Fact]
    public void CreateAttack_CanCreateKick()
    {
      var sut = GetSystemUnderTest();
      var fakeKick = new Kick();
      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Kick)).Returns(fakeKick);
      var result = attackFactory.CreateAttacks(AttackType.Type.Kick);
      result.Should().Be(fakeKick);
    }

    [Fact]
    public void CreateAttack_CanCreatePunch()
    {
      var sut = GetSystemUnderTest();
      var fakePunch = new Punch();
      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Punch)).Returns(fakePunch);
      var result = attackFactory.CreateAttacks(AttackType.Type.Punch);
      result.Should().Be(fakePunch);
    }

    [Fact]
    public void CreateAttack_CanCreateRoll()
    {
      var sut = GetSystemUnderTest();
      var fakeRoll = new Roll();
      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Roll)).Returns(fakeRoll);
      var result = attackFactory.CreateAttacks(AttackType.Type.Roll);
      result.Should().Be(fakeRoll);
    }

    [Fact]
    public void CreateAttack_CanCreateElectroBall()
    {
      var sut = GetSystemUnderTest();
      var fakeElectroBall = new ElectroBall();
      A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.ElectroBall)).Returns(fakeElectroBall);
      var result = attackFactory.CreateAttacks(AttackType.Type.ElectroBall);
      result.Should().Be(fakeElectroBall);
    }

    [Fact]
      public void CreateAttack_CanCreateQuickAttack()
      {
        var sut = GetSystemUnderTest();
        var fakeQuickAttack = new QuickAttack();
        A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.QuickAttack)).Returns(fakeQuickAttack);
        var result = attackFactory.CreateAttacks(AttackType.Type.QuickAttack);
        result.Should().Be(fakeQuickAttack);


      }

      [Fact]
      public void CreateAttack_CanCreateSpark()
      {
        var sut = GetSystemUnderTest();
        var fakeSpark = new Spark();
        A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Spark)).Returns(fakeSpark);
        var result = attackFactory.CreateAttacks(AttackType.Type.Spark);
        result.Should().Be(fakeSpark);
      }

      [Fact]
      public void CreateAttack_CanCreateTackle()
      {
        var sut = GetSystemUnderTest();
        var fakeTackle = new Tackle();
        A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Tackle)).Returns(fakeTackle);
        var result = attackFactory.CreateAttacks(AttackType.Type.Tackle);
        result.Should().Be(fakeTackle);
      }

      [Fact]
      public void CreateAttack_CanCreateThunder()
      {
        var sut = GetSystemUnderTest();
        var faketThunder = new Thunder();
        A.CallTo(() => attackFactory.CreateAttacks(AttackType.Type.Thunder)).Returns(faketThunder);
        var result = attackFactory.CreateAttacks(AttackType.Type.Thunder);
        result.Should().Be(faketThunder);
      }

  }


  }

