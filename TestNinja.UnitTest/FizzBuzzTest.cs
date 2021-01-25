using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    class FizzBuzzTest
    {
        FizzBuzz _fizz;
        [SetUp]
        public void SetUp()
        {
            _fizz = new FizzBuzz();
        }
        [TestCase(3,"Fizz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(10, "Buzz")]
        [TestCase(4, "4")]
        public void GetOutput_WhenCalled_ReturnCorrectString(int number, string expectedResult)
        {
            string result = FizzBuzz.GetOutput(number);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
