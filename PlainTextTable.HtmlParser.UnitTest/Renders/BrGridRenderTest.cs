using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlainTextTable.HtmlParser.Renders;

namespace PlainTextTable.HtmlParser.UnitTest.Renders
{
    [TestClass]
    public class BrGridRenderTest
    {
        [TestMethod]
        public void Br()
        {
            const string html = "<br/>";
            var paragraphGridRender = new BrGridRender(html);

            var actual = paragraphGridRender.Render(57);
            const string expected = "                                                         ";

            Assert.AreEqual(expected, actual);
        }
    }
}