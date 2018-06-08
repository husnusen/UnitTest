using ConsoleApp1;
using ConsoleApp1.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
	[TestClass]
	public class UnitTest1
	{
		 //public Match match;
        public IDecorator _decorator;

		[TestInitialize]
		public void Init()
		{
            //this.match = new Match();
            _decorator = new Match();
		}

        /// <summary>
        /// This test illustrates the basic case. There are several flaws with the existing algorithm.
        /// Add more tests to illustrate the problems and demonstrate that you fixed them.
        /// </summary>
		[TestMethod]
		public void TestMethod1()
		{
			var actualText = "this is a test.";
			var subText = "this test";
			var expectedResult = "<span>this</span> is a <span>test</span>.";

			var decoratedText = _decorator.Decorate(actualText, subText);

			Assert.AreEqual(expectedResult, decoratedText);
		}

        [TestMethod]
        public void IsActualTextIsNullOrEmpty_TestMethod()
        {
            var actualText = "";
            var subText = "this test"; 
            var expectedResult = "";

            var decoratedText = _decorator.Decorate(actualText, subText);

            Assert.AreEqual(expectedResult, decoratedText);
        }

        [TestMethod]
        public void IsSubTextIsNullOrEmpty_TestMethod()
        {
            var actualText = "this is a test.";
            var subText = "";
            var expectedResult = "";

            var decoratedText = _decorator.Decorate(actualText, subText);

            Assert.AreEqual(expectedResult, decoratedText);
        }

        [TestMethod]
        public void DecorateWithoneWord_Test()
        {
            var actualText = "This is a test.";
            var subText = "this";
            var expectedResult = "<span>This</span> is a test.";

            var decoratedText = _decorator.Decorate(actualText, subText);

            Assert.AreEqual(expectedResult, decoratedText);
        }

        [TestMethod]
        public void HighligtedWithMultiSpanTag_Test()
        {
            var actualText = "this is a test.";
            var subText = "this test test";
            var expectedResult = "<span>this</span> is a <span><span>test</span></span>.";

            var decoratedText = _decorator.Decorate(actualText, subText);

            Assert.AreEqual(expectedResult, decoratedText);
        }

        [TestMethod]
        public void HighligtedWithOnlyOneSpanTag_Test()
        {
            var actualText = "this is a test.";
            var subText = "this test test";
            var expectedResult = "<span>this</span> is a  <span>test</span>.";
            
            var decoratedText = _decorator.Decorate(actualText, subText);

            Assert.AreEqual(expectedResult, decoratedText);
        }

        [TestMethod]
        public void CheckCaseSensitive_Test()
        {
            var actualText = "This is a Case Sensitive test.";
            var subText = "this case test";
            var expectedResult = "<span>This</span> is a <span>Case</span> Sensitive <span>test</span>.";

            var decoratedText = _decorator.Decorate(actualText, subText);

            Assert.AreEqual(expectedResult, decoratedText);
        }

        [TestMethod]
        public void CheckCaseSensitiveWithUpper_Test()
        {
            var actualText = "THIS IS A TEST.";
            var subText = "this test";
            var expectedResult = "<span>THIS</span> IS A <span>TEST</span>.";

            var decoratedText = _decorator.Decorate(actualText, subText);

            Assert.AreEqual(expectedResult, decoratedText);
        }

        [TestMethod]
        public void CheckCaseSensitiveWithLower_Test()
        {
            var actualText = "this is a test.";
            var subText = "this Test";
            var expectedResult = "<span>this</span> is a <span>test</span>.";

            var decoratedText = _decorator.Decorate(actualText, subText);

            Assert.AreEqual(expectedResult, decoratedText);
        }
        [TestMethod]
        public void NotFoundCharacterInText_Test()
        {
            var actualText = "this is a test.";
            var subText = "this solution";
            var expectedResult = "<span>this</span> is a test.";

            var decoratedText = _decorator.Decorate(actualText, subText);

            Assert.AreEqual(expectedResult, decoratedText);
        }
    }
}
