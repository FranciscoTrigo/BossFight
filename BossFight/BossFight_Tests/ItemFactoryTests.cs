using System;
using BossFight;
using BossFight.Attacks;
using BossFight.BLL;
using BossFight.Items;
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
  public class ItemFactoryTests
  {

    private IItemFactory itemFactory;
    private IItems items;

    private ItemFactory GetSystemUnderTest()
    {
      items = A.Fake<IItems>();
      itemFactory = A.Fake<IItemFactory>();
      return new ItemFactory();
    }

    [Fact]
    public void ItemFactory_Correct()
    {
      var sut = GetSystemUnderTest();
      var fakePotion = new Potion();
      var fakeBomb = new Bomb();

      A.CallTo(() => itemFactory.CreateItems(ItemType.Type.Potion)).Returns(fakePotion);
      A.CallTo(() => itemFactory.CreateItems(ItemType.Type.Bomb)).Returns(fakeBomb);

    }

    [Fact]
    public void CreateItem_CanCreatePotion()
    {
      var sut = GetSystemUnderTest();
      var fakePotion = new Potion();
      A.CallTo(() => itemFactory.CreateItems(ItemType.Type.Potion)).Returns(fakePotion);
      var result = itemFactory.CreateItems(ItemType.Type.Potion);
      result.Should().Be(fakePotion);
    }

    [Fact]
    public void CreateItem_CanCreateBomb()
    {
      var sut = GetSystemUnderTest();
      var fakeBomb = new Bomb();
      A.CallTo(() => itemFactory.CreateItems(ItemType.Type.Bomb)).Returns(fakeBomb);
      var result = itemFactory.CreateItems(ItemType.Type.Bomb);
      result.Should().Be(fakeBomb);
    }



  }
}
