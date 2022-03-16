using FightingArena;
using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class ArenaTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldInitializeDependentValues()
        {
            Arena arena = new Arena();

            Assert.IsNotNull(arena.Warriors);
        }


        [Test]
        public void EnrollShouldThrowExceptionIfWarriorExists()
        {
            Warrior warrior = new Warrior("Adele", 10, 10);
            Arena arena = new Arena();
            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));
        }

        [Test]
        public void EnrollShouldAddWarriorToCollection()
        {
            Warrior warrior = new Warrior("Adele", 10, 10);
            Warrior defender = new Warrior("Solumyr", 10, 50);
            Arena arena = new Arena();
            arena.Enroll(warrior);
            arena.Enroll(defender);

            var expectedCount = 2;
            Assert.AreEqual(expectedCount, arena.Count);

            var adeleExists = arena.Warriors.Any(w => w.Name == "Adele");
            var solumyrExists = arena.Warriors.Any(w => w.Name == "Solumyr");

            Assert.IsTrue(adeleExists);
            Assert.IsTrue(solumyrExists);
        }

        [Test]
        [TestCase("Adele", "Solumyr")]
        [TestCase("Solumyr", "Adele")]
        public void FightShouldThrowExceptionIfWarriorDoesNotExist(string attacker, string defender)
        {
            Arena arena = new Arena();

            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker, defender));

            Warrior warrior = new Warrior(attacker, 10, 10);
            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker, defender));
        }

        [Test]
        
        public void FightShouldWorkAsExpected()
        {
            Warrior attacker = new Warrior("Adele", 10, 50);
            Warrior defender = new Warrior("Solumyr", 10, 50);

            Arena arena = new Arena();
            arena.Enroll(attacker);
            arena.Enroll(defender);

            arena.Fight("Adele", "Solumyr");

            var adeleHp = arena.Warriors.FirstOrDefault(w => w.Name == "Adele").HP;
            var solumyrHp = arena.Warriors.FirstOrDefault(w => w.Name == "Solumyr").HP;

            Assert.AreEqual(adeleHp, 40);
            Assert.AreEqual(solumyrHp, 40);
        }
    }
}
