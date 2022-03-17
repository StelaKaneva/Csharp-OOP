using FakeAxeAndDummy.Contracts;
using Moq;

public class StartUp
{
    static void Main(string[] args)
    {
        //IWeapon weapon = new Axe(10, 10);
        //ITarget target = new Dummy(10, 20);
        //Hero hero = new Hero("Adele", weapon);

        //hero.Attack(target);

        Mock<ITarget> target = new Mock<ITarget>();
        target.Setup(t => t.GiveExperience()).Returns(20);

        Mock<IWeapon> weapon = new Mock<IWeapon>();
        weapon.Setup(w => w.AttackPoints).Returns(55);

        System.Console.WriteLine($"Fake Attack: {weapon.Object.AttackPoints}");
        System.Console.WriteLine($"Fake Durability: {weapon.Object.DurabilityPoints}");

        weapon.Object.Attack(target.Object);
        
        int experience = target.Object.GiveExperience();
        System.Console.WriteLine(experience);//0
        Hero hero = new Hero("Adele", weapon.Object);
    }
}
