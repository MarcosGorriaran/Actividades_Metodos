using ACT11GetNumberPower;

namespace ACT11FindFactorialTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void FactorialRightResults()
        {
            //Arrange
            uint[] providedValues = new uint[] { 0, 1, 2, 3, 4, 5 };
            uint[] expectedResults = new uint[] { 1, 1, 2, 6, 24, 120 };
            uint[] results = new uint[providedValues.Length];
            //Act
            for(uint i = 0; i < providedValues.Length; i++)
            {
                results[i] = ACT11.Factorial(providedValues[i]);
            }
            //Assert
            for (uint i = 0; i < expectedResults.Length; i++)
            {
                if (expectedResults[i] != results[i])
                {
                    Assert.Fail("La lista de resultados no es similar");
                }
            }
            
        }
    }
}