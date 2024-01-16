using Super4Game;
namespace ACT32Super4GameTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ContainsWordGroupCountNormal()
        {
            int result, expected=3;
            char[] searchTarget = new char[] {'a','e','i','o','u'};
            string searchName = "Caiman";

            result = Execute.ContainsWordGroup(searchName);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ContainsWordGroupCountEmptyNameCase() 
        {
            int result, expected = 0;
            char[] searchTarget = new char[] { 'a', 'e', 'i', 'o', 'u' };
            string searchName = "";

            result = Execute.ContainsWordGroup(searchName);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SplitBetweenGroup()
        {
            float result, expected= 1250.75f;
            int darknessCase = 5003, amountGroupMembers = 4;

            result = Execute.SplitBetweenGroup(darknessCase, amountGroupMembers);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ExtractPercentAmount()
        {
            int result, expected = 250, darknessCase = 5017, percentAmount=5;

            result = Execute.ExtractPercentAmount(darknessCase, percentAmount);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void InRangeMinCase()
        {
            int minRange = 1000, maxRange = 50000, checkValue = 1000;

            Assert.IsTrue(Execute.InRange(checkValue, minRange, maxRange));
        }
        [TestMethod]
        public void InRangeMaxCase()
        {
            int minRange = 1000, maxRange = 50000, checkValue = 50000;

            Assert.IsTrue(Execute.InRange(checkValue, minRange, maxRange));
        }
        [TestMethod]
        public void InRangeMinWrongCase()
        {
            int minRange = 1000, maxRange = 50000, checkValue = 1000;

            Assert.IsTrue(Execute.InRange(checkValue, minRange, maxRange));
        }
        [TestMethod]
        public void InRangeMaxWrongCase()
        {
            int minRange = 1000, maxRange = 50000, checkValue = 50000;

            Assert.IsTrue(Execute.InRange(checkValue, minRange, maxRange));
        }
    }
}