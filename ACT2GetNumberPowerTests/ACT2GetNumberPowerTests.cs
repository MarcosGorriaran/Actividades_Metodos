using ACT2GetNumberPower;

namespace ACT2GetNumberPowerTests
{
    [TestClass]
    public class ACT2GetNumberPowerTests
    {
        [TestMethod]
        public void ExponentByBothZero()
        {
            //Arrange
            const float ExpectedValue = 1;
            const int Value = 0;
            const int Exponent = 0;
            float result;

            //Act
            result = ACT2.Exponent(Value, Exponent);

            //Assert
            Assert.AreEqual(ExpectedValue, result);
        }
        [TestMethod]
        public void ExponentByValueZero()
        {
            //Arrange
            const float ExpectedValue = 0;
            const int Value = 0;
            const int Exponent = 2;
            float result;

            //Act
            result = ACT2.Exponent(Value, Exponent);

            //Assert
            Assert.AreEqual(ExpectedValue, result);
        }
        [TestMethod]
        public void ExponentByNegativeValueOddExponent()
        {
            //Arrange
            const float ExpectedValue = -8;
            const int Value = -2;
            const int Exponent = 3;
            float result;

            //Act
            result = ACT2.Exponent(Value, Exponent);

            //Assert
            Assert.AreEqual(ExpectedValue, result);
        }
        [TestMethod]
        public void ExponentByNegativeValueEvenExponent()
        {
            //Arrange
            const float ExpectedValue = 4;
            const int Value = -2;
            const int Exponent = 2;
            float result;

            //Act
            result = ACT2.Exponent(Value, Exponent);

            //Assert
            Assert.AreEqual(ExpectedValue, result);
        }
        [TestMethod]
        public void ExponentByNegativeExponent()
        {
            //Arrange
            const float ExpectedValue = 0.25f;
            const int Value = 2;
            const int Exponent = -2;
            float result;

            //Act
            result = ACT2.Exponent(Value, Exponent);

            //Assert
            Assert.AreEqual(ExpectedValue, result);
        }
    }
}