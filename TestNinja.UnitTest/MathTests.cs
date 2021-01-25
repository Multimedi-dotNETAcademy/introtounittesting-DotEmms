using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    public class MathTests
    {
        /*Test methods usually follow this convention
        * MethodName_Scenario_ExpectedResult
        * GivenTheArguments_WhenMethodCalled_ThenExpectedResults
        */
        [Test]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            //ARRANGE / Given
            int numA = 5;
            int numB = 7;
            Math myMathClass = new Math();

            //ACT / When
            int result = myMathClass.Add(numA,numB);

            //ASSERT / Then
            Assert.AreEqual(12,result);
            //exact hetzelfde, geen van beide is beter
            //Assert.That(result, Is.EqualTo(12)); 

        }
        [Test]
        public void Max_FirstArgumentIsGreater_FirstArgumentIsReturned()
        {
            //ARRANGE / Given
            int numA = 2;
            int numB = 1;
            Math myMathClass = new Math();

            //ACT / When
            int result = myMathClass.Max(numA, numB);

            //ASSERT / Then
            Assert.AreEqual(2, result);

        }
        [Test]
        public void Max_SecondArgumentIsGreater_SecondArgumentIsReturned()
        {
            //ARRANGE / Given
            int numA = 1;
            int numB = 2;
            Math myMathClass = new Math();

            //ACT / When
            int result = myMathClass.Max(numA, numB);

            //ASSERT / Then
            Assert.AreEqual(2, result);

        }
        [Test]
        public void Max_ArgumentsAreEqual_SameValueIsReturned()
        {
            //ARRANGE / Given
            int numA = 2;
            int numB = 2;
            Math myMathClass = new Math();

            //ACT / When
            int result = myMathClass.Max(numA, numB);

            //ASSERT / Then
            Assert.AreEqual(2, result);

        }
    }
    
}
