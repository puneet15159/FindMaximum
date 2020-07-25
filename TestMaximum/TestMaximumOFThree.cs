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
        public void GivenMax_WhenAtFirstPosition_shouldReturnMaxElement()
        {
            FindMaximumUtility.FindMaxNumber<int> findMaxElement = new FindMaximumUtility.FindMaxNumber<int>();
            int maxElement = findMaxElement.findMax(3, 1, 2,1,1);
            Assert.AreEqual(3, maxElement);                 
            
        }

        [Test]
        public void GivenMax_WhenAtSecondPosition_shouldReturnMaxElement()
        {
            FindMaximumUtility.FindMaxNumber<int> findMaxElement = new FindMaximumUtility.FindMaxNumber<int>();
            int maxElement = findMaxElement.findMax(1, 3, 2, 1, 1);
            Assert.AreEqual(3, maxElement);

        }

        [Test]
        public void GivenMax_WhenAtThirdPosition_shouldReturnMaxElement()
        {
            FindMaximumUtility.FindMaxNumber<int> findMaxElement = new FindMaximumUtility.FindMaxNumber<int>();
            int maxElement = findMaxElement.findMax(1, 2, 3, 1, 1);
            Assert.AreEqual(3, maxElement);

        }

        [Test]
        public void GivenMaxFloat_WhenAtFirstPosition_shouldReturnMaxElement()
        {
            FindMaximumUtility.FindMaxNumber<float> findMaxElement = new FindMaximumUtility.FindMaxNumber<float>();
            float maxElement = findMaxElement.findMax(3f, 1f, 2f, 1f, 1f);
            Assert.AreEqual(3f, maxElement);

        }

        [Test]
        public void GivenMaxFloat_WhenAtSecondPosition_shouldReturnMaxElement()
        {
            FindMaximumUtility.FindMaxNumber<float> findMaxElement = new FindMaximumUtility.FindMaxNumber<float>();
            float maxElement = findMaxElement.findMax(1f, 3f, 2f, 1f, 1f);
            Assert.AreEqual(3f, maxElement);

        }

        [Test]
        public void GivenMaxFloat_WhenAtThirdPosition_shouldReturnMaxElement()
        {
            FindMaximumUtility.FindMaxNumber<float> findMaxElement = new FindMaximumUtility.FindMaxNumber<float>();
            float maxElement = findMaxElement.findMax(1f, 2f, 3f, 1f, 1f);
            Assert.AreEqual(3f, maxElement);

        }

        [Test]
        public void GivenMaxString_WhenAtFirstPosition_shouldReturnMaxElement()
        {
            FindMaximumUtility.FindMaxNumber<string> findMaxElement = new FindMaximumUtility.FindMaxNumber<string>();
            string maxElement = findMaxElement.findMax("3", "1", "2", "1", "1");
            Assert.AreEqual("3", maxElement);

        }

        [Test]
        public void GivenMaxString_WhenAtSecondPosition_shouldReturnMaxElement()
        {
            FindMaximumUtility.FindMaxNumber<string> findMaxElement = new FindMaximumUtility.FindMaxNumber<string>();
            string maxElement = findMaxElement.findMax("1", "3", "2", "1", "1");
            Assert.AreEqual("3", maxElement);

        }

        [Test]
        public void GivenMaxString_WhenAtThirdPosition_shouldReturnMaxElement()
        {
            FindMaximumUtility.FindMaxNumber<string> findMaxElement = new FindMaximumUtility.FindMaxNumber<string>();
            string maxElement = findMaxElement.findMax("1", "2", "3", "1", "1");
            Assert.AreEqual("3", maxElement);

        }
    }
}