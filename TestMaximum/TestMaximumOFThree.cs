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
            FindMaximumUtility.FindMaxNumber<int> findMaxElement = new FindMaximumUtility.FindMaxNumber<int>(3, 1, 2);
            //int findMaxElement.maxElement = findMaxElement.findMax(3, 1, 2);
            Assert.AreEqual(3, findMaxElement.maxElement);                 
            
        }

        [Test]
        public void GivenMax_WhenAtSecondPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<int> findMaxElement = new FindMaximumUtility.FindMaxNumber<int>(1, 3, 2);
            //int findMaxElement.maxElement = findMaxElement.findMax(1, 3, 2);
            Assert.AreEqual(3, findMaxElement.maxElement);

        }

        [Test]
        public void GivenMax_WhenAtThirdPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<int> findMaxElement = new FindMaximumUtility.FindMaxNumber<int>(1, 2, 3);
            //int findMaxElement.maxElement = findMaxElement.findMax(1, 2, 3);
            Assert.AreEqual(3, findMaxElement.maxElement);

        }

        [Test]
        public void GivenMaxFloat_WhenAtFirstPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<float> findMaxElement = new FindMaximumUtility.FindMaxNumber<float>(3f, 1f, 2f);
            //float findMaxElement.maxElement = findMaxElement.findMax(3f, 1f, 2f);
            Assert.AreEqual(3f, findMaxElement.maxElement);

        }

        [Test]
        public void GivenMaxFloat_WhenAtSecondPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<float> findMaxElement = new FindMaximumUtility.FindMaxNumber<float>(3f, 1f, 2f);
            //float findMaxElement.maxElement = findMaxElement.findMax(1f, 3f, 2f);
            Assert.AreEqual(3f, findMaxElement.maxElement);

        }

        [Test]
        public void GivenMaxFloat_WhenAtThirdPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<float> findMaxElement = new FindMaximumUtility.FindMaxNumber<float>(3f, 1f, 2f);
            //float findMaxElement.maxElement = findMaxElement.findMax(1f, 2f, 3f);
            Assert.AreEqual(3f, findMaxElement.maxElement);

        }

        [Test]
        public void GivenMaxString_WhenAtFirstPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<string> findMaxElement = new FindMaximumUtility.FindMaxNumber<string>("3", "1", "2");
            //string findMaxElement.maxElement = findMaxElement.findMax("3", "1", "2");
            Assert.AreEqual("3", findMaxElement.maxElement);

        }

        [Test]
        public void GivenMaxString_WhenAtSecondPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<string> findMaxElement = new FindMaximumUtility.FindMaxNumber<string>("3", "1", "2");
            //string findMaxElement.maxElement = findMaxElement.findMax("1", "3", "2");
            Assert.AreEqual("3", findMaxElement.maxElement);

        }

        [Test]
        public void GivenMaxString_WhenAtThirdPosition_shouldReturnTrue()
        {
            FindMaximumUtility.FindMaxNumber<string> findMaxElement = new FindMaximumUtility.FindMaxNumber<string>("3", "1", "2");
            //string findMaxElement.maxElement = findMaxElement.findMax("1", "2", "3");
            Assert.AreEqual("3", findMaxElement.maxElement);

        }
    }
}