using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyShouldLooseHealthIfAttacked()
    {
        //Arrange
        Dummy dummy = new Dummy(100, 100);

        //Act
        dummy.TakeAttack(10);

        //Assert
        var expectedResult = 90;
        var actualResult = dummy.Health;

        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void DeadDummyShouldThrowExceptionIfAttacked()
    {
        //Arrange
        Dummy dummy = new Dummy(0, 100);

        //Act - Assert

        Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));
    }

    [Test]
    public void DeadDummyShouldGiveXp()
    {
        //Arrange
        Dummy dummy = new Dummy(0, 100);

        //Act - Assert
        var actualResult = dummy.GiveExperience();
        var expectedResult = 100;

        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void AliveDummyShouldNotGiveXp()
    {
        //Arrange
        Dummy dummy = new Dummy(100, 100);

        //Act - Assert

        Assert.That(() => dummy.GiveExperience(), Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));

        //Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
    }
}
