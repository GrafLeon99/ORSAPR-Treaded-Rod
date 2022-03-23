using NUnit.Framework;
using Plugin;
using System;

namespace PluginTests
{
    [TestFixture]
    public class ModelParametersTests
    {
        [Test(Description = "Позитивный тест конструктора со значениями по умолчанию")]
        public void Test_ModelParameters_CorrectValue()
        {
            //Arrange
            double mainDiameter = 14;
            double nutDiameter = 8;
            double boltDiameter = 12;
            double mainLength = 60;
            double nutLength = 40;
            double boltLength = 24;
            double nutStep = 1;
            double boltStep = 1;
            bool isChamfer = false;
            //Act
            var parameters = new ModelParameters();

            //Assert
            Assert.AreEqual(parameters.GetDefaultValue(ParameterNameTypes.MainDiameter), mainDiameter);
            Assert.AreEqual(parameters.GetDefaultValue(ParameterNameTypes.NutDiameter), nutDiameter);
            Assert.AreEqual(parameters.GetDefaultValue(ParameterNameTypes.BoltDiameter), boltDiameter);
            Assert.AreEqual(parameters.GetDefaultValue(ParameterNameTypes.MainLength), mainLength);
            Assert.AreEqual(parameters.GetDefaultValue(ParameterNameTypes.NutLength), nutLength);
            Assert.AreEqual(parameters.GetDefaultValue(ParameterNameTypes.BoltLength), boltLength);
            Assert.AreEqual(parameters.GetDefaultValue(ParameterNameTypes.NutStep), nutStep);
            Assert.AreEqual(parameters.GetDefaultValue(ParameterNameTypes.BoltStep), boltStep);
            Assert.AreEqual(parameters.IsChamfer, isChamfer);
        }


        [Test(Description = "Позитивный тест сеттеров и геттеров")]
        public void Test_SetValue_CorrectValue()
        {
            //Arrange
            double mainDiameter = 16;
            double nutDiameter = 8;
            double boltDiameter = 12;
            double mainLength = 60;
            double nutLength = 30;
            double boltLength = 24;
            double nutStep = 1;
            double boltStep = 1;
            bool isChamfer = true;

            //Act
            var parameters = new ModelParameters();
            parameters.SetValue(ParameterNameTypes.MainDiameter, mainDiameter);
            parameters.SetValue(ParameterNameTypes.NutDiameter, nutDiameter);
            parameters.SetValue(ParameterNameTypes.BoltDiameter, boltDiameter);
            parameters.SetValue(ParameterNameTypes.MainLength, mainLength);
            parameters.SetValue(ParameterNameTypes.NutLength, nutLength);
            parameters.SetValue(ParameterNameTypes.BoltLength, boltLength);
            parameters.SetValue(ParameterNameTypes.NutStep, nutStep);
            parameters.SetValue(ParameterNameTypes.BoltStep, boltStep);
            parameters.IsChamfer = isChamfer;

            //Assert
            Assert.AreEqual(parameters.GetValue(ParameterNameTypes.MainDiameter), mainDiameter);
            Assert.AreEqual(parameters.GetValue(ParameterNameTypes.NutDiameter), nutDiameter);
            Assert.AreEqual(parameters.GetValue(ParameterNameTypes.BoltDiameter), boltDiameter);
            Assert.AreEqual(parameters.GetValue(ParameterNameTypes.MainLength), mainLength);
            Assert.AreEqual(parameters.GetValue(ParameterNameTypes.NutLength), nutLength);
            Assert.AreEqual(parameters.GetValue(ParameterNameTypes.BoltLength), boltLength);
            Assert.AreEqual(parameters.GetValue(ParameterNameTypes.NutStep), nutStep);
            Assert.AreEqual(parameters.GetValue(ParameterNameTypes.BoltStep), boltStep);
            Assert.AreEqual(parameters.IsChamfer, isChamfer);
        }

        [TestCase(ParameterNameTypes.MainDiameter, 0, Description = "MainDiameter меньше допустимого")]
        [TestCase(ParameterNameTypes.NutDiameter, 0, Description = "NutDiameter меньше допустимого")]
        [TestCase(ParameterNameTypes.BoltDiameter, 0, Description = "BoltDiameter меньше допустимого")]
        [TestCase(ParameterNameTypes.MainLength, 0, Description = "MainLength меньше допустимого")]
        [TestCase(ParameterNameTypes.NutLength, 0, Description = "NutLength меньше допустимого")]
        [TestCase(ParameterNameTypes.BoltLength, 0, Description = "BoltLength меньше допустимого")]
        [TestCase(ParameterNameTypes.MainDiameter, 120, Description = "MainDiameter больше допустимого")]
        [TestCase(ParameterNameTypes.NutDiameter, 60, Description = "NutDiameter больше допустимого")]
        [TestCase(ParameterNameTypes.BoltDiameter, 60, Description = "BoltDiameter больше допустимого")]
        [TestCase(ParameterNameTypes.MainLength, 120, Description = "MainLength больше допустимого")]
        [TestCase(ParameterNameTypes.NutLength, 120, Description = "NutLength больше допустимого")]
        [TestCase(ParameterNameTypes.BoltLength, 120, Description = "BoltLength больше допустимого")]

        
        [Test(Description = "Негативный тест сеттера")]
        public void Test_SetValue_IncorrectValue(ParameterNameTypes parameter, double value)
        {
            //Arrange
            var parameters = new ModelParameters();
            //Assert
            Assert.Throws<ArgumentException>(() => 
            {
                //Act
                parameters.SetValue(parameter, value);
            });
        }

        [TestCase(ParameterNameTypes.MainDiameter, 16, 15, Description = "MainDiameter больше MainLength")]
        [TestCase(ParameterNameTypes.NutDiameter, 14, 12, Description = "NutDiameter больше NutLength")]
        [TestCase(ParameterNameTypes.BoltDiameter, 16, 15, Description = "BoltDiameter больше BoltLength")]
        [TestCase(ParameterNameTypes.MainLength, 15,16, Description = "MainLength меньше MainDiameter")]
        [TestCase(ParameterNameTypes.NutLength, 15, 16, Description = "NutLength меньше NutDiameter")]
        [TestCase(ParameterNameTypes.BoltLength, 15, 16, Description = "BoltLength меньше BoltDiameter")]

        [Test(Description = "Негативный тест сеттера для зависимости длина-диаметр")]
        public void Test_SetValue_IncorrectDependedDiameterValue(ParameterNameTypes parameter, double value, double dependentValue)
        {
            //Arrange
            var parameters = new ModelParameters();
            switch (parameter)
            {   
                case ParameterNameTypes.MainDiameter:
                    parameters.SetValue(ParameterNameTypes.NutLength, dependentValue);
                    parameters.SetValue(ParameterNameTypes.MainLength, dependentValue);
                    break;
                case ParameterNameTypes.MainLength:
                    parameters.SetValue(ParameterNameTypes.NutLength, value - 1);
                    parameters.SetValue(ParameterNameTypes.MainDiameter, dependentValue);
                    break;
                case ParameterNameTypes.NutDiameter:
                    parameters.SetValue(ParameterNameTypes.NutLength, dependentValue);
                    break;
                case ParameterNameTypes.NutLength:
                    parameters.SetValue(ParameterNameTypes.MainDiameter, dependentValue);
                    parameters.SetValue(ParameterNameTypes.NutDiameter, dependentValue);
                    break;
                case ParameterNameTypes.BoltDiameter:
                    parameters.SetValue(ParameterNameTypes.BoltLength, dependentValue);
                    break;
                case ParameterNameTypes.BoltLength:
                    parameters.SetValue(ParameterNameTypes.BoltDiameter, dependentValue);
                    break;
            }
            //Assert
            Assert.Throws<ArgumentException>(() => 
            {
                //Act
                parameters.SetValue(parameter, value);
            });
        }

        [TestCase(ParameterNameTypes.MainLength, 40, 50, Description = "MainLength меньше NutLength")]
        [TestCase(ParameterNameTypes.NutLength, 50, 40, Description = "NutLength больше MainLength")]
        [TestCase(ParameterNameTypes.MainDiameter, 12, 13, Description = "MainDiameter меньше NutDiameter")]
        [TestCase(ParameterNameTypes.NutDiameter, 13, 12, Description = "NutDiameter больше MainDiameter")]

        [Test(Description = "Негативный тест сеттера для зависимости длина-длина/диметр-диаметр")]
        public void Test_SetValue_IncorrectDependedLengthValue(ParameterNameTypes parameter, double value, double dependentValue)
        {
            //Arrange
            var parameters = new ModelParameters();
            switch (parameter)
            {
                case ParameterNameTypes.MainLength:
                    parameters.SetValue(ParameterNameTypes.NutLength, dependentValue);
                    break;
                case ParameterNameTypes.NutLength:
                    parameters.SetValue(ParameterNameTypes.MainLength, dependentValue);
                    break;
                case ParameterNameTypes.MainDiameter:
                    parameters.SetValue(ParameterNameTypes.NutDiameter, dependentValue);
                    break;
                case ParameterNameTypes.NutDiameter:
                    parameters.SetValue(ParameterNameTypes.MainDiameter, dependentValue);
                    break;
            }
            //Assert
            Assert.Throws<ArgumentException>(() => 
            {
                //Act
                parameters.SetValue(parameter, value);
            });
        }
    }
}