using NUnit.Framework;

namespace TestMaximum
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenMax_WhenAtFirstPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber findMaxNumber = new FindMaximumUtility.FindMaxNumber();
            int maxNumber = findMaxNumber.findMax(3, 1, 2);
            Assert.AreEqual(3, maxNumber);                 
            
        }

        [Test]
        public void GivenMax_WhenAtSecondPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber findMaxNumber = new FindMaximumUtility.FindMaxNumber();
            int maxNumber = findMaxNumber.findMax(1, 3, 2);
            Assert.AreEqual(3, maxNumber);

        }

        [Test]
        public void GivenMax_WhenAtThirdPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber findMaxNumber = new FindMaximumUtility.FindMaxNumber();
            int maxNumber = findMaxNumber.findMax(1, 2, 3);
            Assert.AreEqual(3, maxNumber);

        }
    }
}