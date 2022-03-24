using NUnit.Framework;
using Plugin;
using System;

namespace PluginTests
{
    [TestFixture]
    public class ParameterTests
    {
        [Test(Description = "Позитивный тест конструктора параметра")]
        public void Test_Parameter_CorrectValue()
        {
            //Arrange
            double value = 8;
            double minValue = 4;
            double maxValue = 12;

            //Act
            var parameter = new Parameter(value, minValue, maxValue);

            //Assert
            Assert.AreEqual(parameter.Value, value);
            Assert.AreEqual(parameter.MinValue, minValue);
            Assert.AreEqual(parameter.MaxValue, maxValue);
            Assert.AreEqual(parameter.DefaultValue, value);
        }

        [Test(Description = "Позитивный тест конструктора параметра со значением по умолчанию")]
        public void Test_Parameter_CorrectDefaultValue()
        {
            //Arrange
            double defaultValue = 10;
            double value = 8;
            double minValue = 4;
            double maxValue = 12;

            //Act
            var parameter = new Parameter(value, minValue, maxValue, defaultValue);

            //Assert
            Assert.AreEqual(parameter.Value, value);
            Assert.AreEqual(parameter.MinValue, minValue);
            Assert.AreEqual(parameter.MaxValue, maxValue);
            Assert.AreEqual(parameter.DefaultValue, defaultValue);
        }

        [TestCase(2, 3, 4, Description = "Значение меньше минимального")]
        [TestCase(8, 3, 4, Description = "Значение больше максимального")]
        [TestCase(7, 6, 4, Description = "Минимальное значение больше максимального")]

        [Test(Description = "Негативный тест конструктора параметра")]
        public void Test_Parameter_IncorrectValue(double value, double minValue, double maxValue)
        {
            //Assert
            Assert.Throws<ArgumentException>(() =>
            {
                //Act
                var parameter = new Parameter(value, minValue, maxValue);
            });
        }

        [TestCase(2, 3, 4, Description = "Значение по умолчанию меньше минимального")]
        [TestCase(8, 3, 4, Description = "Значение по умолчанию больше максимального")]
        [Test(Description = "Негативный тест конструктора параметра со значениями по умолчанию")]
        public void Test_Parameter_IncorrectDefaultValue(double defaultValue, double minValue, double maxValue)
        {
            //Assert
            Assert.Throws<ArgumentException>(() =>
            {
                //Act
                var parameter = new Parameter(defaultValue, minValue, maxValue,defaultValue);
            });
        }
    }
}
