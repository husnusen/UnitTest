using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
	[TestClass]
	public class UnitTest1
	{
		public Match match;

		[TestInitialize]
		public void Init()
		{
			this.match = new Match();
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

			var decoratedText = this.match.Decorate(actualText, subText);

			Assert.AreEqual(expectedResult, decoratedText);
		}
	}
}
