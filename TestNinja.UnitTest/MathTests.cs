using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    public class MathTests
    {
        private Math _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        /*Test methods usually follow this convention
        * MethodName_Scenario_ExpectedResult
        * GivenTheArguments_WhenMethodCalled_ThenExpectedResults
        */
        [Test]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            //ASSIGN
            int numA = 5;
            int numB = 7;
            //ACT / When
            int result = _math.Add(numA,numB);

            //ASSERT / Then
            Assert.AreEqual(12,result);
            //exact hetzelfde, geen van beide is beter
            //Assert.That(result, Is.EqualTo(12)); 

        }
        [TestCase(2,1,2)]
        [TestCase(1, 2, 2)]
        [TestCase(4, 4, 4)]
        public void Max_WhenCalled_ReturnBiggerNumber(int numA, int numB, int expectedResult)
        {
            //ACT / When
            int result = _math.Max(numA, numB);

            //ASSERT / Then
            Assert.AreEqual(expectedResult, result);

        }
        
        /*[Test]
        *public void Max_SecondArgumentIsGreater_SecondArgumentIsReturned()
        *{
        *    //ARRANGE / Given
        *    int numA = 1;
        *    int numB = 2;
        *
        *    //ACT / When
        *    int result = _math.Max(numA, numB);
        *
        *    //ASSERT / Then
        *    Assert.AreEqual(2, result);
        *
        *}
        *[Test]
        *public void Max_ArgumentsAreEqual_SameValueIsReturned()
        *{
        *    //ARRANGE / Given
        *    int numA = 2;
        *    int numB = 2;
        *
        *    //ACT / When
        *    int result = _math.Max(numA, numB);
        *
        *    //ASSERT / Then
        *    Assert.AreEqual(2, result);
        *}
        */

        [Test]
        public void GetOddNumbers_WhenGivenLimitHigherThanZero_ReturnOddNumber()
        {
            int[] expectedResult = { 1, 3, 5 };
            IEnumerable<int> result = _math.GetOddNumbers(5);
            
            //Assert.NotNull(result);
            //Assert.AreEqual(3, result.Count());
            Assert.AreEqual(expectedResult, result);
        }
    }
    
}
