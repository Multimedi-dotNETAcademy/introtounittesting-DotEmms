using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    class HtmlFormatterTest
    {
        HtmlFormatter _html;
        [SetUp]
        public void SetUp()
        {
            _html = new HtmlFormatter();
        }
        [TestCase("I am bold","<strong>I am bold</strong>")]
        [TestCase("I am bald", "<strong>I am bald</strong>")]
        public void HtmlFormatter_WhenCalled_ReturnCode(string input, string expectedResult)
        {
            string result = _html.FormatAsBold(input);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
