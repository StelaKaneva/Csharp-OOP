using FakeAxeAndDummy.Contracts;
using Moq;
//using FakeAxeAndDummy.Tests.Fakes;
using NUnit.Framework;

[TestFixture]
public class HeroTests
{
    [Test]
    public void GivenHero_WhenAttackedTargetDies_ThenHeroReceivesExperience()
    {
        Mock<ITarget> fakeTarget = new Mock<ITarget>();
        fakeTarget.Setup(f => f.GiveExperience()).Returns(20);
        fakeTarget.Setup(f => f.IsDead()).Returns(true);

        Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();

        Hero hero = new Hero("Adele", fakeWeapon.Object);
        hero.Attack(fakeTarget.Object);

        Assert.AreEqual(20, hero.Experience);


        //ITarget fakeTarget = new ITargetFake();
        //IWeapon fakeWeapon = new IWeaponFake();

        //Hero hero = new Hero("Adele", fakeWeapon);

        //hero.Attack(fakeTarget);

        //Assert.AreEqual(20, hero.Experience);
    }
}