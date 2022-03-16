using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Anton", 35, 45)]
        [TestCase("Adele", 45, 100)]
        public void WarriorConstructorShouldSetDataProperly(string name, int damage, int hp)
        {
            //Arrange - Act
            Warrior warrior = new Warrior(
                name: name,
                damage: damage,
                hp: hp);

            //Assert
            Assert.AreEqual(warrior.Name, name);
            Assert.AreEqual(warrior.Damage, damage);
            Assert.AreEqual(warrior.HP, hp);
        }

        [Test]
        [TestCase(" ")]
        [TestCase("   ")]
        [TestCase("\t")]
        [TestCase("\n")]
        [TestCase(null)]
        [TestCase("")]
        public void WarriorConstructorShouldThrowExceptionIfNameIsNullOrWhiteSpace(string name)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, 40, 40));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-10)]
        public void WarriorConstructorShouldThrowExceptionIfDamageIsZeroOrNegative(int damage)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("name", damage, 40));
        }

        [Test]
        [TestCase(-10)]
        public void WarriorConstructorShouldThrowExceptionIfHPIsNegative(int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("name", 40, hp));
        }

        [Test]
        [TestCase("Adele", 10, 10, "Anton", 10, 10)]
        [TestCase("Adele", 10, 100, "Anton", 10, 10)]
        [TestCase("Adele", 10, 30, "Anton", 10, 10)]
        [TestCase("Adele", 10, 25, "Anton", 10, 50)]
        [TestCase("Adele", 40, 40, "Anton", 70, 20)]
        [TestCase("Adele", 10, 50, "Anton", 100, 50)]
        public void WarriorAttackOperationMethodShouldThrowInvalidOperationExceptionIfHPIsInvalid(string fighterName, int fighterDamage, int fighterHp, string defenderName, int defenderDamage, int defenderHp)
        {
            var fighter = new Warrior(fighterName, fighterDamage, fighterHp);
            var defender = new Warrior(defenderName, defenderDamage, defenderHp);

            Assert.Throws<InvalidOperationException>(() => fighter.Attack(defender));
        }

        [Test]
        [TestCase("Adele", 10, 50, 40, "Anton", 10, 50, 40)]
        [TestCase("Adele", 20, 100, 90, "Anton", 10, 70, 50)]
        [TestCase("Adele", 50, 100, 90, "Anton", 10, 40, 0)]
        public void WarriorAttackOperationShouldDecreaseHP(string fighterName, int fighterDamage, int fighterHp, int fighterHPLeft, string defenderName, int defenderDamage, int defenderHp, int defenderHPLeft)
        {
            //Arrange
            var fighter = new Warrior(fighterName, fighterDamage, fighterHp);
            var defender = new Warrior(defenderName, defenderDamage, defenderHp);

            //Act
            fighter.Attack(defender);

            //Assert
            var expectedFighterHP = fighterHPLeft;
            var expectedDefenderHP = defenderHPLeft;

            Assert.AreEqual(expectedFighterHP, fighter.HP);
            Assert.AreEqual(expectedDefenderHP, defender.HP);
        }
    }
}