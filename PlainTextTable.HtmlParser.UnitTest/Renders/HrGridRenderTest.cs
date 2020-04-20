using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlainTextTable.HtmlParser.Renders;

namespace PlainTextTable.HtmlParser.UnitTest.Renders
{
    [TestClass]
    public class HrGridRenderTest
    {
        [TestMethod]
        public void Hr()
        {
            const string html = "<hr/>";
            var paragraphGridRender = new HrGridRender(html);

            var actual = paragraphGridRender.Render(57);
            const string expected = "---------------------------------------------------------";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PadValue()
        {
            const string html = "<hr pad-value='#'/>";
            var paragraphGridRender = new HrGridRender(html);

            var actual = paragraphGridRender.Render(57);
            const string expected = "#########################################################";

            Assert.AreEqual(expected, actual);
        }
    }
}