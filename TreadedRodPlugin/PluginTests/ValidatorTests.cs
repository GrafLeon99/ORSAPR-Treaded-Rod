using NUnit.Framework;
using Plugin;
using System;

namespace PluginTests
{
    [TestFixture]
    internal class ValidatorTests
    {
        [Test(Description = "Позитивный тест валидатора")]
        public void Test_IsInRange_Correct()
        {
            //Arrange
            double value = 8;
            double minValue = 4;
            double maxValue = 12;

            //Assert
            Assert.IsTrue
                (
                //Act
                Validator.IsInRange(value, minValue, maxValue)
                );
        }

        [TestCase(2, 3, 4, Description = "Значение меньше минимального")]
        [TestCase(8, 3, 4, Description = "Значение больше максимального")]
        [Test(Description = "Негативный тест валидатора")]
        public void Test_IsInRange_Incorrect(double value, double minValue, double maxValue)
        {

            //Assert
            Assert.IsFalse
                (
                //Act
                Validator.IsInRange(value, minValue, maxValue)
                );
        }
    }
}
