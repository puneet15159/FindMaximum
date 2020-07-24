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
            FindMaximumUtility.FindMaxNumber<int> findMaxNumber = new FindMaximumUtility.FindMaxNumber<int>();
            int maxNumber = findMaxNumber.findMax(3, 1, 2);
            Assert.AreEqual(3, maxNumber);                 
            
        }

        [Test]
        public void GivenMax_WhenAtSecondPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<int> findMaxNumber = new FindMaximumUtility.FindMaxNumber<int>();
            int maxNumber = findMaxNumber.findMax(1, 3, 2);
            Assert.AreEqual(3, maxNumber);

        }

        [Test]
        public void GivenMax_WhenAtThirdPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<int> findMaxNumber = new FindMaximumUtility.FindMaxNumber<int>();
            int maxNumber = findMaxNumber.findMax(1, 2, 3);
            Assert.AreEqual(3, maxNumber);

        }

        [Test]
        public void GivenMaxFloat_WhenAtFirstPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<float> findMaxNumber = new FindMaximumUtility.FindMaxNumber<float>();
            float maxNumber = findMaxNumber.findMax(3f, 1f, 2f);
            Assert.AreEqual(3f, maxNumber);

        }

        [Test]
        public void GivenMaxFloat_WhenAtSecondPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<float> findMaxNumber = new FindMaximumUtility.FindMaxNumber<float>();
            float maxNumber = findMaxNumber.findMax(1f, 3f, 2f);
            Assert.AreEqual(3f, maxNumber);

        }

        [Test]
        public void GivenMaxFloat_WhenAtThirdPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<float> findMaxNumber = new FindMaximumUtility.FindMaxNumber<float>();
            float maxNumber = findMaxNumber.findMax(1f, 2f, 3f);
            Assert.AreEqual(3f, maxNumber);

        }

        [Test]
        public void GivenMaxString_WhenAtFirstPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<string> findMaxNumber = new FindMaximumUtility.FindMaxNumber<string>();
            string maxNumber = findMaxNumber.findMax("3", "1", "2");
            Assert.AreEqual("3", maxNumber);

        }

        [Test]
        public void GivenMaxString_WhenAtSecondPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<string> findMaxNumber = new FindMaximumUtility.FindMaxNumber<string>();
            string maxNumber = findMaxNumber.findMax("1", "3", "2");
            Assert.AreEqual("3", maxNumber);

        }

        [Test]
        public void GivenMaxString_WhenAtThirdPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<string> findMaxNumber = new FindMaximumUtility.FindMaxNumber<string>();
            string maxNumber = findMaxNumber.findMax("1", "2", "3");
            Assert.AreEqual("3", maxNumber);

        }
    }
}