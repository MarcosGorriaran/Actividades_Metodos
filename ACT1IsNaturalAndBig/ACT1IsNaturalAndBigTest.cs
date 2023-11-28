using ACT1IsNaturalAndBig;

namespace ACT1IsNaturalAndBigTest
{
    [TestClass]
    public class ACT1IsNaturalAndBigTest
    {
        [TestMethod]
        public void IsNotNaturalDecimal()
        {
            //Arrange
            float value = 1.1f;
            bool result;

            //Act
            result = ACT1.IsNatural(value);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsNotNaturalZero()
        {
            //Arrange
            float value = 0;
            bool result;

            //Act
            result = ACT1.IsNatural(value);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsNotNaturalNegative()
        {
            //Arrange
            float value = -1;
            bool result;

            //Act
            result = ACT1.IsNatural(value);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsNatural()
        {
            //Arrange
            float value = 1;
            bool result;

            //Act
            result = ACT1.IsNatural(value);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AreEqueals()
        {
            //Arrange
            float firstValue = 1;
            float secondValue = 1;
            bool result;

            //Act
            result = ACT1.NumbersAreEqual(firstValue, secondValue);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AreNotEquals()
        {
            //Arrange
            float firstValue = 1;
            float secondValue = 2;
            bool result;

            //Act
            result = ACT1.NumbersAreEqual(firstValue, secondValue);

            //Assert
            Assert.IsFalse(result);
        }
    }
}