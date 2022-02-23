using NUnit.Framework;
using System;

namespace Demo.Tests
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void DoesWhatsMyNameWorkProperly()
        {
            //Arrange
            Person person = new Person("Stoyan", 10);

            //Act
            string expectedResult = "My name is Stoyan";
            string actualResult = person.WhatsMyName();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


            //Assert.Throws<NotImplementedException>(() => person.WhatsMyName());

            //var expectedResult = 10;
            //var actualResult = person.SavedMoney;

            //Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
